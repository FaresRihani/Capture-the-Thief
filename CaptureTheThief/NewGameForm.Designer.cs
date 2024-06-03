
namespace CaptureTheThief
{
    partial class NewGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGameForm));
            this.mapImageList = new System.Windows.Forms.ImageList(this.components);
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
            this.carImageList = new System.Windows.Forms.ImageList(this.components);
            this.startTheGameBtn = new System.Windows.Forms.Button();
            this.thiefComb = new System.Windows.Forms.ComboBox();
            this.policeComb = new System.Windows.Forms.ComboBox();
            this.mapsPbx = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.nextMapBtn = new System.Windows.Forms.Button();
            this.mapNameLbl = new System.Windows.Forms.Label();
            this.policeComputerRbtn = new System.Windows.Forms.RadioButton();
            this.thiefComputerRbtn = new System.Windows.Forms.RadioButton();
            this.police1Comb = new System.Windows.Forms.ComboBox();
            this.police1ComputerRbtn = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapsPbx)).BeginInit();
            this.SuspendLayout();
            // 
            // mapImageList
            // 
            this.mapImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mapImageList.ImageStream")));
            this.mapImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.mapImageList.Images.SetKeyName(0, "DesertMap.PNG");
            this.mapImageList.Images.SetKeyName(1, "FarmMap.PNG");
            this.mapImageList.Images.SetKeyName(2, "NightMap (1).png");
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
            this.menuStrip1.Size = new System.Drawing.Size(709, 31);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(149, 34);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.Enabled = false;
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(149, 34);
            this.endToolStripMenuItem.Text = "End";
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
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(172, 34);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.currentToolStripMenuItem.Text = "Current";
            this.currentToolStripMenuItem.Click += new System.EventHandler(this.currentToolStripMenuItem_Click);
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
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // carImageList
            // 
            this.carImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("carImageList.ImageStream")));
            this.carImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.carImageList.Images.SetKeyName(0, "PoliceCar1 .PNG");
            this.carImageList.Images.SetKeyName(1, "PoliceCar2 .PNG");
            this.carImageList.Images.SetKeyName(2, "PoliceCar3 .PNG");
            this.carImageList.Images.SetKeyName(3, "ThiefCar1 .PNG");
            this.carImageList.Images.SetKeyName(4, "ThiefCar2.png");
            this.carImageList.Images.SetKeyName(5, "ThiefCar3 .PNG");
            // 
            // startTheGameBtn
            // 
            this.startTheGameBtn.BackColor = System.Drawing.Color.Transparent;
            this.startTheGameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startTheGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startTheGameBtn.FlatAppearance.BorderSize = 0;
            this.startTheGameBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startTheGameBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startTheGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTheGameBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTheGameBtn.ForeColor = System.Drawing.Color.White;
            this.startTheGameBtn.Location = new System.Drawing.Point(283, 111);
            this.startTheGameBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startTheGameBtn.Name = "startTheGameBtn";
            this.startTheGameBtn.Size = new System.Drawing.Size(157, 129);
            this.startTheGameBtn.TabIndex = 9;
            this.startTheGameBtn.UseVisualStyleBackColor = false;
            this.startTheGameBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // thiefComb
            // 
            this.thiefComb.BackColor = System.Drawing.SystemColors.MenuText;
            this.thiefComb.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thiefComb.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.thiefComb.FormattingEnabled = true;
            this.thiefComb.Location = new System.Drawing.Point(553, 303);
            this.thiefComb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thiefComb.Name = "thiefComb";
            this.thiefComb.Size = new System.Drawing.Size(134, 37);
            this.thiefComb.TabIndex = 8;
            this.thiefComb.SelectedIndexChanged += new System.EventHandler(this.thiefComb_SelectedIndexChanged_1);
            // 
            // policeComb
            // 
            this.policeComb.BackColor = System.Drawing.SystemColors.MenuText;
            this.policeComb.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policeComb.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.policeComb.FormattingEnabled = true;
            this.policeComb.Location = new System.Drawing.Point(25, 303);
            this.policeComb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.policeComb.Name = "policeComb";
            this.policeComb.Size = new System.Drawing.Size(134, 37);
            this.policeComb.TabIndex = 7;
            this.policeComb.SelectedIndexChanged += new System.EventHandler(this.policeComb_SelectedIndexChanged_1);
            // 
            // mapsPbx
            // 
            this.mapsPbx.BackColor = System.Drawing.Color.Transparent;
            this.mapsPbx.Location = new System.Drawing.Point(272, 248);
            this.mapsPbx.Name = "mapsPbx";
            this.mapsPbx.Size = new System.Drawing.Size(143, 94);
            this.mapsPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapsPbx.TabIndex = 22;
            this.mapsPbx.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "IMG_2811.PNG");
            this.imageList1.Images.SetKeyName(1, "IMG_2818.PNG");
            this.imageList1.Images.SetKeyName(2, "NightMap.png");
            // 
            // nextMapBtn
            // 
            this.nextMapBtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.nextMapBtn.BackgroundImage = global::CaptureTheThief.Properties.Resources.result__3_1;
            this.nextMapBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextMapBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nextMapBtn.FlatAppearance.BorderSize = 3;
            this.nextMapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextMapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextMapBtn.ForeColor = System.Drawing.Color.Transparent;
            this.nextMapBtn.Location = new System.Drawing.Point(327, 321);
            this.nextMapBtn.Name = "nextMapBtn";
            this.nextMapBtn.Size = new System.Drawing.Size(30, 22);
            this.nextMapBtn.TabIndex = 23;
            this.nextMapBtn.UseVisualStyleBackColor = false;
            this.nextMapBtn.Click += new System.EventHandler(this.nextMapBtn_Click);
            // 
            // mapNameLbl
            // 
            this.mapNameLbl.AutoSize = true;
            this.mapNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.mapNameLbl.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapNameLbl.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.mapNameLbl.Location = new System.Drawing.Point(275, 350);
            this.mapNameLbl.Name = "mapNameLbl";
            this.mapNameLbl.Size = new System.Drawing.Size(27, 29);
            this.mapNameLbl.TabIndex = 24;
            this.mapNameLbl.Text = "z";
            this.mapNameLbl.Click += new System.EventHandler(this.mapNameLbl_Click_1);
            // 
            // policeComputerRbtn
            // 
            this.policeComputerRbtn.AutoSize = true;
            this.policeComputerRbtn.BackColor = System.Drawing.Color.Transparent;
            this.policeComputerRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policeComputerRbtn.Location = new System.Drawing.Point(163, 134);
            this.policeComputerRbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.policeComputerRbtn.Name = "policeComputerRbtn";
            this.policeComputerRbtn.Size = new System.Drawing.Size(21, 20);
            this.policeComputerRbtn.TabIndex = 25;
            this.policeComputerRbtn.TabStop = true;
            this.policeComputerRbtn.UseVisualStyleBackColor = false;
            this.policeComputerRbtn.CheckedChanged += new System.EventHandler(this.policeComputerRbtn_CheckedChanged);
            // 
            // thiefComputerRbtn
            // 
            this.thiefComputerRbtn.AutoSize = true;
            this.thiefComputerRbtn.BackColor = System.Drawing.Color.Transparent;
            this.thiefComputerRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thiefComputerRbtn.Location = new System.Drawing.Point(533, 136);
            this.thiefComputerRbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thiefComputerRbtn.Name = "thiefComputerRbtn";
            this.thiefComputerRbtn.Size = new System.Drawing.Size(21, 20);
            this.thiefComputerRbtn.TabIndex = 26;
            this.thiefComputerRbtn.TabStop = true;
            this.thiefComputerRbtn.UseVisualStyleBackColor = false;
            this.thiefComputerRbtn.CheckedChanged += new System.EventHandler(this.thiefComputerRbtn_CheckedChanged);
            // 
            // police1Comb
            // 
            this.police1Comb.BackColor = System.Drawing.SystemColors.MenuText;
            this.police1Comb.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.police1Comb.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.police1Comb.FormattingEnabled = true;
            this.police1Comb.Location = new System.Drawing.Point(306, 60);
            this.police1Comb.Margin = new System.Windows.Forms.Padding(2);
            this.police1Comb.Name = "police1Comb";
            this.police1Comb.Size = new System.Drawing.Size(134, 37);
            this.police1Comb.TabIndex = 27;
            // 
            // police1ComputerRbtn
            // 
            this.police1ComputerRbtn.AutoSize = true;
            this.police1ComputerRbtn.BackColor = System.Drawing.Color.Transparent;
            this.police1ComputerRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.police1ComputerRbtn.Location = new System.Drawing.Point(253, 68);
            this.police1ComputerRbtn.Margin = new System.Windows.Forms.Padding(2);
            this.police1ComputerRbtn.Name = "police1ComputerRbtn";
            this.police1ComputerRbtn.Size = new System.Drawing.Size(21, 20);
            this.police1ComputerRbtn.TabIndex = 28;
            this.police1ComputerRbtn.TabStop = true;
            this.police1ComputerRbtn.UseVisualStyleBackColor = false;
            this.police1ComputerRbtn.CheckedChanged += new System.EventHandler(this.police1ComputerRbtn_CheckedChanged);
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CaptureTheThief.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 375);
            this.Controls.Add(this.police1ComputerRbtn);
            this.Controls.Add(this.police1Comb);
            this.Controls.Add(this.nextMapBtn);
            this.Controls.Add(this.thiefComputerRbtn);
            this.Controls.Add(this.policeComputerRbtn);
            this.Controls.Add(this.mapNameLbl);
            this.Controls.Add(this.mapsPbx);
            this.Controls.Add(this.thiefComb);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.policeComb);
            this.Controls.Add(this.startTheGameBtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "NewGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Game Form";
            this.Load += new System.EventHandler(this.NewGameForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapsPbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList mapImageList;
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
        private System.Windows.Forms.ImageList carImageList;
        private System.Windows.Forms.Button startTheGameBtn;
        private System.Windows.Forms.ComboBox thiefComb;
        private System.Windows.Forms.ComboBox policeComb;
        private System.Windows.Forms.PictureBox mapsPbx;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button nextMapBtn;
        private System.Windows.Forms.Label mapNameLbl;
        private System.Windows.Forms.RadioButton policeComputerRbtn;
        private System.Windows.Forms.RadioButton thiefComputerRbtn;
        private System.Windows.Forms.ComboBox police1Comb;
        private System.Windows.Forms.RadioButton police1ComputerRbtn;
    }
}