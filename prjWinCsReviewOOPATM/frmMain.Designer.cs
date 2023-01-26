namespace prjWinCsReviewOOPATM
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaptersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFunctions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataReader = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataSet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuATM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chaptersToolStripMenuItem,
            this.mnuProjects,
            this.toolStripSeparator1,
            this.mnuQuit});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // chaptersToolStripMenuItem
            // 
            this.chaptersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFunctions,
            this.mnuDataReader,
            this.mnuDataSet});
            this.chaptersToolStripMenuItem.Name = "chaptersToolStripMenuItem";
            this.chaptersToolStripMenuItem.Size = new System.Drawing.Size(187, 30);
            this.chaptersToolStripMenuItem.Text = "Chapters";
            // 
            // mnuFunctions
            // 
            this.mnuFunctions.Name = "mnuFunctions";
            this.mnuFunctions.Size = new System.Drawing.Size(187, 30);
            this.mnuFunctions.Text = "Functions";
            this.mnuFunctions.Click += new System.EventHandler(this.mnuFunctions_Click);
            // 
            // mnuDataReader
            // 
            this.mnuDataReader.Name = "mnuDataReader";
            this.mnuDataReader.Size = new System.Drawing.Size(187, 30);
            this.mnuDataReader.Text = "DataReader";
            this.mnuDataReader.Click += new System.EventHandler(this.mnuDataReader_Click);
            // 
            // mnuDataSet
            // 
            this.mnuDataSet.Name = "mnuDataSet";
            this.mnuDataSet.Size = new System.Drawing.Size(187, 30);
            this.mnuDataSet.Text = "DataSet";
            this.mnuDataSet.Click += new System.EventHandler(this.mnuDataSet_Click);
            // 
            // mnuProjects
            // 
            this.mnuProjects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuATM});
            this.mnuProjects.Name = "mnuProjects";
            this.mnuProjects.Size = new System.Drawing.Size(187, 30);
            this.mnuProjects.Text = "Projects";
            // 
            // mnuATM
            // 
            this.mnuATM.Name = "mnuATM";
            this.mnuATM.Size = new System.Drawing.Size(132, 30);
            this.mnuATM.Text = "ATM";
            this.mnuATM.Click += new System.EventHandler(this.mnuATM_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mnuQuit.Size = new System.Drawing.Size(187, 30);
            this.mnuQuit.Text = "Quit";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaptersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFunctions;
        private System.Windows.Forms.ToolStripMenuItem mnuDataReader;
        private System.Windows.Forms.ToolStripMenuItem mnuProjects;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.ToolStripMenuItem mnuDataSet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuATM;
    }
}