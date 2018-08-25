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

namespace TestClient
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtServerPassword = new System.Windows.Forms.TextBox();
            this.tvScenes = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetCurrentScene = new System.Windows.Forms.Button();
            this.btnGetCurrentScene = new System.Windows.Forms.Button();
            this.btnListScenes = new System.Windows.Forms.Button();
            this.tbCurrentScene = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.labelOverlayName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOverlayKeys = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(511, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtServerIP
            // 
            this.txtServerIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerIP.Location = new System.Drawing.Point(203, 7);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(114, 20);
            this.txtServerIP.TabIndex = 2;
            this.txtServerIP.Text = "ws://127.0.0.1:4444";
            // 
            // txtServerPassword
            // 
            this.txtServerPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerPassword.Location = new System.Drawing.Point(391, 7);
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.Size = new System.Drawing.Size(114, 20);
            this.txtServerPassword.TabIndex = 3;
            this.txtServerPassword.UseSystemPasswordChar = true;
            // 
            // tvScenes
            // 
            this.tvScenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvScenes.Location = new System.Drawing.Point(6, 49);
            this.tvScenes.Name = "tvScenes";
            this.tvScenes.Size = new System.Drawing.Size(138, 118);
            this.tvScenes.TabIndex = 4;
            this.tvScenes.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvScenes_NodeMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetCurrentScene);
            this.groupBox1.Controls.Add(this.btnGetCurrentScene);
            this.groupBox1.Controls.Add(this.btnListScenes);
            this.groupBox1.Controls.Add(this.tvScenes);
            this.groupBox1.Controls.Add(this.tbCurrentScene);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 243);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scene List with Items";
            // 
            // btnSetCurrentScene
            // 
            this.btnSetCurrentScene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCurrentScene.Location = new System.Drawing.Point(78, 199);
            this.btnSetCurrentScene.Name = "btnSetCurrentScene";
            this.btnSetCurrentScene.Size = new System.Drawing.Size(66, 38);
            this.btnSetCurrentScene.TabIndex = 1;
            this.btnSetCurrentScene.Text = "Set\r\nCurScene";
            this.btnSetCurrentScene.UseVisualStyleBackColor = true;
            this.btnSetCurrentScene.Click += new System.EventHandler(this.btnSetCurrentScene_Click);
            // 
            // btnGetCurrentScene
            // 
            this.btnGetCurrentScene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetCurrentScene.Location = new System.Drawing.Point(6, 199);
            this.btnGetCurrentScene.Name = "btnGetCurrentScene";
            this.btnGetCurrentScene.Size = new System.Drawing.Size(62, 38);
            this.btnGetCurrentScene.TabIndex = 2;
            this.btnGetCurrentScene.Text = "Get\r\nCurScene";
            this.btnGetCurrentScene.UseVisualStyleBackColor = true;
            this.btnGetCurrentScene.Click += new System.EventHandler(this.btnGetCurrentScene_Click);
            // 
            // btnListScenes
            // 
            this.btnListScenes.Location = new System.Drawing.Point(7, 20);
            this.btnListScenes.Name = "btnListScenes";
            this.btnListScenes.Size = new System.Drawing.Size(75, 23);
            this.btnListScenes.TabIndex = 5;
            this.btnListScenes.Text = "ListScenes";
            this.btnListScenes.UseVisualStyleBackColor = true;
            this.btnListScenes.Click += new System.EventHandler(this.btnListScenes_Click);
            // 
            // tbCurrentScene
            // 
            this.tbCurrentScene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentScene.Location = new System.Drawing.Point(6, 173);
            this.tbCurrentScene.Name = "tbCurrentScene";
            this.tbCurrentScene.Size = new System.Drawing.Size(138, 20);
            this.tbCurrentScene.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP:PORT :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password :";
            // 
            // gbControls
            // 
            this.gbControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbControls.Controls.Add(this.groupBox8);
            this.gbControls.Controls.Add(this.groupBox1);
            this.gbControls.Enabled = false;
            this.gbControls.Location = new System.Drawing.Point(12, 34);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(574, 515);
            this.gbControls.TabIndex = 9;
            this.gbControls.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel3);
            this.groupBox8.Location = new System.Drawing.Point(162, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(238, 70);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Overlay";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.51724F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.48276F));
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelOverlayName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxOverlayKeys, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(232, 51);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Key :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOverlayName
            // 
            this.labelOverlayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOverlayName.AutoSize = true;
            this.labelOverlayName.Location = new System.Drawing.Point(96, 6);
            this.labelOverlayName.Name = "labelOverlayName";
            this.labelOverlayName.Size = new System.Drawing.Size(133, 13);
            this.labelOverlayName.TabIndex = 18;
            this.labelOverlayName.Text = "n/a";
            this.labelOverlayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Overlay name :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxOverlayKeys
            // 
            this.comboBoxOverlayKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxOverlayKeys.FormattingEnabled = true;
            this.comboBoxOverlayKeys.Location = new System.Drawing.Point(96, 28);
            this.comboBoxOverlayKeys.Name = "comboBoxOverlayKeys";
            this.comboBoxOverlayKeys.Size = new System.Drawing.Size(133, 21);
            this.comboBoxOverlayKeys.TabIndex = 20;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 561);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerPassword);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.btnConnect);
            this.Name = "MainWindow";
            this.Text = "obs-websocket client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtServerPassword;
        private System.Windows.Forms.TreeView tvScenes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListScenes;
        private System.Windows.Forms.Button btnGetCurrentScene;
        private System.Windows.Forms.Button btnSetCurrentScene;
        private System.Windows.Forms.TextBox tbCurrentScene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Label labelOverlayName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxOverlayKeys;
    }
}

