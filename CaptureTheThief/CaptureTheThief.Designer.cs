﻿
namespace CaptureTheThief
{
    partial class CaptureTheThief
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureTheThief));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.levelsTimer = new System.Windows.Forms.Timer(this.components);
            this.policeTimer = new System.Windows.Forms.Timer(this.components);
            this.ThiefTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gameOverPanel = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.levelResultBarLbl = new System.Windows.Forms.Label();
            this.policeBarPanel = new System.Windows.Forms.Panel();
            this.policeScoreBarResultLbl = new System.Windows.Forms.Label();
            this.policeScoreBarLbl = new System.Windows.Forms.Label();
            this.policeNameBarResultLbl = new System.Windows.Forms.Label();
            this.policeNameBarLbl = new System.Windows.Forms.Label();
            this.thiefBarPanel = new System.Windows.Forms.Panel();
            this.thiefScoreResultBarLbl = new System.Windows.Forms.Label();
            this.thiefScoreBarLbl = new System.Windows.Forms.Label();
            this.thiefNameResultBarLbl = new System.Windows.Forms.Label();
            this.thiefNameBarLbl = new System.Windows.Forms.Label();
            this.timeLeftResultBarLbl = new System.Windows.Forms.Label();
            this.invisiblePbx = new System.Windows.Forms.PictureBox();
            this.freezePbx = new System.Windows.Forms.PictureBox();
            this.flashPbx = new System.Windows.Forms.PictureBox();
            this.snailPbx = new System.Windows.Forms.PictureBox();
            this.thiefPbx = new System.Windows.Forms.PictureBox();
            this.policePbx = new System.Windows.Forms.PictureBox();
            this.gameMapPbx = new System.Windows.Forms.PictureBox();
            this.police1Pbx = new System.Windows.Forms.PictureBox();
            this.police1BarPanel = new System.Windows.Forms.Panel();
            this.police1ScoreBarResultLbl = new System.Windows.Forms.Label();
            this.police1ScoreBarLbl = new System.Windows.Forms.Label();
            this.police1NameBarResultLbl = new System.Windows.Forms.Label();
            this.police1NameBarLbl = new System.Windows.Forms.Label();
            this.police1Timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.policeBarPanel.SuspendLayout();
            this.thiefBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invisiblePbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freezePbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snailPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thiefPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policePbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameMapPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police1Pbx)).BeginInit();
            this.police1BarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(815, 31);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.endToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Enabled = false;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.endToolStripMenuItem.Text = "End";
            this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.currentToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Enabled = false;
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(172, 34);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.Enabled = false;
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.currentToolStripMenuItem.Text = "Current";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Enabled = false;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Enabled = false;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(558, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 283);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(85, 377);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 58);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(417, 306);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(65, 129);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(266, 231);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 80);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(691, 128);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(65, 25);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(281, 128);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(187, 43);
            this.panel6.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(690, 409);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(55, 27);
            this.panel7.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Location = new System.Drawing.Point(690, 214);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(55, 126);
            this.panel8.TabIndex = 24;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(80, 135);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(98, 176);
            this.panel9.TabIndex = 25;
            // 
            // levelsTimer
            // 
            this.levelsTimer.Interval = 3500;
            this.levelsTimer.Tick += new System.EventHandler(this.mainGameTimer_Tick);
            // 
            // policeTimer
            // 
            this.policeTimer.Enabled = true;
            this.policeTimer.Interval = 20;
            this.policeTimer.Tick += new System.EventHandler(this.policeMoveTimerEvent);
            // 
            // ThiefTimer
            // 
            this.ThiefTimer.Enabled = true;
            this.ThiefTimer.Interval = 20;
            this.ThiefTimer.Tick += new System.EventHandler(this.thiefMoveTimerEvent);
            // 
            // timeLeftTimer
            // 
            this.timeLeftTimer.Interval = 1000;
            this.timeLeftTimer.Tick += new System.EventHandler(this.timeLeftTimer_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "IMG_2811.PNG");
            this.imageList1.Images.SetKeyName(1, "IMG_2818.PNG");
            this.imageList1.Images.SetKeyName(2, "NightMap.png");
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameOverPanel.ForeColor = System.Drawing.Color.Transparent;
            this.gameOverPanel.Location = new System.Drawing.Point(60, 116);
            this.gameOverPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(706, 339);
            this.gameOverPanel.TabIndex = 35;
            this.gameOverPanel.Visible = false;
            this.gameOverPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gameOverPanel_Paint);
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::CaptureTheThief.Properties.Resources.UpFINAL;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Controls.Add(this.police1BarPanel);
            this.panel10.Controls.Add(this.levelResultBarLbl);
            this.panel10.Controls.Add(this.policeBarPanel);
            this.panel10.Controls.Add(this.thiefBarPanel);
            this.panel10.Controls.Add(this.timeLeftResultBarLbl);
            this.panel10.Location = new System.Drawing.Point(0, 23);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(815, 53);
            this.panel10.TabIndex = 8;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint_1);
            // 
            // levelResultBarLbl
            // 
            this.levelResultBarLbl.AutoSize = true;
            this.levelResultBarLbl.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelResultBarLbl.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.levelResultBarLbl.Location = new System.Drawing.Point(526, 27);
            this.levelResultBarLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.levelResultBarLbl.Name = "levelResultBarLbl";
            this.levelResultBarLbl.Size = new System.Drawing.Size(22, 24);
            this.levelResultBarLbl.TabIndex = 3;
            this.levelResultBarLbl.Text = "1";
            this.levelResultBarLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // policeBarPanel
            // 
            this.policeBarPanel.Controls.Add(this.policeScoreBarResultLbl);
            this.policeBarPanel.Controls.Add(this.policeScoreBarLbl);
            this.policeBarPanel.Controls.Add(this.policeNameBarResultLbl);
            this.policeBarPanel.Controls.Add(this.policeNameBarLbl);
            this.policeBarPanel.Location = new System.Drawing.Point(53, 2);
            this.policeBarPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.policeBarPanel.Name = "policeBarPanel";
            this.policeBarPanel.Size = new System.Drawing.Size(160, 51);
            this.policeBarPanel.TabIndex = 28;
            // 
            // policeScoreBarResultLbl
            // 
            this.policeScoreBarResultLbl.AutoSize = true;
            this.policeScoreBarResultLbl.BackColor = System.Drawing.Color.Transparent;
            this.policeScoreBarResultLbl.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policeScoreBarResultLbl.ForeColor = System.Drawing.Color.White;
            this.policeScoreBarResultLbl.Location = new System.Drawing.Point(86, 32);
            this.policeScoreBarResultLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.policeScoreBarResultLbl.Name = "policeScoreBarResultLbl";
            this.policeScoreBarResultLbl.Size = new System.Drawing.Size(22, 24);
            this.policeScoreBarResultLbl.TabIndex = 3;
            this.policeScoreBarResultLbl.Text = "0";
            // 
            // policeScoreBarLbl
            // 
            this.policeScoreBarLbl.AutoSize = true;
            this.policeScoreBarLbl.BackColor = System.Drawing.Color.Transparent;
            this.policeScoreBarLbl.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policeScoreBarLbl.ForeColor = System.Drawing.Color.White;
            this.policeScoreBarLbl.Location = new System.Drawing.Point(7, 32);
            this.policeScoreBarLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.policeScoreBarLbl.Name = "policeScoreBarLbl";
            this.policeScoreBarLbl.Size = new System.Drawing.Size(90, 24);
            this.policeScoreBarLbl.TabIndex = 2;
            this.policeScoreBarLbl.Text = "Score: ";
            // 
            // policeNameBarResultLbl
            // 
            this.policeNameBarResultLbl.AutoSize = true;
            this.policeNameBarResultLbl.BackColor = System.Drawing.Color.Transparent;
            this.policeNameBarResultLbl.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policeNameBarResultLbl.ForeColor = System.Drawing.Color.White;
            this.policeNameBarResultLbl.Location = new System.Drawing.Point(86, 10);
            this.policeNameBarResultLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.policeNameBarResultLbl.Name = "policeNameBarResultLbl";
            this.policeNameBarResultLbl.Size = new System.Drawing.Size(22, 24);
            this.policeNameBarResultLbl.TabIndex = 1;
            this.policeNameBarResultLbl.Text = "0";
            this.policeNameBarResultLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // policeNameBarLbl
            // 
            this.policeNameBarLbl.AutoSize = true;
            this.policeNameBarLbl.BackColor = System.Drawing.Color.Transparent;
            this.policeNameBarLbl.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policeNameBarLbl.ForeColor = System.Drawing.Color.White;
            this.policeNameBarLbl.Location = new System.Drawing.Point(7, 10);
            this.policeNameBarLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.policeNameBarLbl.Name = "policeNameBarLbl";
            this.policeNameBarLbl.Size = new System.Drawing.Size(110, 24);
            this.policeNameBarLbl.TabIndex = 0;
            this.policeNameBarLbl.Text = "Police1: ";
            this.policeNameBarLbl.Click += new System.EventHandler(this.policeNameBarLbl_Click);
            // 
            // thiefBarPanel
            // 
            this.thiefBarPanel.Controls.Add(this.thiefScoreResultBarLbl);
            this.thiefBarPanel.Controls.Add(this.thiefScoreBarLbl);
            this.thiefBarPanel.Controls.Add(this.thiefNameResultBarLbl);
            this.thiefBarPanel.Controls.Add(this.thiefNameBarLbl);
            this.thiefBarPanel.Location = new System.Drawing.Point(593, 2);
            this.thiefBarPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thiefBarPanel.Name = "thiefBarPanel";
            this.thiefBarPanel.Size = new System.Drawing.Size(160, 51);
            this.thiefBarPanel.TabIndex = 0;
            this.thiefBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.thiefBarPanel_Paint);
            // 
            // thiefScoreResultBarLbl
            // 
            this.thiefScoreResultBarLbl.AutoSize = true;
            this.thiefScoreResultBarLbl.BackColor = System.Drawing.Color.Transparent;
            this.thiefScoreResultBarLbl.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thiefScoreResultBarLbl.ForeColor = System.Drawing.Color.White;
            this.thiefScoreResultBarLbl.Location = new System.Drawing.Point(94, 32);
            this.thiefScoreResultBarLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thiefScoreResultBarLbl.Name = "thiefScoreResultBarLbl";
            this.thiefScoreResultBarLbl.Size = new System.Drawing.Size(22, 24);
            this.thiefScoreResultBarLbl.TabIndex = 7;
            this.thiefScoreResultBarLbl.Text = "0";
            // 
            // thiefScoreBarLbl
            // 
            this.thiefScoreBarLbl.AutoSize = true;
            this.thiefScoreBarLbl.BackColor = System.Drawing.Color.Transparent;
            this.thiefScoreBarLbl.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thiefScoreBarLbl.ForeColor = System.Drawing.Color.White;
            this.thiefScoreBarLbl.Location = new System.Drawing.Point(15, 32);
            this.thiefScoreBarLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thiefScoreBarLbl.Name = "thiefScoreBarLbl";
            this.thiefScoreBarLbl.Size = new System.Drawing.Size(90, 24);
            this.thiefScoreBarLbl.TabIndex = 6;
            this.thiefScoreBarLbl.Text = "Score: ";
            // 
            // thiefNameResultBarLbl
            // 
            this.thiefNameResultBarLbl.AutoSize = true;
            this.thiefNameResultBarLbl.BackColor = System.Drawing.Color.Transparent;
            this.thiefNameResultBarLbl.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thiefNameResultBarLbl.ForeColor = System.Drawing.Color.White;
            this.thiefNameResultBarLbl.Location = new System.Drawing.Point(94, 10);
            this.thiefNameResultBarLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thiefNameResultBarLbl.Name = "thiefNameResultBarLbl";
            this.thiefNameResultBarLbl.Size = new System.Drawing.Size(22, 24);
            this.thiefNameResultBarLbl.TabIndex = 5;
            this.thiefNameResultBarLbl.Text = "0";
            // 
            // thiefNameBarLbl
            // 
            this.thiefNameBarLbl.AutoSize = true;
            this.thiefNameBarLbl.BackColor = System.Drawing.Color.Transparent;
            this.thiefNameBarLbl.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thiefNameBarLbl.ForeColor = System.Drawing.Color.White;
            this.thiefNameBarLbl.Location = new System.Drawing.Point(15, 10);
            this.thiefNameBarLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thiefNameBarLbl.Name = "thiefNameBarLbl";
            this.thiefNameBarLbl.Size = new System.Drawing.Size(86, 24);
            this.thiefNameBarLbl.TabIndex = 4;
            this.thiefNameBarLbl.Text = "Thief: ";
            // 
            // timeLeftResultBarLbl
            // 
            this.timeLeftResultBarLbl.AutoSize = true;
            this.timeLeftResultBarLbl.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftResultBarLbl.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.timeLeftResultBarLbl.Location = new System.Drawing.Point(246, 27);
            this.timeLeftResultBarLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLeftResultBarLbl.Name = "timeLeftResultBarLbl";
            this.timeLeftResultBarLbl.Size = new System.Drawing.Size(65, 24);
            this.timeLeftResultBarLbl.TabIndex = 1;
            this.timeLeftResultBarLbl.Text = "02:00";
            this.timeLeftResultBarLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invisiblePbx
            // 
            this.invisiblePbx.Image = global::CaptureTheThief.Properties.Resources.invisible_removebg_preview;
            this.invisiblePbx.Location = new System.Drawing.Point(131, 87);
            this.invisiblePbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invisiblePbx.Name = "invisiblePbx";
            this.invisiblePbx.Size = new System.Drawing.Size(41, 32);
            this.invisiblePbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invisiblePbx.TabIndex = 34;
            this.invisiblePbx.TabStop = false;
            // 
            // freezePbx
            // 
            this.freezePbx.Image = global::CaptureTheThief.Properties.Resources.freeze_removebg_preview;
            this.freezePbx.Location = new System.Drawing.Point(19, 87);
            this.freezePbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.freezePbx.Name = "freezePbx";
            this.freezePbx.Size = new System.Drawing.Size(41, 32);
            this.freezePbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.freezePbx.TabIndex = 33;
            this.freezePbx.TabStop = false;
            // 
            // flashPbx
            // 
            this.flashPbx.BackgroundImage = global::CaptureTheThief.Properties.Resources.flash_removebg_preview;
            this.flashPbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashPbx.Enabled = false;
            this.flashPbx.Location = new System.Drawing.Point(201, 87);
            this.flashPbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flashPbx.Name = "flashPbx";
            this.flashPbx.Size = new System.Drawing.Size(41, 32);
            this.flashPbx.TabIndex = 31;
            this.flashPbx.TabStop = false;
            this.flashPbx.Visible = false;
            // 
            // snailPbx
            // 
            this.snailPbx.BackgroundImage = global::CaptureTheThief.Properties.Resources.snail_removebg_preview2;
            this.snailPbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snailPbx.Enabled = false;
            this.snailPbx.Location = new System.Drawing.Point(498, 87);
            this.snailPbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.snailPbx.Name = "snailPbx";
            this.snailPbx.Size = new System.Drawing.Size(40, 32);
            this.snailPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snailPbx.TabIndex = 32;
            this.snailPbx.TabStop = false;
            this.snailPbx.Visible = false;
            // 
            // thiefPbx
            // 
            this.thiefPbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thiefPbx.Location = new System.Drawing.Point(508, 434);
            this.thiefPbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thiefPbx.Name = "thiefPbx";
            this.thiefPbx.Size = new System.Drawing.Size(30, 34);
            this.thiefPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thiefPbx.TabIndex = 26;
            this.thiefPbx.TabStop = false;
            // 
            // policePbx
            // 
            this.policePbx.BackColor = System.Drawing.Color.Black;
            this.policePbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.policePbx.Location = new System.Drawing.Point(19, 337);
            this.policePbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.policePbx.Name = "policePbx";
            this.policePbx.Size = new System.Drawing.Size(30, 34);
            this.policePbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.policePbx.TabIndex = 27;
            this.policePbx.TabStop = false;
            this.policePbx.Click += new System.EventHandler(this.policeCarPbx_Click_1);
            // 
            // gameMapPbx
            // 
            this.gameMapPbx.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gameMapPbx.Image = global::CaptureTheThief.Properties.Resources.NightMap__1_;
            this.gameMapPbx.Location = new System.Drawing.Point(8, 80);
            this.gameMapPbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameMapPbx.Name = "gameMapPbx";
            this.gameMapPbx.Size = new System.Drawing.Size(801, 402);
            this.gameMapPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameMapPbx.TabIndex = 18;
            this.gameMapPbx.TabStop = false;
            this.gameMapPbx.Click += new System.EventHandler(this.mapPbx_Click);
            // 
            // police1Pbx
            // 
            this.police1Pbx.BackColor = System.Drawing.Color.Black;
            this.police1Pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.police1Pbx.Location = new System.Drawing.Point(770, 137);
            this.police1Pbx.Margin = new System.Windows.Forms.Padding(2);
            this.police1Pbx.Name = "police1Pbx";
            this.police1Pbx.Size = new System.Drawing.Size(30, 34);
            this.police1Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.police1Pbx.TabIndex = 36;
            this.police1Pbx.TabStop = false;
            this.police1Pbx.Click += new System.EventHandler(this.police1Pbx_Click);
            // 
            // police1BarPanel
            // 
            this.police1BarPanel.Controls.Add(this.police1ScoreBarResultLbl);
            this.police1BarPanel.Controls.Add(this.police1ScoreBarLbl);
            this.police1BarPanel.Controls.Add(this.police1NameBarResultLbl);
            this.police1BarPanel.Controls.Add(this.police1NameBarLbl);
            this.police1BarPanel.Location = new System.Drawing.Point(322, 2);
            this.police1BarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.police1BarPanel.Name = "police1BarPanel";
            this.police1BarPanel.Size = new System.Drawing.Size(160, 51);
            this.police1BarPanel.TabIndex = 29;
            // 
            // police1ScoreBarResultLbl
            // 
            this.police1ScoreBarResultLbl.AutoSize = true;
            this.police1ScoreBarResultLbl.BackColor = System.Drawing.Color.Transparent;
            this.police1ScoreBarResultLbl.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.police1ScoreBarResultLbl.ForeColor = System.Drawing.Color.White;
            this.police1ScoreBarResultLbl.Location = new System.Drawing.Point(86, 32);
            this.police1ScoreBarResultLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.police1ScoreBarResultLbl.Name = "police1ScoreBarResultLbl";
            this.police1ScoreBarResultLbl.Size = new System.Drawing.Size(22, 24);
            this.police1ScoreBarResultLbl.TabIndex = 3;
            this.police1ScoreBarResultLbl.Text = "0";
            // 
            // police1ScoreBarLbl
            // 
            this.police1ScoreBarLbl.AutoSize = true;
            this.police1ScoreBarLbl.BackColor = System.Drawing.Color.Transparent;
            this.police1ScoreBarLbl.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.police1ScoreBarLbl.ForeColor = System.Drawing.Color.White;
            this.police1ScoreBarLbl.Location = new System.Drawing.Point(7, 32);
            this.police1ScoreBarLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.police1ScoreBarLbl.Name = "police1ScoreBarLbl";
            this.police1ScoreBarLbl.Size = new System.Drawing.Size(90, 24);
            this.police1ScoreBarLbl.TabIndex = 2;
            this.police1ScoreBarLbl.Text = "Score: ";
            // 
            // police1NameBarResultLbl
            // 
            this.police1NameBarResultLbl.AutoSize = true;
            this.police1NameBarResultLbl.BackColor = System.Drawing.Color.Transparent;
            this.police1NameBarResultLbl.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.police1NameBarResultLbl.ForeColor = System.Drawing.Color.White;
            this.police1NameBarResultLbl.Location = new System.Drawing.Point(86, 10);
            this.police1NameBarResultLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.police1NameBarResultLbl.Name = "police1NameBarResultLbl";
            this.police1NameBarResultLbl.Size = new System.Drawing.Size(22, 24);
            this.police1NameBarResultLbl.TabIndex = 1;
            this.police1NameBarResultLbl.Text = "0";
            // 
            // police1NameBarLbl
            // 
            this.police1NameBarLbl.AutoSize = true;
            this.police1NameBarLbl.BackColor = System.Drawing.Color.Transparent;
            this.police1NameBarLbl.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.police1NameBarLbl.ForeColor = System.Drawing.Color.White;
            this.police1NameBarLbl.Location = new System.Drawing.Point(7, 10);
            this.police1NameBarLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.police1NameBarLbl.Name = "police1NameBarLbl";
            this.police1NameBarLbl.Size = new System.Drawing.Size(110, 24);
            this.police1NameBarLbl.TabIndex = 0;
            this.police1NameBarLbl.Text = "Police2: ";
            // 
            // police1Timer
            // 
            this.police1Timer.Interval = 20;
            this.police1Timer.Tick += new System.EventHandler(this.police1MoveTimerEvent);
            // 
            // CaptureTheThief
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(815, 489);
            this.Controls.Add(this.police1Pbx);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.gameOverPanel);
            this.Controls.Add(this.invisiblePbx);
            this.Controls.Add(this.freezePbx);
            this.Controls.Add(this.flashPbx);
            this.Controls.Add(this.snailPbx);
            this.Controls.Add(this.thiefPbx);
            this.Controls.Add(this.policePbx);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gameMapPbx);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "CaptureTheThief";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture The Thief";
            this.Load += new System.EventHandler(this.CaptureTheThief_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.policeBarPanel.ResumeLayout(false);
            this.policeBarPanel.PerformLayout();
            this.thiefBarPanel.ResumeLayout(false);
            this.thiefBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invisiblePbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freezePbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snailPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thiefPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policePbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameMapPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police1Pbx)).EndInit();
            this.police1BarPanel.ResumeLayout(false);
            this.police1BarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox gameMapPbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Timer levelsTimer;
        private System.Windows.Forms.Timer policeTimer;
        private System.Windows.Forms.Timer ThiefTimer;
        private System.Windows.Forms.PictureBox thiefPbx;
        private System.Windows.Forms.PictureBox policePbx;
        private System.Windows.Forms.Panel policeBarPanel;
        private System.Windows.Forms.Label policeScoreBarResultLbl;
        private System.Windows.Forms.Label policeScoreBarLbl;
        private System.Windows.Forms.Label policeNameBarResultLbl;
        private System.Windows.Forms.Label policeNameBarLbl;
        private System.Windows.Forms.Panel thiefBarPanel;
        private System.Windows.Forms.Label thiefScoreResultBarLbl;
        private System.Windows.Forms.Label thiefScoreBarLbl;
        private System.Windows.Forms.Label thiefNameResultBarLbl;
        private System.Windows.Forms.Label thiefNameBarLbl;
        private System.Windows.Forms.Label levelResultBarLbl;
        private System.Windows.Forms.Label timeLeftResultBarLbl;
        private System.Windows.Forms.Timer timeLeftTimer;
        private System.Windows.Forms.PictureBox flashPbx;
        private System.Windows.Forms.PictureBox snailPbx;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox freezePbx;
        private System.Windows.Forms.PictureBox invisiblePbx;
        private System.Windows.Forms.Panel gameOverPanel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox police1Pbx;
        private System.Windows.Forms.Panel police1BarPanel;
        private System.Windows.Forms.Label police1ScoreBarResultLbl;
        private System.Windows.Forms.Label police1ScoreBarLbl;
        private System.Windows.Forms.Label police1NameBarResultLbl;
        private System.Windows.Forms.Label police1NameBarLbl;
        private System.Windows.Forms.Timer police1Timer;
    }
}