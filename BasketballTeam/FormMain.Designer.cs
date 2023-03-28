namespace laborator_8
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAddMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formFilesToolStripMenuItem,
            this.formUsersToolStripMenuItem,
            this.formMoviesToolStripMenuItem,
            this.formAddMoviesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formFilesToolStripMenuItem
            // 
            this.formFilesToolStripMenuItem.Name = "formFilesToolStripMenuItem";
            this.formFilesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.formFilesToolStripMenuItem.Text = "FormFiles";
            this.formFilesToolStripMenuItem.Click += new System.EventHandler(this.formFilesToolStripMenuItem_Click);
            // 
            // formUsersToolStripMenuItem
            // 
            this.formUsersToolStripMenuItem.Name = "formUsersToolStripMenuItem";
            this.formUsersToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.formUsersToolStripMenuItem.Text = "FormUsers";
            this.formUsersToolStripMenuItem.Click += new System.EventHandler(this.formUsersToolStripMenuItem_Click);
            // 
            // formMoviesToolStripMenuItem
            // 
            this.formMoviesToolStripMenuItem.Name = "formMoviesToolStripMenuItem";
            this.formMoviesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.formMoviesToolStripMenuItem.Text = "FormMovies";
            this.formMoviesToolStripMenuItem.Click += new System.EventHandler(this.formMoviesToolStripMenuItem_Click);
            // 
            // formAddMoviesToolStripMenuItem
            // 
            this.formAddMoviesToolStripMenuItem.Name = "formAddMoviesToolStripMenuItem";
            this.formAddMoviesToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.formAddMoviesToolStripMenuItem.Text = "FormAddMovies";
            this.formAddMoviesToolStripMenuItem.Click += new System.EventHandler(this.formAddMoviesToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 86);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem formFilesToolStripMenuItem;
        private ToolStripMenuItem formUsersToolStripMenuItem;
        private ToolStripMenuItem formMoviesToolStripMenuItem;
        private ToolStripMenuItem formAddMoviesToolStripMenuItem;
    }
}