
namespace CaptureTheThief
{
    partial class NewProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProfileForm));
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.blueRbtn = new System.Windows.Forms.RadioButton();
            this.yellowRbtn = new System.Windows.Forms.RadioButton();
            this.greenRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaleRbtn = new System.Windows.Forms.RadioButton();
            this.femaleRbtn = new System.Windows.Forms.RadioButton();
            this.saveBtn = new System.Windows.Forms.Button();
            this.ageComb = new System.Windows.Forms.ComboBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(970, 36);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.endToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(74, 30);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(149, 34);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
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
            this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.currentToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(78, 30);
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
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(81, 30);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 30);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 30);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.blueRbtn);
            this.groupBox2.Controls.Add(this.yellowRbtn);
            this.groupBox2.Controls.Add(this.greenRbtn);
            this.groupBox2.Location = new System.Drawing.Point(480, 415);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(213, 155);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // blueRbtn
            // 
            this.blueRbtn.AutoSize = true;
            this.blueRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueRbtn.ForeColor = System.Drawing.Color.White;
            this.blueRbtn.Location = new System.Drawing.Point(8, 15);
            this.blueRbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blueRbtn.Name = "blueRbtn";
            this.blueRbtn.Size = new System.Drawing.Size(21, 20);
            this.blueRbtn.TabIndex = 1;
            this.blueRbtn.UseVisualStyleBackColor = true;
            // 
            // yellowRbtn
            // 
            this.yellowRbtn.AutoSize = true;
            this.yellowRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowRbtn.ForeColor = System.Drawing.Color.White;
            this.yellowRbtn.Location = new System.Drawing.Point(8, 68);
            this.yellowRbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yellowRbtn.Name = "yellowRbtn";
            this.yellowRbtn.Size = new System.Drawing.Size(21, 20);
            this.yellowRbtn.TabIndex = 2;
            this.yellowRbtn.UseVisualStyleBackColor = true;
            this.yellowRbtn.CheckedChanged += new System.EventHandler(this.yellowRbtn_CheckedChanged);
            // 
            // greenRbtn
            // 
            this.greenRbtn.AutoSize = true;
            this.greenRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenRbtn.ForeColor = System.Drawing.Color.White;
            this.greenRbtn.Location = new System.Drawing.Point(8, 123);
            this.greenRbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.greenRbtn.Name = "greenRbtn";
            this.greenRbtn.Size = new System.Drawing.Size(21, 20);
            this.greenRbtn.TabIndex = 3;
            this.greenRbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.MaleRbtn);
            this.groupBox1.Controls.Add(this.femaleRbtn);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(480, 209);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(354, 65);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // MaleRbtn
            // 
            this.MaleRbtn.AutoSize = true;
            this.MaleRbtn.BackColor = System.Drawing.Color.Transparent;
            this.MaleRbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaleRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRbtn.Location = new System.Drawing.Point(11, 27);
            this.MaleRbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaleRbtn.Name = "MaleRbtn";
            this.MaleRbtn.Size = new System.Drawing.Size(21, 20);
            this.MaleRbtn.TabIndex = 1;
            this.MaleRbtn.UseVisualStyleBackColor = false;
            this.MaleRbtn.CheckedChanged += new System.EventHandler(this.MaleRbtn_CheckedChanged);
            // 
            // femaleRbtn
            // 
            this.femaleRbtn.AutoSize = true;
            this.femaleRbtn.BackColor = System.Drawing.Color.Transparent;
            this.femaleRbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.femaleRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRbtn.Location = new System.Drawing.Point(208, 27);
            this.femaleRbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.femaleRbtn.Name = "femaleRbtn";
            this.femaleRbtn.Size = new System.Drawing.Size(21, 20);
            this.femaleRbtn.TabIndex = 2;
            this.femaleRbtn.TabStop = true;
            this.femaleRbtn.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(743, 445);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(130, 113);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click_1);
            // 
            // ageComb
            // 
            this.ageComb.BackColor = System.Drawing.SystemColors.MenuText;
            this.ageComb.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageComb.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.ageComb.FormattingEnabled = true;
            this.ageComb.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.ageComb.Location = new System.Drawing.Point(485, 328);
            this.ageComb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ageComb.Name = "ageComb";
            this.ageComb.Size = new System.Drawing.Size(346, 37);
            this.ageComb.TabIndex = 1;
            // 
            // Nametxt
            // 
            this.Nametxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.Nametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nametxt.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nametxt.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Nametxt.Location = new System.Drawing.Point(480, 132);
            this.Nametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(346, 29);
            this.Nametxt.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NewProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaptureTheThief.Properties.Resources.Create_a_profile__final_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 598);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ageComb);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.saveBtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Profile";
            this.Load += new System.EventHandler(this.NewProfileForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ImageList carImageList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton blueRbtn;
        private System.Windows.Forms.RadioButton yellowRbtn;
        private System.Windows.Forms.RadioButton greenRbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MaleRbtn;
        private System.Windows.Forms.RadioButton femaleRbtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox ageComb;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}