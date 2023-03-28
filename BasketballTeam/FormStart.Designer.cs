namespace laborator_8
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdUsers = new System.Windows.Forms.Button();
            this.cmdFiles = new System.Windows.Forms.Button();
            this.cmdMovies = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmdMinimize = new System.Windows.Forms.Button();
            this.cmdMaximize = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.cmdUsers);
            this.panelMenu.Controls.Add(this.cmdFiles);
            this.panelMenu.Controls.Add(this.cmdMovies);
            this.panelMenu.Location = new System.Drawing.Point(0, 48);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 541);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Deconectare";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 73);
            this.button1.TabIndex = 5;
            this.button1.Text = "Profil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmdUsers
            // 
            this.cmdUsers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdUsers.ForeColor = System.Drawing.Color.White;
            this.cmdUsers.Image = ((System.Drawing.Image)(resources.GetObject("cmdUsers.Image")));
            this.cmdUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdUsers.Location = new System.Drawing.Point(0, 136);
            this.cmdUsers.Name = "cmdUsers";
            this.cmdUsers.Size = new System.Drawing.Size(150, 68);
            this.cmdUsers.TabIndex = 4;
            this.cmdUsers.Text = "Users";
            this.cmdUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdUsers.UseVisualStyleBackColor = false;
            this.cmdUsers.Click += new System.EventHandler(this.cmdUsers_Click_1);
            // 
            // cmdFiles
            // 
            this.cmdFiles.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFiles.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdFiles.ForeColor = System.Drawing.Color.White;
            this.cmdFiles.Image = ((System.Drawing.Image)(resources.GetObject("cmdFiles.Image")));
            this.cmdFiles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdFiles.Location = new System.Drawing.Point(0, 65);
            this.cmdFiles.Name = "cmdFiles";
            this.cmdFiles.Size = new System.Drawing.Size(150, 71);
            this.cmdFiles.TabIndex = 2;
            this.cmdFiles.Text = "Meciuri";
            this.cmdFiles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdFiles.UseVisualStyleBackColor = false;
            this.cmdFiles.Click += new System.EventHandler(this.cmdFiles_Click);
            // 
            // cmdMovies
            // 
            this.cmdMovies.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMovies.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdMovies.ForeColor = System.Drawing.Color.White;
            this.cmdMovies.Image = ((System.Drawing.Image)(resources.GetObject("cmdMovies.Image")));
            this.cmdMovies.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdMovies.Location = new System.Drawing.Point(0, 0);
            this.cmdMovies.Name = "cmdMovies";
            this.cmdMovies.Size = new System.Drawing.Size(150, 65);
            this.cmdMovies.TabIndex = 0;
            this.cmdMovies.Text = "Jucatori";
            this.cmdMovies.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdMovies.UseVisualStyleBackColor = false;
            this.cmdMovies.Click += new System.EventHandler(this.cmdMovies_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Location = new System.Drawing.Point(149, 48);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(833, 541);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Click += new System.EventHandler(this.panelDesktop_Click);
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(583, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Controls.Add(this.cmdMinimize);
            this.panelTitle.Controls.Add(this.cmdMaximize);
            this.panelTitle.Controls.Add(this.cmdClose);
            this.panelTitle.Location = new System.Drawing.Point(149, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(833, 49);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(177, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BC Steaua Bucuresti";
            // 
            // cmdMinimize
            // 
            this.cmdMinimize.BackColor = System.Drawing.Color.Transparent;
            this.cmdMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinimize.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdMinimize.ForeColor = System.Drawing.Color.White;
            this.cmdMinimize.Location = new System.Drawing.Point(608, 0);
            this.cmdMinimize.Name = "cmdMinimize";
            this.cmdMinimize.Size = new System.Drawing.Size(75, 49);
            this.cmdMinimize.TabIndex = 3;
            this.cmdMinimize.Text = "🗕";
            this.cmdMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdMinimize.UseVisualStyleBackColor = false;
            this.cmdMinimize.Click += new System.EventHandler(this.cmdMinimize_Click);
            // 
            // cmdMaximize
            // 
            this.cmdMaximize.BackColor = System.Drawing.Color.Transparent;
            this.cmdMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMaximize.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdMaximize.ForeColor = System.Drawing.Color.White;
            this.cmdMaximize.Location = new System.Drawing.Point(683, 0);
            this.cmdMaximize.Name = "cmdMaximize";
            this.cmdMaximize.Size = new System.Drawing.Size(75, 49);
            this.cmdMaximize.TabIndex = 2;
            this.cmdMaximize.Text = "🗖";
            this.cmdMaximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdMaximize.UseVisualStyleBackColor = false;
            this.cmdMaximize.Click += new System.EventHandler(this.cmdMaximize_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Transparent;
            this.cmdClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdClose.ForeColor = System.Drawing.Color.White;
            this.cmdClose.Location = new System.Drawing.Point(758, 0);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 49);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "🗙";
            this.cmdClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(150, 49);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 49);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 589);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormStart";
            this.Text = "FormStart";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panelDesktop;
        private Panel panelTitle;
        private Button cmdMinimize;
        private Button cmdMaximize;
        private Button cmdClose;
        private Label lblTitle;
        private Panel panelLogo;
        private Button cmdFiles;
        private Button cmdMovies;
        private Button button1;
        private Button cmdUsers;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}