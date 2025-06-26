using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ProjectPP
{
    public partial class Starting : Form
    {
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

        public Starting()
        {
            InitializeComponent();
        }

        private void Starting_Load(object sender, EventArgs e)
        {
            LoadProductsFromDatabase();
        }

        private void LoadProductsFromDatabase()
        {
            pnlBody.Controls.Clear();
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "SELECT Product_code, Image, Model, Current_Price, Regular_Price, Status, Brand_name, Key_Features FROM Product_Details";

                    using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                    {
                        using (SqlDataReader reader = sqlCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                pnlBody.Controls.Add(CreateProductCard(
                                    reader["Product_code"].ToString(),
                                    reader["Image"] as byte[],
                                    reader["Model"].ToString(),
                                    Convert.ToDecimal(reader["Current_Price"]),
                                    Convert.ToDecimal(reader["Regular_Price"]),
                                    reader["Status"].ToString(),
                                    reader["Brand_name"].ToString(),
                                    reader["Key_Features"].ToString()
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products from the database. \nError: " + ex.Message, "Database Error");
            }
        }

        private Panel CreateProductCard(string productCode, byte[] imageData, string model, decimal currentPrice, decimal regularPrice, string status, string brand, string keyFeatures)
        {
            Panel card = new Panel
            {
                Width = 260,
                Height = 360,
                BackColor = Color.White,
                Margin = new Padding(15),
                BorderStyle = BorderStyle.FixedSingle
            };

            PictureBox pic = new PictureBox
            {
                Dock = DockStyle.Top,
                Height = 150,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData)) { pic.Image = Image.FromStream(ms); }
            }
            else { pic.BackColor = Color.Gainsboro; }

            Label brandLabel = new Label { Text = brand, Font = new Font("Segoe UI", 9F, FontStyle.Regular), ForeColor = Color.Gray, Dock = DockStyle.Top, Padding = new Padding(10, 5, 10, 0), Height = 30 };

            Label nameLabel = new Label { Text = model, Font = new Font("Segoe UI", 10F, FontStyle.Bold), Dock = DockStyle.Top, Padding = new Padding(10, 0, 10, 5), Height = 55 };

            Label statusLabel = new Label { Text = status, Font = new Font("Segoe UI", 9F, FontStyle.Bold), Dock = DockStyle.Top, Padding = new Padding(10, 0, 10, 5), Height = 30 };
            if (status.ToLower() == "in stock") statusLabel.ForeColor = Color.Green; else statusLabel.ForeColor = Color.Red;

            Panel pricePanel = new Panel { Dock = DockStyle.Top, Height = 40, Padding = new Padding(10, 0, 10, 0) };
            Label currentPriceLabel = new Label { Text = "৳" + currentPrice.ToString("N0"), Font = new Font("Segoe UI", 12F, FontStyle.Bold), ForeColor = Color.FromArgb(0, 123, 255), Dock = DockStyle.Left, AutoSize = true };
            Label regularPriceLabel = new Label { Text = "৳" + regularPrice.ToString("N0"), Font = new Font("Segoe UI", 10F, FontStyle.Strikeout), ForeColor = Color.Gray, Dock = DockStyle.Left, AutoSize = true, Padding = new Padding(10, 3, 0, 0) };
            pricePanel.Controls.Add(regularPriceLabel);
            pricePanel.Controls.Add(currentPriceLabel);

            LinkLabel detailsLink = new LinkLabel
            {
                Text = "View Details",
                Dock = DockStyle.Bottom,
                Height = 40,
                Font = new Font("Segoe UI", 10F),
                LinkColor = Color.DodgerBlue,
                TextAlign = ContentAlignment.MiddleCenter,
                TabStop = false
            };
            detailsLink.LinkClicked += (sender, e) => {
                MessageBox.Show(keyFeatures, "Key Features: " + model);
            };

            card.Controls.Add(detailsLink);
            card.Controls.Add(pricePanel);
            card.Controls.Add(statusLabel);
            card.Controls.Add(nameLabel);
            card.Controls.Add(brandLabel);
            card.Controls.Add(pic);
            return card;
        }

        // --- The rest of the file is unchanged ---
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Search Products...")
            {
                MessageBox.Show("Searching for: " + txtSearch.Text, "Search Initiated");
            }
            else
            {
                MessageBox.Show("Please enter a product to search for.", "Search");
            }
        }
        private void Category_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            MessageBox.Show("Category clicked: " + clickedItem.Text);
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Products...") { txtSearch.Text = ""; txtSearch.ForeColor = Color.Black; }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) { txtSearch.Text = "Search Products..."; txtSearch.ForeColor = Color.Gray; }
        }
        private void customerLoginToolStripMenuItem_Click(object sender, EventArgs e) { OpenLoginForm("Customer"); }
        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e) { OpenLoginForm("Admin"); }
        private void salesmanLoginToolStripMenuItem_Click(object sender, EventArgs e) { OpenLoginForm("Salesman"); }
        private void dealerLoginToolStripMenuItem_Click(object sender, EventArgs e) { OpenLoginForm("Dealer"); }
        private void OpenLoginForm(string role)
        {
            Form1 loginForm = new Form1(role);
            loginForm.Show();
            this.Hide();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e) { }
    }
}