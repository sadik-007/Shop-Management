﻿using System;
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

        private void LoadProductsFromDatabase(string categoryFilter = null)
        {
            pnlBody.Controls.Clear();
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();

                    string query = "SELECT * FROM Product_Details";
                    if (!string.IsNullOrEmpty(categoryFilter))
                    {
                        query += " WHERE Product_type = @Category";
                    }

                    using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                    {
                        if (!string.IsNullOrEmpty(categoryFilter))
                        {
                            sqlCmd.Parameters.AddWithValue("@Category", categoryFilter);
                        }

                        using (SqlDataReader reader = sqlCmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Label noProductsLabel = new Label();
                                noProductsLabel.Text = "No products found for this category.";
                                noProductsLabel.Font = new Font("Segoe UI", 14F);
                                noProductsLabel.ForeColor = Color.Gray;
                                noProductsLabel.AutoSize = false;
                                noProductsLabel.TextAlign = ContentAlignment.MiddleCenter;
                                noProductsLabel.Size = pnlBody.Size;
                                pnlBody.Controls.Add(noProductsLabel);
                                return;
                            }

                            while (reader.Read())
                            {
                                pnlBody.Controls.Add(CreateProductCard(
                                    reader["Image"] is DBNull ? null : (byte[])reader["Image"],
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
                MessageBox.Show("Failed to load products. Error: " + ex.Message, "Database Error");
            }
        }

        // --- THIS IS THE FULL, CORRECT METHOD WITH ALL PARAMETERS ---
        private Panel CreateProductCard(byte[] imageData, string model, decimal currentPrice, decimal regularPrice, string status, string brand, string keyFeatures)
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
            else
            {
                pic.BackColor = Color.Gainsboro;
            }

            Label brandLabel = new Label { Text = brand, Font = new Font("Segoe UI", 9F), ForeColor = Color.Gray, Dock = DockStyle.Top, Padding = new Padding(10, 5, 10, 0), Height = 30 };
            Label nameLabel = new Label { Text = model, Font = new Font("Segoe UI", 10F, FontStyle.Bold), Dock = DockStyle.Top, Padding = new Padding(10, 0, 10, 5), Height = 55 };
            Label statusLabel = new Label { Text = status, Font = new Font("Segoe UI", 9F, FontStyle.Bold), Dock = DockStyle.Top, Padding = new Padding(10, 0, 10, 5), Height = 30 };
            if (status.ToLower() == "in stock") statusLabel.ForeColor = Color.Green; else statusLabel.ForeColor = Color.Red;

            Panel pricePanel = new Panel { Dock = DockStyle.Top, Height = 40, Padding = new Padding(10, 0, 10, 0) };
            Label currentPriceLabel = new Label { Text = "৳" + currentPrice.ToString("N0"), Font = new Font("Segoe UI", 12F, FontStyle.Bold), ForeColor = Color.FromArgb(0, 123, 255), Dock = DockStyle.Left, AutoSize = true };
            Label regularPriceLabel = new Label { Text = "৳" + regularPrice.ToString("N0"), Font = new Font("Segoe UI", 10F, FontStyle.Strikeout), ForeColor = Color.Gray, Dock = DockStyle.Left, AutoSize = true, Padding = new Padding(10, 3, 0, 0) };
            pricePanel.Controls.Add(regularPriceLabel);
            pricePanel.Controls.Add(currentPriceLabel);

            LinkLabel detailsLink = new LinkLabel { Text = "View Details", Dock = DockStyle.Bottom, Height = 40, Font = new Font("Segoe UI", 10F), LinkColor = Color.DodgerBlue, TextAlign = ContentAlignment.MiddleCenter, TabStop = false };
            detailsLink.LinkClicked += (s, ev) => { MessageBox.Show(keyFeatures, "Key Features: " + model); };

            card.Controls.Add(detailsLink);
            card.Controls.Add(pricePanel);
            card.Controls.Add(statusLabel);
            card.Controls.Add(nameLabel);
            card.Controls.Add(brandLabel);
            card.Controls.Add(pic);
            return card;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1("Customer"); // Default to customer, or you can bring back the role selection
            loginForm.Show();
            this.Hide();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string category = clickedButton.Text;
                LoadProductsFromDatabase(category);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search feature is coming soon.", "Search");
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Products...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search Products...";
                txtSearch.ForeColor = Color.Gray;
            }
        }
<<<<<<< HEAD

        private void customerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLoginForm("Customer");
        }

        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLog admlog = new AdminLog();
            admlog.Show();
            this.Hide();
        }

        private void salesmanLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dealerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void OpenLoginForm(string role)
        {
            MessageBox.Show(role + " login selected. Opening login page.");

            // This calls the basic Form1 without passing any information.
            // This will work with your existing Form1 and cause no errors.
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
=======
>>>>>>> 8bbd8768ba6ebebbf8082d60147ab9018198fd60
    }
}