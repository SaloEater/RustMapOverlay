/*
    TestClient for obs-websocket-dotnet
    Copyright (C) 2017	Stéphane Lepin <stephane.lepin@gmail.com>

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program. If not, see <https://www.gnu.org/licenses/>
*/

//lemme upload, git T_T
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using OBSWebsocketDotNet;

namespace TestClient
{
    public partial class MainWindow : Form
    {
        protected OBSWebsocket _obs;
        KeyboardHook keyboardHook;

        string overlayImage;

        string overlayKey;

        string rustClientName = "Rust";

        bool overlayShown = false;

        public MainWindow()
        {
            InitializeComponent();
            _obs = new OBSWebsocket();

            _obs.Connected += onConnect;
            _obs.Disconnected += onDisconnect;

            _obs.SceneChanged += onSceneChange;
            /*_obs.SceneCollectionChanged += onSceneColChange;
            _obs.ProfileChanged += onProfileChange;
            _obs.TransitionChanged += onTransitionChange;
            _obs.TransitionDurationChanged += onTransitionDurationChange;

            _obs.StreamingStateChanged += onStreamingStateChange;
            _obs.RecordingStateChanged += onRecordingStateChange;

            _obs.StreamStatus += onStreamData;*/

            tvScenes.AfterSelect += TvScenes_AfterSelect;

            keyboardHook = new KeyboardHook();

            keyboardHook.KeyDown += KeyboardHook_KeyDown;
            keyboardHook.KeyUp += KeyboardHook_KeyUp;

            keyboardHook.Install();

            FillOverlayKeysList();
            comboBoxOverlayKeys.SelectedIndexChanged += ComboBoxOverlayKeys_SelectedIndexChanged;
        }

        private void ComboBoxOverlayKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            overlayKey = (string)comboBoxOverlayKeys.SelectedItem;
        }

        private void FillOverlayKeysList()
        {
            foreach(string vkey in Enum.GetNames(typeof(KeyboardHook.VKeys)))
            {
                comboBoxOverlayKeys.Items.Add(vkey);
            }
        }

        private void TvScenes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Parent != null)
            {
                overlayImage = e.Node.Text;
                labelOverlayName.Text = overlayImage;
            }
        }

        private void KeyboardHook_KeyUp(KeyboardHook.VKeys key)
        {
            string _key = key.ToString();
            if (_obs.IsConnected && _key.Equals(overlayKey) && overlayShown)
            {
                _obs.SetSourceRender(overlayImage, false);
                overlayShown = false;
            }
        }

        private void KeyboardHook_KeyDown(KeyboardHook.VKeys key)
        {
            string _key = key.ToString();
            if (_obs.IsConnected && !overlayShown)
            {
                if (_key.Equals(overlayKey) && overlayImage != null && GetActiveWindowTitle().Equals(rustClientName))
                {
                    _obs.SetSourceRender(overlayImage, true);
                    overlayShown = true;
                }
            }
        }

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        private void onConnect(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)(() => {
                txtServerIP.Enabled = false;
                txtServerPassword.Enabled = false;
                btnConnect.Text = "Disconnect";

                gbControls.Enabled = true;

                var versionInfo = _obs.GetVersion();

                btnListScenes.PerformClick();
                /*tbPluginVersion.Text = versionInfo.PluginVersion;
                tbOBSVersion.Text = versionInfo.OBSStudioVersion;
                btnGetCurrentScene.PerformClick();

                btnListSceneCol.PerformClick();
                btnGetCurrentSceneCol.PerformClick();

                btnListProfiles.PerformClick();
                btnGetCurrentProfile.PerformClick();

                btnListTransitions.PerformClick();
                btnGetCurrentTransition.PerformClick();

                btnGetTransitionDuration.PerformClick();

                var streamStatus = _obs.GetStreamingStatus();
                if (streamStatus.IsStreaming)
                    onStreamingStateChange(_obs, OutputState.Started);
                else
                    onStreamingStateChange(_obs, OutputState.Stopped);

                if (streamStatus.IsRecording)
                    onRecordingStateChange(_obs, OutputState.Started);
                else
                    onRecordingStateChange(_obs, OutputState.Stopped);*/
            }));
        }

        private void onDisconnect(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)(() => {
                gbControls.Enabled = false;

                txtServerIP.Enabled = true;
                txtServerPassword.Enabled = true;
                btnConnect.Text = "Connect";
            }));
        }

        private void onSceneChange(OBSWebsocket sender, string newSceneName)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                tbCurrentScene.Text = newSceneName;
            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(!_obs.IsConnected)
            {
                try
                {
                    _obs.Connect(txtServerIP.Text, txtServerPassword.Text);
                }
                catch (AuthFailureException)
                {
                    MessageBox.Show("Authentication failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                catch (ErrorResponseException ex)
                {
                    MessageBox.Show("Connect failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            } else
            {
                _obs.Disconnect();
            }
        }

        private void btnListScenes_Click(object sender, EventArgs e)
        {
            var scenes = _obs.ListScenes();

            tvScenes.Nodes.Clear();
            foreach(var scene in scenes)
            {
                var node = new TreeNode(scene.Name);
                foreach (var item in scene.Items)
                {
                    node.Nodes.Add(item.SourceName);
                }

                tvScenes.Nodes.Add(node);
            }
        }

        private void btnGetCurrentScene_Click(object sender, EventArgs e)
        {
            tbCurrentScene.Text = _obs.GetCurrentScene().Name;
        }

        private void btnSetCurrentScene_Click(object sender, EventArgs e)
        {
            _obs.SetCurrentScene(tbCurrentScene.Text);
        }

        private void tvScenes_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                tbCurrentScene.Text = e.Node.Text;
            }
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
    }
}