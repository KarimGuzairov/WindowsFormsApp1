namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.TSM_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_About = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_File,
            this.TSM_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSM_File
            // 
            this.TSM_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Exit});
            this.TSM_File.Name = "TSM_File";
            this.TSM_File.Size = new System.Drawing.Size(37, 20);
            this.TSM_File.Text = "File";
            // 
            // TSM_Help
            // 
            this.TSM_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_About});
            this.TSM_Help.Name = "TSM_Help";
            this.TSM_Help.Size = new System.Drawing.Size(44, 20);
            this.TSM_Help.Text = "Help";
            // 
            // TSM_About
            // 
            this.TSM_About.Name = "TSM_About";
            this.TSM_About.Size = new System.Drawing.Size(180, 22);
            this.TSM_About.Text = "About this program";
            this.TSM_About.Click += new System.EventHandler(this.TSM_About_Click);
            // 
            // TSM_Exit
            // 
            this.TSM_Exit.Name = "TSM_Exit";
            this.TSM_Exit.Size = new System.Drawing.Size(180, 22);
            this.TSM_Exit.Text = "Exit";
            this.TSM_Exit.Click += new System.EventHandler(this.TSM_Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSM_File;
        private System.Windows.Forms.ToolStripMenuItem TSM_Exit;
        private System.Windows.Forms.ToolStripMenuItem TSM_Help;
        private System.Windows.Forms.ToolStripMenuItem TSM_About;
    }
}

