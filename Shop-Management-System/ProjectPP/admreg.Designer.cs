namespace ProjectPP
{
    partial class admreg
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
            this.admnewacc = new System.Windows.Forms.Label();
            this.admregusername = new System.Windows.Forms.Label();
            this.admreggmail = new System.Windows.Forms.Label();
            this.regdob = new System.Windows.Forms.Label();
            this.regpass = new System.Windows.Forms.Label();
            this.regback = new System.Windows.Forms.Button();
            this.regregister = new System.Windows.Forms.Button();
            this.admreguser = new System.Windows.Forms.MaskedTextBox();
            this.reggmail = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // admnewacc
            // 
            this.admnewacc.AutoSize = true;
            this.admnewacc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.admnewacc.Font = new System.Drawing.Font("Siyam Rupali", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admnewacc.Location = new System.Drawing.Point(319, 100);
            this.admnewacc.Name = "admnewacc";
            this.admnewacc.Size = new System.Drawing.Size(424, 65);
            this.admnewacc.TabIndex = 0;
            this.admnewacc.Text = "Create New Account";
            this.admnewacc.Click += new System.EventHandler(this.admnewacc_Click);
            // 
            // admregusername
            // 
            this.admregusername.AutoSize = true;
            this.admregusername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.admregusername.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admregusername.Location = new System.Drawing.Point(230, 264);
            this.admregusername.Name = "admregusername";
            this.admregusername.Size = new System.Drawing.Size(152, 38);
            this.admregusername.TabIndex = 1;
            this.admregusername.Text = "User Name:";
            this.admregusername.Click += new System.EventHandler(this.admregusername_Click);
            // 
            // admreggmail
            // 
            this.admreggmail.AutoSize = true;
            this.admreggmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.admreggmail.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admreggmail.Location = new System.Drawing.Point(290, 349);
            this.admreggmail.Name = "admreggmail";
            this.admreggmail.Size = new System.Drawing.Size(92, 38);
            this.admreggmail.TabIndex = 2;
            this.admreggmail.Text = "Gmail:";
            this.admreggmail.Click += new System.EventHandler(this.admreggmail_Click);
            // 
            // regdob
            // 
            this.regdob.AutoSize = true;
            this.regdob.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.regdob.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regdob.Location = new System.Drawing.Point(207, 451);
            this.regdob.Name = "regdob";
            this.regdob.Size = new System.Drawing.Size(175, 38);
            this.regdob.TabIndex = 3;
            this.regdob.Text = "Date of Birth:";
            this.regdob.Click += new System.EventHandler(this.regdob_Click);
            // 
            // regpass
            // 
            this.regpass.AutoSize = true;
            this.regpass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.regpass.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regpass.Location = new System.Drawing.Point(250, 553);
            this.regpass.Name = "regpass";
            this.regpass.Size = new System.Drawing.Size(132, 38);
            this.regpass.TabIndex = 4;
            this.regpass.Text = "Password:";
            this.regpass.Click += new System.EventHandler(this.regpass_Click);
            // 
            // regback
            // 
            this.regback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.regback.Font = new System.Drawing.Font("Siyam Rupali", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regback.Location = new System.Drawing.Point(286, 677);
            this.regback.Name = "regback";
            this.regback.Size = new System.Drawing.Size(106, 50);
            this.regback.TabIndex = 5;
            this.regback.Text = "Back";
            this.regback.UseVisualStyleBackColor = false;
            this.regback.Click += new System.EventHandler(this.regback_Click);
            // 
            // regregister
            // 
            this.regregister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.regregister.Font = new System.Drawing.Font("Siyam Rupali", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regregister.Location = new System.Drawing.Point(720, 677);
            this.regregister.Name = "regregister";
            this.regregister.Size = new System.Drawing.Size(159, 50);
            this.regregister.TabIndex = 6;
            this.regregister.Text = "Register";
            this.regregister.UseVisualStyleBackColor = false;
            this.regregister.Click += new System.EventHandler(this.regregister_Click);
            // 
            // admreguser
            // 
            this.admreguser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.admreguser.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admreguser.Location = new System.Drawing.Point(429, 261);
            this.admreguser.Name = "admreguser";
            this.admreguser.Size = new System.Drawing.Size(402, 46);
            this.admreguser.TabIndex = 8;
            this.admreguser.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.admreguser_MaskInputRejected);
            // 
            // reggmail
            // 
            this.reggmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reggmail.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reggmail.Location = new System.Drawing.Point(429, 349);
            this.reggmail.Name = "reggmail";
            this.reggmail.Size = new System.Drawing.Size(402, 46);
            this.reggmail.TabIndex = 9;
            this.reggmail.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.reggmail_MaskInputRejected);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.maskedTextBox4.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox4.Location = new System.Drawing.Point(429, 550);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(402, 46);
            this.maskedTextBox4.TabIndex = 11;
            this.maskedTextBox4.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(429, 451);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(402, 46);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // admreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectPP.Properties.Resources.pngtree_blue_artificial_intelligence_future_technology_background_picture_image_1143086;
            this.ClientSize = new System.Drawing.Size(1082, 803);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.reggmail);
            this.Controls.Add(this.admreguser);
            this.Controls.Add(this.regregister);
            this.Controls.Add(this.regback);
            this.Controls.Add(this.regpass);
            this.Controls.Add(this.regdob);
            this.Controls.Add(this.admreggmail);
            this.Controls.Add(this.admregusername);
            this.Controls.Add(this.admnewacc);
            this.Name = "admreg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admreg";
            this.Load += new System.EventHandler(this.admreg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label admnewacc;
        private System.Windows.Forms.Label admregusername;
        private System.Windows.Forms.Label admreggmail;
        private System.Windows.Forms.Label regdob;
        private System.Windows.Forms.Label regpass;
        private System.Windows.Forms.Button regback;
        private System.Windows.Forms.Button regregister;
        private System.Windows.Forms.MaskedTextBox admreguser;
        private System.Windows.Forms.MaskedTextBox reggmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}