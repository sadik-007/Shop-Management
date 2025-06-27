namespace ProjectPP
{
    partial class admwork
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
            this.workappro = new System.Windows.Forms.Button();
            this.workorder = new System.Windows.Forms.Button();
            this.worknoti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workappro
            // 
            this.workappro.Font = new System.Drawing.Font("Siyam Rupali", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workappro.Location = new System.Drawing.Point(67, 244);
            this.workappro.Name = "workappro";
            this.workappro.Size = new System.Drawing.Size(215, 152);
            this.workappro.TabIndex = 0;
            this.workappro.Text = "Request\'s";
            this.workappro.UseVisualStyleBackColor = true;
            // 
            // workorder
            // 
            this.workorder.Font = new System.Drawing.Font("Siyam Rupali", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workorder.Location = new System.Drawing.Point(426, 251);
            this.workorder.Name = "workorder";
            this.workorder.Size = new System.Drawing.Size(215, 152);
            this.workorder.TabIndex = 1;
            this.workorder.Text = "Product Availability";
            this.workorder.UseVisualStyleBackColor = true;
            this.workorder.Click += new System.EventHandler(this.workorder_Click);
            // 
            // worknoti
            // 
            this.worknoti.Font = new System.Drawing.Font("Siyam Rupali", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worknoti.Location = new System.Drawing.Point(769, 251);
            this.worknoti.Name = "worknoti";
            this.worknoti.Size = new System.Drawing.Size(251, 152);
            this.worknoti.TabIndex = 2;
            this.worknoti.Text = "Notifications";
            this.worknoti.UseVisualStyleBackColor = true;
            // 
            // admwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.worknoti);
            this.Controls.Add(this.workorder);
            this.Controls.Add(this.workappro);
            this.Name = "admwork";
            this.Text = "admwork";
            this.Load += new System.EventHandler(this.admwork_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button workappro;
        private System.Windows.Forms.Button workorder;
        private System.Windows.Forms.Button worknoti;
    }
}