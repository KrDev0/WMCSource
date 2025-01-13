using WMC;

namespace WindowsMediaCreator
{
    partial class DownloadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblDownSpeed = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.lblDescargado = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblwinver = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDownload = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picYoutube = new System.Windows.Forms.PictureBox();
            this.picX = new System.Windows.Forms.PictureBox();
            this.grbDevInfo = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelYoutube = new System.Windows.Forms.Panel();
            this.linkYoutube = new System.Windows.Forms.LinkLabel();
            this.panelx = new System.Windows.Forms.Panel();
            this.linkTwitter = new System.Windows.Forms.LinkLabel();
            this.panelLink = new System.Windows.Forms.Panel();
            this.picLinkTree = new System.Windows.Forms.PictureBox();
            this.linkTree = new System.Windows.Forms.LinkLabel();
            this.panelDiscord = new System.Windows.Forms.Panel();
            this.picDiscord = new System.Windows.Forms.PictureBox();
            this.linkDiscord = new System.Windows.Forms.LinkLabel();
            this.panelPatreon = new System.Windows.Forms.Panel();
            this.picPatreon = new System.Windows.Forms.PictureBox();
            this.linkPatreon = new System.Windows.Forms.LinkLabel();
            this.panelInstagram = new System.Windows.Forms.Panel();
            this.picInstagram = new System.Windows.Forms.PictureBox();
            this.linkInstagram = new System.Windows.Forms.LinkLabel();
            this.panelTikTok = new System.Windows.Forms.Panel();
            this.picTikTok = new System.Windows.Forms.PictureBox();
            this.linkTikTok = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picWeb = new System.Windows.Forms.PictureBox();
            this.linkWebSite = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).BeginInit();
            this.grbDevInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelYoutube.SuspendLayout();
            this.panelx.SuspendLayout();
            this.panelLink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkTree)).BeginInit();
            this.panelDiscord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDiscord)).BeginInit();
            this.panelPatreon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPatreon)).BeginInit();
            this.panelInstagram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInstagram)).BeginInit();
            this.panelTikTok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTikTok)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWeb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(12, 549);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 59);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(460, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // lblDownSpeed
            // 
            this.lblDownSpeed.Location = new System.Drawing.Point(6, 16);
            this.lblDownSpeed.Name = "lblDownSpeed";
            this.lblDownSpeed.Size = new System.Drawing.Size(128, 13);
            this.lblDownSpeed.TabIndex = 3;
            this.lblDownSpeed.Text = "Download speed:";
            this.lblDownSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(125, 16);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(0, 13);
            this.lblVelocidad.TabIndex = 4;
            // 
            // lblDown
            // 
            this.lblDown.Location = new System.Drawing.Point(6, 39);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(118, 13);
            this.lblDown.TabIndex = 6;
            this.lblDown.Text = "Downloaded:";
            this.lblDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProgreso
            // 
            this.lblProgreso.Location = new System.Drawing.Point(335, 87);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(123, 13);
            this.lblProgreso.TabIndex = 7;
            this.lblProgreso.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDescargado
            // 
            this.lblDescargado.AutoSize = true;
            this.lblDescargado.Location = new System.Drawing.Point(125, 39);
            this.lblDescargado.Name = "lblDescargado";
            this.lblDescargado.Size = new System.Drawing.Size(0, 13);
            this.lblDescargado.TabIndex = 8;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "ISO Files|*.iso";
            this.saveFileDialog1.Title = "Save file";
            // 
            // btnPause
            // 
            this.btnPause.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPause.Location = new System.Drawing.Point(409, 549);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblName.Location = new System.Drawing.Point(12, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 26);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "NAME";
            this.lblName.TextChanged += new System.EventHandler(this.lblName_TextChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblVersion.Location = new System.Drawing.Point(12, 47);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 12;
            this.lblVersion.Text = "Version";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDev.Location = new System.Drawing.Point(12, 65);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(25, 13);
            this.lblDev.TabIndex = 13;
            this.lblDev.Text = "dev";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSize.Location = new System.Drawing.Point(12, 83);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(25, 13);
            this.lblSize.TabIndex = 14;
            this.lblSize.Text = "size";
            // 
            // lblwinver
            // 
            this.lblwinver.AutoSize = true;
            this.lblwinver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblwinver.Location = new System.Drawing.Point(12, 101);
            this.lblwinver.Name = "lblwinver";
            this.lblwinver.Size = new System.Drawing.Size(38, 13);
            this.lblwinver.TabIndex = 15;
            this.lblwinver.Text = "winver";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVelocidad);
            this.groupBox1.Controls.Add(this.lblDescargado);
            this.groupBox1.Controls.Add(this.lblProgreso);
            this.groupBox1.Controls.Add(this.lblDownSpeed);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.lblDown);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 112);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // lblDownload
            // 
            this.lblDownload.Location = new System.Drawing.Point(12, 240);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(472, 22);
            this.lblDownload.TabIndex = 17;
            this.lblDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(377, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(107, 107);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 18;
            this.picLogo.TabStop = false;
            // 
            // picYoutube
            // 
            this.picYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picYoutube.Image = ((System.Drawing.Image)(resources.GetObject("picYoutube.Image")));
            this.picYoutube.Location = new System.Drawing.Point(3, 3);
            this.picYoutube.Name = "picYoutube";
            this.picYoutube.Size = new System.Drawing.Size(39, 39);
            this.picYoutube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYoutube.TabIndex = 19;
            this.picYoutube.TabStop = false;
            // 
            // picX
            // 
            this.picX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picX.Image = ((System.Drawing.Image)(resources.GetObject("picX.Image")));
            this.picX.Location = new System.Drawing.Point(3, 3);
            this.picX.Name = "picX";
            this.picX.Size = new System.Drawing.Size(39, 39);
            this.picX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picX.TabIndex = 20;
            this.picX.TabStop = false;
            // 
            // grbDevInfo
            // 
            this.grbDevInfo.Controls.Add(this.flowLayoutPanel1);
            this.grbDevInfo.Location = new System.Drawing.Point(12, 265);
            this.grbDevInfo.Name = "grbDevInfo";
            this.grbDevInfo.Padding = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.grbDevInfo.Size = new System.Drawing.Size(472, 278);
            this.grbDevInfo.TabIndex = 21;
            this.grbDevInfo.TabStop = false;
            this.grbDevInfo.Text = "dev";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelYoutube);
            this.flowLayoutPanel1.Controls.Add(this.panelx);
            this.flowLayoutPanel1.Controls.Add(this.panelLink);
            this.flowLayoutPanel1.Controls.Add(this.panelDiscord);
            this.flowLayoutPanel1.Controls.Add(this.panelPatreon);
            this.flowLayoutPanel1.Controls.Add(this.panelInstagram);
            this.flowLayoutPanel1.Controls.Add(this.panelTikTok);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(466, 255);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // panelYoutube
            // 
            this.panelYoutube.Controls.Add(this.picYoutube);
            this.panelYoutube.Controls.Add(this.linkYoutube);
            this.panelYoutube.Location = new System.Drawing.Point(3, 3);
            this.panelYoutube.Name = "panelYoutube";
            this.panelYoutube.Size = new System.Drawing.Size(200, 44);
            this.panelYoutube.TabIndex = 30;
            // 
            // linkYoutube
            // 
            this.linkYoutube.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.linkYoutube.AutoSize = true;
            this.linkYoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkYoutube.Location = new System.Drawing.Point(48, 13);
            this.linkYoutube.Name = "linkYoutube";
            this.linkYoutube.Size = new System.Drawing.Size(74, 20);
            this.linkYoutube.TabIndex = 24;
            this.linkYoutube.TabStop = true;
            this.linkYoutube.Text = "YouTube";
            this.linkYoutube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkYoutube_LinkClicked);
            // 
            // panelx
            // 
            this.panelx.Controls.Add(this.picX);
            this.panelx.Controls.Add(this.linkTwitter);
            this.panelx.Location = new System.Drawing.Point(3, 53);
            this.panelx.Name = "panelx";
            this.panelx.Size = new System.Drawing.Size(200, 44);
            this.panelx.TabIndex = 31;
            // 
            // linkTwitter
            // 
            this.linkTwitter.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.linkTwitter.AutoSize = true;
            this.linkTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkTwitter.Location = new System.Drawing.Point(48, 13);
            this.linkTwitter.Name = "linkTwitter";
            this.linkTwitter.Size = new System.Drawing.Size(71, 20);
            this.linkTwitter.TabIndex = 25;
            this.linkTwitter.TabStop = true;
            this.linkTwitter.Text = "Twitter/X";
            this.linkTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTwitter_LinkClicked);
            // 
            // panelLink
            // 
            this.panelLink.Controls.Add(this.picLinkTree);
            this.panelLink.Controls.Add(this.linkTree);
            this.panelLink.Location = new System.Drawing.Point(3, 103);
            this.panelLink.Name = "panelLink";
            this.panelLink.Size = new System.Drawing.Size(200, 44);
            this.panelLink.TabIndex = 32;
            // 
            // picLinkTree
            // 
            this.picLinkTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLinkTree.Image = ((System.Drawing.Image)(resources.GetObject("picLinkTree.Image")));
            this.picLinkTree.Location = new System.Drawing.Point(3, 3);
            this.picLinkTree.Name = "picLinkTree";
            this.picLinkTree.Size = new System.Drawing.Size(39, 39);
            this.picLinkTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLinkTree.TabIndex = 21;
            this.picLinkTree.TabStop = false;
            // 
            // linkTree
            // 
            this.linkTree.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.linkTree.AutoSize = true;
            this.linkTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkTree.Location = new System.Drawing.Point(48, 13);
            this.linkTree.Name = "linkTree";
            this.linkTree.Size = new System.Drawing.Size(66, 20);
            this.linkTree.TabIndex = 26;
            this.linkTree.TabStop = true;
            this.linkTree.Text = "Linktree";
            this.linkTree.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTree_LinkClicked);
            // 
            // panelDiscord
            // 
            this.panelDiscord.Controls.Add(this.picDiscord);
            this.panelDiscord.Controls.Add(this.linkDiscord);
            this.panelDiscord.Location = new System.Drawing.Point(3, 153);
            this.panelDiscord.Name = "panelDiscord";
            this.panelDiscord.Size = new System.Drawing.Size(200, 44);
            this.panelDiscord.TabIndex = 33;
            // 
            // picDiscord
            // 
            this.picDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDiscord.Image = ((System.Drawing.Image)(resources.GetObject("picDiscord.Image")));
            this.picDiscord.Location = new System.Drawing.Point(3, 3);
            this.picDiscord.Name = "picDiscord";
            this.picDiscord.Size = new System.Drawing.Size(39, 39);
            this.picDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDiscord.TabIndex = 22;
            this.picDiscord.TabStop = false;
            // 
            // linkDiscord
            // 
            this.linkDiscord.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.linkDiscord.AutoSize = true;
            this.linkDiscord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkDiscord.Location = new System.Drawing.Point(48, 12);
            this.linkDiscord.Name = "linkDiscord";
            this.linkDiscord.Size = new System.Drawing.Size(63, 20);
            this.linkDiscord.TabIndex = 27;
            this.linkDiscord.TabStop = true;
            this.linkDiscord.Text = "Discord";
            this.linkDiscord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDiscord_LinkClicked);
            // 
            // panelPatreon
            // 
            this.panelPatreon.Controls.Add(this.picPatreon);
            this.panelPatreon.Controls.Add(this.linkPatreon);
            this.panelPatreon.Location = new System.Drawing.Point(3, 203);
            this.panelPatreon.Name = "panelPatreon";
            this.panelPatreon.Size = new System.Drawing.Size(200, 44);
            this.panelPatreon.TabIndex = 34;
            // 
            // picPatreon
            // 
            this.picPatreon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPatreon.Image = ((System.Drawing.Image)(resources.GetObject("picPatreon.Image")));
            this.picPatreon.Location = new System.Drawing.Point(3, 3);
            this.picPatreon.Name = "picPatreon";
            this.picPatreon.Size = new System.Drawing.Size(39, 39);
            this.picPatreon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPatreon.TabIndex = 23;
            this.picPatreon.TabStop = false;
            // 
            // linkPatreon
            // 
            this.linkPatreon.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.linkPatreon.AutoSize = true;
            this.linkPatreon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkPatreon.Location = new System.Drawing.Point(48, 11);
            this.linkPatreon.Name = "linkPatreon";
            this.linkPatreon.Size = new System.Drawing.Size(65, 20);
            this.linkPatreon.TabIndex = 28;
            this.linkPatreon.TabStop = true;
            this.linkPatreon.Text = "Patreon";
            this.linkPatreon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPatreon_LinkClicked);
            // 
            // panelInstagram
            // 
            this.panelInstagram.Controls.Add(this.picInstagram);
            this.panelInstagram.Controls.Add(this.linkInstagram);
            this.panelInstagram.Location = new System.Drawing.Point(209, 3);
            this.panelInstagram.Name = "panelInstagram";
            this.panelInstagram.Size = new System.Drawing.Size(200, 44);
            this.panelInstagram.TabIndex = 34;
            // 
            // picInstagram
            // 
            this.picInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picInstagram.Image = ((System.Drawing.Image)(resources.GetObject("picInstagram.Image")));
            this.picInstagram.Location = new System.Drawing.Point(3, 3);
            this.picInstagram.Name = "picInstagram";
            this.picInstagram.Size = new System.Drawing.Size(39, 39);
            this.picInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInstagram.TabIndex = 22;
            this.picInstagram.TabStop = false;
            // 
            // linkInstagram
            // 
            this.linkInstagram.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.linkInstagram.AutoSize = true;
            this.linkInstagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkInstagram.Location = new System.Drawing.Point(48, 12);
            this.linkInstagram.Name = "linkInstagram";
            this.linkInstagram.Size = new System.Drawing.Size(81, 20);
            this.linkInstagram.TabIndex = 27;
            this.linkInstagram.TabStop = true;
            this.linkInstagram.Text = "Instagram";
            this.linkInstagram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInstagram_LinkClicked);
            // 
            // panelTikTok
            // 
            this.panelTikTok.Controls.Add(this.picTikTok);
            this.panelTikTok.Controls.Add(this.linkTikTok);
            this.panelTikTok.Location = new System.Drawing.Point(209, 53);
            this.panelTikTok.Name = "panelTikTok";
            this.panelTikTok.Size = new System.Drawing.Size(200, 44);
            this.panelTikTok.TabIndex = 35;
            // 
            // picTikTok
            // 
            this.picTikTok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTikTok.Image = ((System.Drawing.Image)(resources.GetObject("picTikTok.Image")));
            this.picTikTok.Location = new System.Drawing.Point(3, 3);
            this.picTikTok.Name = "picTikTok";
            this.picTikTok.Size = new System.Drawing.Size(39, 39);
            this.picTikTok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTikTok.TabIndex = 22;
            this.picTikTok.TabStop = false;
            // 
            // linkTikTok
            // 
            this.linkTikTok.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.linkTikTok.AutoSize = true;
            this.linkTikTok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkTikTok.Location = new System.Drawing.Point(48, 12);
            this.linkTikTok.Name = "linkTikTok";
            this.linkTikTok.Size = new System.Drawing.Size(55, 20);
            this.linkTikTok.TabIndex = 27;
            this.linkTikTok.TabStop = true;
            this.linkTikTok.Text = "TikTok";
            this.linkTikTok.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTikTok_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picWeb);
            this.panel1.Controls.Add(this.linkWebSite);
            this.panel1.Location = new System.Drawing.Point(209, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 44);
            this.panel1.TabIndex = 36;
            // 
            // picWeb
            // 
            this.picWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWeb.Image = ((System.Drawing.Image)(resources.GetObject("picWeb.Image")));
            this.picWeb.Location = new System.Drawing.Point(3, 3);
            this.picWeb.Name = "picWeb";
            this.picWeb.Size = new System.Drawing.Size(39, 39);
            this.picWeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeb.TabIndex = 22;
            this.picWeb.TabStop = false;
            // 
            // linkWebSite
            // 
            this.linkWebSite.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.linkWebSite.AutoSize = true;
            this.linkWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkWebSite.Location = new System.Drawing.Point(48, 12);
            this.linkWebSite.Name = "linkWebSite";
            this.linkWebSite.Size = new System.Drawing.Size(42, 20);
            this.linkWebSite.TabIndex = 27;
            this.linkWebSite.TabStop = true;
            this.linkWebSite.Text = "Web";
            this.linkWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebSite_LinkClicked);
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 584);
            this.Controls.Add(this.grbDevInfo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.lblwinver);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DownloadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download :  Windows Media Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).EndInit();
            this.grbDevInfo.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelYoutube.ResumeLayout(false);
            this.panelYoutube.PerformLayout();
            this.panelx.ResumeLayout(false);
            this.panelx.PerformLayout();
            this.panelLink.ResumeLayout(false);
            this.panelLink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkTree)).EndInit();
            this.panelDiscord.ResumeLayout(false);
            this.panelDiscord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDiscord)).EndInit();
            this.panelPatreon.ResumeLayout(false);
            this.panelPatreon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPatreon)).EndInit();
            this.panelInstagram.ResumeLayout(false);
            this.panelInstagram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInstagram)).EndInit();
            this.panelTikTok.ResumeLayout(false);
            this.panelTikTok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTikTok)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWeb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblDownSpeed;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.Label lblDescargado;
        private System.Windows.Forms.Button btnPause;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblVersion;
        public System.Windows.Forms.Label lblDev;
        public System.Windows.Forms.Label lblSize;
        public System.Windows.Forms.Label lblwinver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDownload;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picYoutube;
        private System.Windows.Forms.PictureBox picX;
        private System.Windows.Forms.GroupBox grbDevInfo;
        private System.Windows.Forms.PictureBox picDiscord;
        private System.Windows.Forms.PictureBox picLinkTree;
        private System.Windows.Forms.PictureBox picPatreon;
        private System.Windows.Forms.LinkLabel linkPatreon;
        private System.Windows.Forms.LinkLabel linkDiscord;
        private System.Windows.Forms.LinkLabel linkTree;
        private System.Windows.Forms.LinkLabel linkTwitter;
        private System.Windows.Forms.LinkLabel linkYoutube;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelYoutube;
        private System.Windows.Forms.Panel panelx;
        private System.Windows.Forms.Panel panelLink;
        private System.Windows.Forms.Panel panelDiscord;
        private System.Windows.Forms.Panel panelPatreon;
        private System.Windows.Forms.Panel panelInstagram;
        private System.Windows.Forms.PictureBox picInstagram;
        private System.Windows.Forms.LinkLabel linkInstagram;
        private System.Windows.Forms.Panel panelTikTok;
        private System.Windows.Forms.PictureBox picTikTok;
        private System.Windows.Forms.LinkLabel linkTikTok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picWeb;
        private System.Windows.Forms.LinkLabel linkWebSite;
    }
}