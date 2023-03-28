namespace laborator_8
{
    partial class FormMeciuri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeciuri));
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdModify = new System.Windows.Forms.Button();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.txtDivizia = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtInvingator = new System.Windows.Forms.TextBox();
            this.txtAdversar = new System.Windows.Forms.TextBox();
            this.txtFileId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPuncte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeM = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Location = new System.Drawing.Point(0, -1);
            this.dgvFiles.MultiSelect = false;
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowTemplate.Height = 25;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(881, 219);
            this.dgvFiles.TabIndex = 0;
            this.dgvFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellContentClick);
            this.dgvFiles.SelectionChanged += new System.EventHandler(this.dgvFiles_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(25, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Divizia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(25, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adversar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(25, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Invingator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(25, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID utilizator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(25, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID fisier";
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackColor = System.Drawing.Color.Lime;
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAdd.Location = new System.Drawing.Point(530, 260);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(101, 31);
            this.cmdAdd.TabIndex = 6;
            this.cmdAdd.Text = "Adauga";
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdModify
            // 
            this.cmdModify.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdModify.Location = new System.Drawing.Point(530, 323);
            this.cmdModify.Name = "cmdModify";
            this.cmdModify.Size = new System.Drawing.Size(101, 31);
            this.cmdModify.TabIndex = 7;
            this.cmdModify.Text = "Modifica";
            this.cmdModify.UseVisualStyleBackColor = false;
            this.cmdModify.Click += new System.EventHandler(this.cmdModify_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.BackColor = System.Drawing.Color.Red;
            this.cmdRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdRemove.Location = new System.Drawing.Point(530, 398);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(101, 31);
            this.cmdRemove.TabIndex = 8;
            this.cmdRemove.Text = "Sterge";
            this.cmdRemove.UseVisualStyleBackColor = false;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // txtDivizia
            // 
            this.txtDivizia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDivizia.Location = new System.Drawing.Point(135, 260);
            this.txtDivizia.Name = "txtDivizia";
            this.txtDivizia.Size = new System.Drawing.Size(247, 22);
            this.txtDivizia.TabIndex = 9;
            this.txtDivizia.TextChanged += new System.EventHandler(this.txtDivizia_TextChanged);
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUserId.Location = new System.Drawing.Point(135, 444);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(110, 22);
            this.txtUserId.TabIndex = 10;
            this.txtUserId.TextChanged += new System.EventHandler(this.TxtUserId_TextChanged);
            this.txtUserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserId_KeyPress);
            // 
            // txtInvingator
            // 
            this.txtInvingator.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtInvingator.Location = new System.Drawing.Point(135, 370);
            this.txtInvingator.Name = "txtInvingator";
            this.txtInvingator.Size = new System.Drawing.Size(213, 22);
            this.txtInvingator.TabIndex = 11;
            this.txtInvingator.TextChanged += new System.EventHandler(this.txtInvingator_TextChanged);
            // 
            // txtAdversar
            // 
            this.txtAdversar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAdversar.Location = new System.Drawing.Point(135, 330);
            this.txtAdversar.Name = "txtAdversar";
            this.txtAdversar.Size = new System.Drawing.Size(213, 22);
            this.txtAdversar.TabIndex = 12;
            this.txtAdversar.TextChanged += new System.EventHandler(this.txtAdversar_TextChanged);
            this.txtAdversar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // txtFileId
            // 
            this.txtFileId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFileId.Location = new System.Drawing.Point(135, 479);
            this.txtFileId.Name = "txtFileId";
            this.txtFileId.ReadOnly = true;
            this.txtFileId.Size = new System.Drawing.Size(83, 22);
            this.txtFileId.TabIndex = 13;
            this.txtFileId.TextChanged += new System.EventHandler(this.txtFileId_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(25, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Puncte";
            // 
            // txtPuncte
            // 
            this.txtPuncte.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPuncte.Location = new System.Drawing.Point(135, 410);
            this.txtPuncte.Name = "txtPuncte";
            this.txtPuncte.Size = new System.Drawing.Size(110, 22);
            this.txtPuncte.TabIndex = 15;
            this.txtPuncte.TextChanged += new System.EventHandler(this.txtPuncte_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(25, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data";
            // 
            // dateTimeM
            // 
            this.dateTimeM.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimeM.CalendarTitleBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimeM.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dateTimeM.CustomFormat = "yyyy-MM-dd";
            this.dateTimeM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeM.Location = new System.Drawing.Point(135, 292);
            this.dateTimeM.Name = "dateTimeM";
            this.dateTimeM.Size = new System.Drawing.Size(247, 22);
            this.dateTimeM.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "CAUTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseEnter);
            // 
            // FormMeciuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimeM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPuncte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFileId);
            this.Controls.Add(this.txtAdversar);
            this.Controls.Add(this.txtInvingator);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtDivizia);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.cmdModify);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFiles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormMeciuri";
            this.Text = "BC Steaua Bucuresti";
            this.Load += new System.EventHandler(this.FormFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvFiles;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button cmdAdd;
        private Button cmdModify;
        private Button cmdRemove;
        private TextBox txtDivizia;
        private TextBox txtUserId;
        private TextBox txtInvingator;
        private TextBox txtAdversar;
        private TextBox txtFileId;
        private Label label6;
        private TextBox txtPuncte;
        private Label label7;
        private DateTimePicker dateTimeM;
        private Button button1;
    }
}