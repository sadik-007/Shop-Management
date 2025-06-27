namespace ProjectPP
{
    partial class Admorder
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
            this.admorderdata = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.admordproduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.admorderdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // admorderdata
            // 
            this.admorderdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admorderdata.Location = new System.Drawing.Point(25, 159);
            this.admorderdata.Name = "admorderdata";
            this.admorderdata.RowHeadersWidth = 51;
            this.admorderdata.RowTemplate.Height = 24;
            this.admorderdata.Size = new System.Drawing.Size(474, 150);
            this.admorderdata.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(881, 233);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // admordproduct
            // 
            this.admordproduct.AutoSize = true;
            this.admordproduct.BackColor = System.Drawing.Color.LemonChiffon;
            this.admordproduct.Font = new System.Drawing.Font("Siyam Rupali", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admordproduct.Location = new System.Drawing.Point(22, 20);
            this.admordproduct.Name = "admordproduct";
            this.admordproduct.Size = new System.Drawing.Size(320, 49);
            this.admordproduct.TabIndex = 3;
            this.admordproduct.Text = "Product Availability:";
            // 
            // Admorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectPP.Properties.Resources.OMS_for_Media_Companies_v1;
            this.ClientSize = new System.Drawing.Size(1082, 803);
            this.Controls.Add(this.admordproduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.admorderdata);
            this.Name = "Admorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admorder";
            ((System.ComponentModel.ISupportInitialize)(this.admorderdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView admorderdata;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label admordproduct;
    }
}