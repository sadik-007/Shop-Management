namespace ProjectPP
{
    partial class AdminLog
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
            this.admlogusername = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.admlogpass = new System.Windows.Forms.Label();
            this.admloglogin = new System.Windows.Forms.Button();
            this.admlogforgotpass = new System.Windows.Forms.Button();
            this.admloggreg = new System.Windows.Forms.Button();
            this.admwelcome = new System.Windows.Forms.Label();
            this.admlogback = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // admlogusername
            // 
            this.admlogusername.AutoSize = true;
            this.admlogusername.BackColor = System.Drawing.Color.LightSteelBlue;
            this.admlogusername.Font = new System.Drawing.Font("Siyam Rupali", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admlogusername.Location = new System.Drawing.Point(649, 71);
            this.admlogusername.Name = "admlogusername";
            this.admlogusername.Size = new System.Drawing.Size(125, 29);
            this.admlogusername.TabIndex = 0;
            this.admlogusername.Text = "User Name:";
            this.admlogusername.Click += new System.EventHandler(this.admlogusername_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.Location = new System.Drawing.Point(654, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox3.Location = new System.Drawing.Point(654, 261);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(321, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.UseSystemPasswordChar = true;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // admlogpass
            // 
            this.admlogpass.AutoSize = true;
            this.admlogpass.BackColor = System.Drawing.Color.LightSteelBlue;
            this.admlogpass.Font = new System.Drawing.Font("Siyam Rupali", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admlogpass.Location = new System.Drawing.Point(647, 194);
            this.admlogpass.Name = "admlogpass";
            this.admlogpass.Size = new System.Drawing.Size(110, 29);
            this.admlogpass.TabIndex = 5;
            this.admlogpass.Text = "Password:";
            // 
            // admloglogin
            // 
            this.admloglogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.admloglogin.Font = new System.Drawing.Font("Siyam Rupali", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admloglogin.Location = new System.Drawing.Point(860, 334);
            this.admloglogin.Name = "admloglogin";
            this.admloglogin.Size = new System.Drawing.Size(115, 45);
            this.admloglogin.TabIndex = 6;
            this.admloglogin.Text = "Log In";
            this.admloglogin.UseVisualStyleBackColor = false;
            this.admloglogin.Click += new System.EventHandler(this.admloglogin_Click);
            // 
            // admlogforgotpass
            // 
            this.admlogforgotpass.BackColor = System.Drawing.Color.LightSteelBlue;
            this.admlogforgotpass.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admlogforgotpass.Location = new System.Drawing.Point(809, 431);
            this.admlogforgotpass.Name = "admlogforgotpass";
            this.admlogforgotpass.Size = new System.Drawing.Size(180, 43);
            this.admlogforgotpass.TabIndex = 7;
            this.admlogforgotpass.Text = "Forgot Password?";
            this.admlogforgotpass.UseVisualStyleBackColor = false;
            this.admlogforgotpass.Click += new System.EventHandler(this.admlogforgotpass_Click);
            // 
            // admloggreg
            // 
            this.admloggreg.BackColor = System.Drawing.Color.LightSteelBlue;
            this.admloggreg.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admloggreg.Location = new System.Drawing.Point(760, 497);
            this.admloggreg.Name = "admloggreg";
            this.admloggreg.Size = new System.Drawing.Size(229, 43);
            this.admloggreg.TabIndex = 8;
            this.admloggreg.Text = "Don\'t have an account?";
            this.admloggreg.UseVisualStyleBackColor = false;
            this.admloggreg.Click += new System.EventHandler(this.admloggreg_Click);
            // 
            // admwelcome
            // 
            this.admwelcome.AutoSize = true;
            this.admwelcome.BackColor = System.Drawing.Color.MidnightBlue;
            this.admwelcome.Font = new System.Drawing.Font("Siyam Rupali", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admwelcome.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.admwelcome.Location = new System.Drawing.Point(50, 95);
            this.admwelcome.Name = "admwelcome";
            this.admwelcome.Size = new System.Drawing.Size(216, 69);
            this.admwelcome.TabIndex = 9;
            this.admwelcome.Text = "Welcome";
            // 
            // admlogback
            // 
            this.admlogback.AutoSize = true;
            this.admlogback.BackColor = System.Drawing.Color.MidnightBlue;
            this.admlogback.Font = new System.Drawing.Font("Siyam Rupali", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admlogback.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.admlogback.Location = new System.Drawing.Point(188, 194);
            this.admlogback.Name = "admlogback";
            this.admlogback.Size = new System.Drawing.Size(124, 69);
            this.admlogback.TabIndex = 10;
            this.admlogback.Text = "Back";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Siyam Rupali", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(253, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 69);
            this.label3.TabIndex = 11;
            this.label3.Text = "Admin!!";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.checkBox1.Location = new System.Drawing.Point(652, 295);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 20);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AdminLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::ProjectPP.Properties.Resources.strip_texture_dark_blue_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(1082, 583);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.admlogback);
            this.Controls.Add(this.admwelcome);
            this.Controls.Add(this.admloggreg);
            this.Controls.Add(this.admlogforgotpass);
            this.Controls.Add(this.admloglogin);
            this.Controls.Add(this.admlogpass);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.admlogusername);
            this.Name = "AdminLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLog";
            this.Load += new System.EventHandler(this.AdminLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label admlogusername;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label admlogpass;
        private System.Windows.Forms.Button admloglogin;
        private System.Windows.Forms.Button admlogforgotpass;
        private System.Windows.Forms.Button admloggreg;
        private System.Windows.Forms.Label admwelcome;
        private System.Windows.Forms.Label admlogback;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}