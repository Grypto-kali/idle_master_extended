﻿namespace IdleMaster
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblCookieStatus = new System.Windows.Forms.Label();
            this.tmrCheckCookieData = new System.Windows.Forms.Timer(this.components);
            this.lblSteamStatus = new System.Windows.Forms.Label();
            this.tmrCheckSteam = new System.Windows.Forms.Timer(this.components);
            this.lnkResetCookies = new System.Windows.Forms.LinkLabel();
            this.lnkSignIn = new System.Windows.Forms.LinkLabel();
            this.lblDrops = new System.Windows.Forms.Label();
            this.lblIdle = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblCurrentRemaining = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.LinkLabel();
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseIdlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeIdlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrReadyToGo = new System.Windows.Forms.Timer(this.components);
            this.tmrCardDropCheck = new System.Windows.Forms.Timer(this.components);
            this.ssFooter = new System.Windows.Forms.StatusStrip();
            this.pbIdle = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.picReadingPage = new System.Windows.Forms.PictureBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.picIdleStatus = new System.Windows.Forms.PictureBox();
            this.picCookieStatus = new System.Windows.Forms.PictureBox();
            this.picSteamStatus = new System.Windows.Forms.PictureBox();
            this.picApp = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.mnuTop.SuspendLayout();
            this.ssFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReadingPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdleStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCookieStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSteamStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCookieStatus
            // 
            this.lblCookieStatus.AutoSize = true;
            this.lblCookieStatus.Location = new System.Drawing.Point(31, 58);
            this.lblCookieStatus.Name = "lblCookieStatus";
            this.lblCookieStatus.Size = new System.Drawing.Size(186, 13);
            this.lblCookieStatus.TabIndex = 0;
            this.lblCookieStatus.Text = "Idle Master is not connected to Steam";
            // 
            // tmrCheckCookieData
            // 
            this.tmrCheckCookieData.Enabled = true;
            this.tmrCheckCookieData.Tick += new System.EventHandler(this.tmrCheckCookieData_Tick);
            // 
            // lblSteamStatus
            // 
            this.lblSteamStatus.AutoSize = true;
            this.lblSteamStatus.Location = new System.Drawing.Point(30, 36);
            this.lblSteamStatus.Name = "lblSteamStatus";
            this.lblSteamStatus.Size = new System.Drawing.Size(103, 13);
            this.lblSteamStatus.TabIndex = 3;
            this.lblSteamStatus.Text = "Steam is not running";
            // 
            // tmrCheckSteam
            // 
            this.tmrCheckSteam.Enabled = true;
            this.tmrCheckSteam.Interval = 500;
            this.tmrCheckSteam.Tick += new System.EventHandler(this.tmrCheckSteam_Tick);
            // 
            // lnkResetCookies
            // 
            this.lnkResetCookies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkResetCookies.AutoSize = true;
            this.lnkResetCookies.Location = new System.Drawing.Point(194, 58);
            this.lnkResetCookies.Name = "lnkResetCookies";
            this.lnkResetCookies.Size = new System.Drawing.Size(52, 13);
            this.lnkResetCookies.TabIndex = 4;
            this.lnkResetCookies.TabStop = true;
            this.lnkResetCookies.Text = "(Sign out)";
            this.lnkResetCookies.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkResetCookies_LinkClicked);
            // 
            // lnkSignIn
            // 
            this.lnkSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSignIn.AutoSize = true;
            this.lnkSignIn.Location = new System.Drawing.Point(204, 58);
            this.lnkSignIn.Name = "lnkSignIn";
            this.lnkSignIn.Size = new System.Drawing.Size(45, 13);
            this.lnkSignIn.TabIndex = 5;
            this.lnkSignIn.TabStop = true;
            this.lnkSignIn.Text = "(Sign in)";
            this.lnkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignIn_LinkClicked);
            // 
            // lblDrops
            // 
            this.lblDrops.AutoSize = true;
            this.lblDrops.Location = new System.Drawing.Point(31, 85);
            this.lblDrops.Name = "lblDrops";
            this.lblDrops.Size = new System.Drawing.Size(105, 13);
            this.lblDrops.TabIndex = 9;
            this.lblDrops.Text = "card drops remaining";
            this.lblDrops.Visible = false;
            // 
            // lblIdle
            // 
            this.lblIdle.AutoSize = true;
            this.lblIdle.Location = new System.Drawing.Point(31, 101);
            this.lblIdle.Name = "lblIdle";
            this.lblIdle.Size = new System.Drawing.Size(86, 13);
            this.lblIdle.TabIndex = 10;
            this.lblIdle.Text = "games left to idle";
            this.lblIdle.Visible = false;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Location = new System.Drawing.Point(15, 135);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(88, 13);
            this.lblCurrentStatus.TabIndex = 11;
            this.lblCurrentStatus.Text = "Currently in-game";
            // 
            // lblCurrentRemaining
            // 
            this.lblCurrentRemaining.Location = new System.Drawing.Point(154, 292);
            this.lblCurrentRemaining.Name = "lblCurrentRemaining";
            this.lblCurrentRemaining.Size = new System.Drawing.Size(138, 19);
            this.lblCurrentRemaining.TabIndex = 12;
            this.lblCurrentRemaining.Text = "3 card drops remaining";
            this.lblCurrentRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGameName
            // 
            this.lblGameName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGameName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblGameName.Location = new System.Drawing.Point(96, 135);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(159, 16);
            this.lblGameName.TabIndex = 16;
            this.lblGameName.TabStop = true;
            this.lblGameName.Text = "Game Name";
            this.lblGameName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGameName_LinkClicked);
            // 
            // mnuTop
            // 
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuTop.Location = new System.Drawing.Point(0, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuTop.Size = new System.Drawing.Size(304, 24);
            this.mnuTop.TabIndex = 19;
            this.mnuTop.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.blacklistToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::IdleMaster.Properties.Resources.imgSettings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // blacklistToolStripMenuItem
            // 
            this.blacklistToolStripMenuItem.Image = global::IdleMaster.Properties.Resources.imgBlacklist;
            this.blacklistToolStripMenuItem.Name = "blacklistToolStripMenuItem";
            this.blacklistToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.blacklistToolStripMenuItem.Text = "&Blacklist";
            this.blacklistToolStripMenuItem.Click += new System.EventHandler(this.blacklistToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::IdleMaster.Properties.Resources.imgExit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseIdlingToolStripMenuItem,
            this.resumeIdlingToolStripMenuItem,
            this.skipGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // pauseIdlingToolStripMenuItem
            // 
            this.pauseIdlingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pauseIdlingToolStripMenuItem.Image")));
            this.pauseIdlingToolStripMenuItem.Name = "pauseIdlingToolStripMenuItem";
            this.pauseIdlingToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pauseIdlingToolStripMenuItem.Text = "&Pause Idling";
            this.pauseIdlingToolStripMenuItem.Click += new System.EventHandler(this.pauseIdlingToolStripMenuItem_Click);
            // 
            // resumeIdlingToolStripMenuItem
            // 
            this.resumeIdlingToolStripMenuItem.Enabled = false;
            this.resumeIdlingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resumeIdlingToolStripMenuItem.Image")));
            this.resumeIdlingToolStripMenuItem.Name = "resumeIdlingToolStripMenuItem";
            this.resumeIdlingToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.resumeIdlingToolStripMenuItem.Text = "Resume Idling";
            this.resumeIdlingToolStripMenuItem.Click += new System.EventHandler(this.resumeIdlingToolStripMenuItem_Click);
            // 
            // skipGameToolStripMenuItem
            // 
            this.skipGameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("skipGameToolStripMenuItem.Image")));
            this.skipGameToolStripMenuItem.Name = "skipGameToolStripMenuItem";
            this.skipGameToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.skipGameToolStripMenuItem.Text = "&Skip Game";
            this.skipGameToolStripMenuItem.Click += new System.EventHandler(this.skipGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::IdleMaster.Properties.Resources.imgInfo;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tmrReadyToGo
            // 
            this.tmrReadyToGo.Enabled = true;
            this.tmrReadyToGo.Tick += new System.EventHandler(this.tmrReadyToGo_Tick);
            // 
            // tmrCardDropCheck
            // 
            this.tmrCardDropCheck.Interval = 1000;
            this.tmrCardDropCheck.Tick += new System.EventHandler(this.tmrCardDropCheck_Tick);
            // 
            // ssFooter
            // 
            this.ssFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbIdle,
            this.toolStripStatusLabel1,
            this.lblTimer});
            this.ssFooter.Location = new System.Drawing.Point(0, 316);
            this.ssFooter.Name = "ssFooter";
            this.ssFooter.Size = new System.Drawing.Size(304, 21);
            this.ssFooter.SizingGrip = false;
            this.ssFooter.TabIndex = 20;
            this.ssFooter.Text = "statusStrip1";
            this.ssFooter.Visible = false;
            // 
            // pbIdle
            // 
            this.pbIdle.Name = "pbIdle";
            this.pbIdle.Size = new System.Drawing.Size(188, 15);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 16);
            this.toolStripStatusLabel1.Text = "Next check";
            // 
            // lblTimer
            // 
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(34, 16);
            this.lblTimer.Text = "15:00";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Idle Master";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // picReadingPage
            // 
            this.picReadingPage.Image = global::IdleMaster.Properties.Resources.imgSpin;
            this.picReadingPage.Location = new System.Drawing.Point(15, 83);
            this.picReadingPage.Name = "picReadingPage";
            this.picReadingPage.Size = new System.Drawing.Size(15, 16);
            this.picReadingPage.TabIndex = 26;
            this.picReadingPage.TabStop = false;
            this.picReadingPage.Visible = false;
            // 
            // btnSkip
            // 
            this.btnSkip.Image = global::IdleMaster.Properties.Resources.imgSkipSmall;
            this.btnSkip.Location = new System.Drawing.Point(274, 135);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(15, 16);
            this.btnSkip.TabIndex = 23;
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // picIdleStatus
            // 
            this.picIdleStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picIdleStatus.Location = new System.Drawing.Point(286, 319);
            this.picIdleStatus.Name = "picIdleStatus";
            this.picIdleStatus.Size = new System.Drawing.Size(15, 16);
            this.picIdleStatus.TabIndex = 15;
            this.picIdleStatus.TabStop = false;
            // 
            // picCookieStatus
            // 
            this.picCookieStatus.Location = new System.Drawing.Point(15, 57);
            this.picCookieStatus.Name = "picCookieStatus";
            this.picCookieStatus.Size = new System.Drawing.Size(15, 16);
            this.picCookieStatus.TabIndex = 8;
            this.picCookieStatus.TabStop = false;
            // 
            // picSteamStatus
            // 
            this.picSteamStatus.Location = new System.Drawing.Point(15, 34);
            this.picSteamStatus.Name = "picSteamStatus";
            this.picSteamStatus.Size = new System.Drawing.Size(15, 16);
            this.picSteamStatus.TabIndex = 7;
            this.picSteamStatus.TabStop = false;
            // 
            // picApp
            // 
            this.picApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picApp.Location = new System.Drawing.Point(15, 154);
            this.picApp.Name = "picApp";
            this.picApp.Size = new System.Drawing.Size(274, 138);
            this.picApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picApp.TabIndex = 6;
            this.picApp.TabStop = false;
            // 
            // btnPause
            // 
            this.btnPause.Image = global::IdleMaster.Properties.Resources.imgPauseSmall;
            this.btnPause.Location = new System.Drawing.Point(259, 135);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(15, 16);
            this.btnPause.TabIndex = 22;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Image = global::IdleMaster.Properties.Resources.imgPlaySmall;
            this.btnResume.Location = new System.Drawing.Point(259, 135);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(15, 16);
            this.btnResume.TabIndex = 24;
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Visible = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(304, 339);
            this.Controls.Add(this.picReadingPage);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.picIdleStatus);
            this.Controls.Add(this.lblCurrentRemaining);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.lblIdle);
            this.Controls.Add(this.lblDrops);
            this.Controls.Add(this.picCookieStatus);
            this.Controls.Add(this.picSteamStatus);
            this.Controls.Add(this.picApp);
            this.Controls.Add(this.lnkSignIn);
            this.Controls.Add(this.lnkResetCookies);
            this.Controls.Add(this.lblSteamStatus);
            this.Controls.Add(this.lblCookieStatus);
            this.Controls.Add(this.mnuTop);
            this.Controls.Add(this.ssFooter);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.lblGameName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuTop;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Idle Master";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClose);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.ssFooter.ResumeLayout(false);
            this.ssFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReadingPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdleStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCookieStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSteamStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCookieStatus;
        private System.Windows.Forms.Timer tmrCheckCookieData;
        private System.Windows.Forms.Label lblSteamStatus;
        private System.Windows.Forms.Timer tmrCheckSteam;
        private System.Windows.Forms.LinkLabel lnkResetCookies;
        private System.Windows.Forms.LinkLabel lnkSignIn;
        private System.Windows.Forms.PictureBox picApp;
        private System.Windows.Forms.PictureBox picSteamStatus;
        private System.Windows.Forms.PictureBox picCookieStatus;
        private System.Windows.Forms.Label lblDrops;
        private System.Windows.Forms.Label lblIdle;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblCurrentRemaining;
        private System.Windows.Forms.PictureBox picIdleStatus;
        private System.Windows.Forms.LinkLabel lblGameName;
        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer tmrReadyToGo;
        private System.Windows.Forms.Timer tmrCardDropCheck;
        private System.Windows.Forms.StatusStrip ssFooter;
        private System.Windows.Forms.ToolStripProgressBar pbIdle;
        private System.Windows.Forms.ToolStripStatusLabel lblTimer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseIdlingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeIdlingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skipGameToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox picReadingPage;
        private System.Windows.Forms.ToolStripMenuItem blacklistToolStripMenuItem;

    }
}

