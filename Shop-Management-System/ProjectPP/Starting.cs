using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class Starting : Form
    {
        public Starting()
        {
            InitializeComponent();
        }

        private void Starting_Load(object sender, EventArgs e)
        {
            LoadProductPlaceholders();
        }

        private void LoadProductPlaceholders()
        {
            string[] productNames = { "Gaming Laptop", "Smart Watch", "Latest Phone", "Pro Tablet", "DSLR Camera", "4K Smart TV", "Wireless Mouse", "Mechanical Keyboard" };
            foreach (var name in productNames)
            {
                pnlBody.Controls.Add(CreateProductCard(name));
            }
        }

        private Panel CreateProductCard(string productName)
        {
            Panel card = new Panel
            {
                Width = 250,
                Height = 300,
                BackColor = Color.White,
                Margin = new Padding(15),
                BorderStyle = BorderStyle.FixedSingle
            };

            PictureBox pic = new PictureBox
            {
                BackColor = Color.Gainsboro,
                Dock = DockStyle.Top,
                Height = 170,
                SizeMode = PictureBoxSizeMode.Zoom,
            };

            Label nameLabel = new Label
            {
                Text = productName,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Dock = DockStyle.Top,
                Padding = new Padding(10, 5, 10, 5),
                Height = 60,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label priceLabel = new Label
            {
                Text = "Apnar jonno Free",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                ForeColor = Color.FromArgb(0, 123, 255),
                Dock = DockStyle.Bottom,
                Padding = new Padding(10, 5, 10, 10),
                Height = 40,
                TextAlign = ContentAlignment.MiddleLeft
            };

            card.Controls.Add(priceLabel);
            card.Controls.Add(nameLabel);
            card.Controls.Add(pic);
            return card;
        }

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

        private void Category_Click(object sender, EventArgs e) { }

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

        private void customerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLoginForm("Customer");
        }

        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLoginForm("Admin");
        }

        private void salesmanLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLoginForm("Salesman");
        }

        private void dealerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLoginForm("Dealer");
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
    }
}