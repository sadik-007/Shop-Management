namespace ProjectPP
{
    partial class CustomerHomePage
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblShopName = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnWatch = new System.Windows.Forms.Button();
            this.btnPhone = new System.Windows.Forms.Button();
            this.btnTablet = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.btnTV = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblWelcomeUser);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.lblShopName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1282, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcomeUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblWelcomeUser.Location = new System.Drawing.Point(940, 28);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(330, 28);
            this.lblWelcomeUser.TabIndex = 3;
            this.lblWelcomeUser.Text = "👤 Welcome, User";
            this.lblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(880, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "🔍";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(350, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(531, 38);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search Products...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblShopName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblShopName.Location = new System.Drawing.Point(25, 17);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(164, 45);
            this.lblShopName.TabIndex = 0;
            this.lblShopName.Text = "Tech Hub";
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 130);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(20);
            this.pnlBody.Size = new System.Drawing.Size(1282, 573);
            this.pnlBody.TabIndex = 2;
            // 
            // pnlCategories
            // 
            this.pnlCategories.BackColor = System.Drawing.Color.White;
            this.pnlCategories.Controls.Add(this.btnComputer);
            this.pnlCategories.Controls.Add(this.btnWatch);
            this.pnlCategories.Controls.Add(this.btnPhone);
            this.pnlCategories.Controls.Add(this.btnTablet);
            this.pnlCategories.Controls.Add(this.btnCamera);
            this.pnlCategories.Controls.Add(this.btnTV);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategories.Location = new System.Drawing.Point(0, 80);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Padding = new System.Windows.Forms.Padding(25, 6, 20, 5);
            this.pnlCategories.Size = new System.Drawing.Size(1282, 50);
            this.pnlCategories.TabIndex = 3;
            // 
            // btnComputer
            // 
            this.btnComputer.FlatAppearance.BorderSize = 0;
            this.btnComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputer.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnComputer.Location = new System.Drawing.Point(30, 9);
            this.btnComputer.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(110, 35);
            this.btnComputer.TabIndex = 0;
            this.btnComputer.Text = "Computer";
            this.btnComputer.UseVisualStyleBackColor = true;
            this.btnComputer.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnWatch
            // 
            this.btnWatch.FlatAppearance.BorderSize = 0;
            this.btnWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatch.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnWatch.Location = new System.Drawing.Point(150, 9);
            this.btnWatch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(89, 35);
            this.btnWatch.TabIndex = 1;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnPhone
            // 
            this.btnPhone.FlatAppearance.BorderSize = 0;
            this.btnPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnPhone.Location = new System.Drawing.Point(249, 9);
            this.btnPhone.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(79, 35);
            this.btnPhone.TabIndex = 2;
            this.btnPhone.Text = "Phone";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnTablet
            // 
            this.btnTablet.FlatAppearance.BorderSize = 0;
            this.btnTablet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablet.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnTablet.Location = new System.Drawing.Point(338, 9);
            this.btnTablet.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnTablet.Name = "btnTablet";
            this.btnTablet.Size = new System.Drawing.Size(86, 41);
            this.btnTablet.TabIndex = 3;
            this.btnTablet.Text = "Tablet";
            this.btnTablet.UseVisualStyleBackColor = true;
            this.btnTablet.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.FlatAppearance.BorderSize = 0;
            this.btnCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamera.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCamera.Location = new System.Drawing.Point(434, 9);
            this.btnCamera.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(85, 35);
            this.btnCamera.TabIndex = 4;
            this.btnCamera.Text = "Camera";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnTV
            // 
            this.btnTV.FlatAppearance.BorderSize = 0;
            this.btnTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTV.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnTV.Location = new System.Drawing.Point(529, 9);
            this.btnTV.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(56, 35);
            this.btnTV.TabIndex = 5;
            this.btnTV.Text = "TV";
            this.btnTV.UseVisualStyleBackColor = true;
            this.btnTV.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlCategories);
            this.Controls.Add(this.pnlHeader);
            this.Name = "CustomerHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Hub - Welcome";
            this.Load += new System.EventHandler(this.CustomerHomePage_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCategories.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel pnlBody;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.FlowLayoutPanel pnlCategories;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Button btnTablet;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Button btnTV;
    }
}