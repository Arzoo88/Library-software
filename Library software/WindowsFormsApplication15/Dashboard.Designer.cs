namespace WindowsFormsApplication15
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSSUEBOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rETURNBOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPLETEBOOKDETAILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOOKToolStripMenuItem,
            this.sTUDENTToolStripMenuItem,
            this.iSSUEBOOKSToolStripMenuItem,
            this.rETURNBOOKSToolStripMenuItem,
            this.cOMPLETEBOOKDETAILToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bOOKToolStripMenuItem
            // 
            this.bOOKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.viewBookToolStripMenuItem});
            this.bOOKToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bOOKToolStripMenuItem.Image")));
            this.bOOKToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bOOKToolStripMenuItem.Name = "bOOKToolStripMenuItem";
            this.bOOKToolStripMenuItem.Size = new System.Drawing.Size(104, 68);
            this.bOOKToolStripMenuItem.Text = "BOOK";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addBookToolStripMenuItem.Image")));
            this.addBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(227, 96);
            this.addBookToolStripMenuItem.Text = "Add New Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // viewBookToolStripMenuItem
            // 
            this.viewBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBookToolStripMenuItem.Image")));
            this.viewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            this.viewBookToolStripMenuItem.Size = new System.Drawing.Size(227, 96);
            this.viewBookToolStripMenuItem.Text = "View Book";
            this.viewBookToolStripMenuItem.Click += new System.EventHandler(this.viewBookToolStripMenuItem_Click);
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.viewStudentDetailsToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sTUDENTToolStripMenuItem.Image")));
            this.sTUDENTToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(134, 68);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            this.sTUDENTToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addStudentToolStripMenuItem.Image")));
            this.addStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(255, 96);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // viewStudentDetailsToolStripMenuItem
            // 
            this.viewStudentDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewStudentDetailsToolStripMenuItem.Image")));
            this.viewStudentDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewStudentDetailsToolStripMenuItem.Name = "viewStudentDetailsToolStripMenuItem";
            this.viewStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(255, 96);
            this.viewStudentDetailsToolStripMenuItem.Text = "View Student Details";
            this.viewStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentDetailsToolStripMenuItem_Click);
            // 
            // iSSUEBOOKSToolStripMenuItem
            // 
            this.iSSUEBOOKSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iSSUEBOOKSToolStripMenuItem.Image")));
            this.iSSUEBOOKSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iSSUEBOOKSToolStripMenuItem.Name = "iSSUEBOOKSToolStripMenuItem";
            this.iSSUEBOOKSToolStripMenuItem.Size = new System.Drawing.Size(149, 68);
            this.iSSUEBOOKSToolStripMenuItem.Text = "ISSUE BOOKS";
            this.iSSUEBOOKSToolStripMenuItem.Click += new System.EventHandler(this.iSSUEBOOKSToolStripMenuItem_Click);
            // 
            // rETURNBOOKSToolStripMenuItem
            // 
            this.rETURNBOOKSToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.rETURNBOOKSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rETURNBOOKSToolStripMenuItem.Image")));
            this.rETURNBOOKSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rETURNBOOKSToolStripMenuItem.Name = "rETURNBOOKSToolStripMenuItem";
            this.rETURNBOOKSToolStripMenuItem.Size = new System.Drawing.Size(164, 68);
            this.rETURNBOOKSToolStripMenuItem.Text = "RETURN BOOKS";
            this.rETURNBOOKSToolStripMenuItem.Click += new System.EventHandler(this.rETURNBOOKSToolStripMenuItem_Click);
            // 
            // cOMPLETEBOOKDETAILToolStripMenuItem
            // 
            this.cOMPLETEBOOKDETAILToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cOMPLETEBOOKDETAILToolStripMenuItem.Image")));
            this.cOMPLETEBOOKDETAILToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cOMPLETEBOOKDETAILToolStripMenuItem.Name = "cOMPLETEBOOKDETAILToolStripMenuItem";
            this.cOMPLETEBOOKDETAILToolStripMenuItem.Size = new System.Drawing.Size(218, 68);
            this.cOMPLETEBOOKDETAILToolStripMenuItem.Text = "COMPLETE BOOK DETAIL";
            this.cOMPLETEBOOKDETAILToolStripMenuItem.Click += new System.EventHandler(this.cOMPLETEBOOKDETAILToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.eXITToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eXITToolStripMenuItem.Image")));
            this.eXITToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(86, 68);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSSUEBOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETURNBOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPLETEBOOKDETAILToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}