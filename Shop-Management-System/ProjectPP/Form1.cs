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

namespace ProjectPP
{
    public partial class Form1 : Form
    {
        private string _userRole;

        public Form1(string userRole = "Customer")
        {
            InitializeComponent();
            _userRole = userRole;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = _userRole + " Log In";
            this.label1.Text = _userRole + " Log In";

            if (_userRole != "Customer")
            {
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset resetForm = new Reset();
            resetForm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 registrationForm = new Form2();
            registrationForm.Show();
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tableName = "";
            switch (_userRole)
            {
                case "Customer":
                    tableName = "Customer";
                    break;
                case "Admin":
                    tableName = "Admins";
                    break;
                case "Salesman":
                    tableName = "Salesmen";
                    break;
                case "Dealer":
                    tableName = "Dealers";
                    break;
                default:
                    MessageBox.Show("Invalid user role specified.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = $"SELECT COUNT(1) FROM {tableName} WHERE User_Name=@Username AND Password=@Password";

                    using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                    {
                        sqlCmd.Parameters.AddWithValue("@Username", username);
                        sqlCmd.Parameters.AddWithValue("@Password", password);
                        int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show(_userRole + " Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password for this role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A database error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        // --- NEW METHOD FOR THE "BACK TO HOMEPAGE" LINK ---
        private void linkBackToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Find the existing Starting page that is hidden
            Starting startingForm = Application.OpenForms.OfType<Starting>().FirstOrDefault();

            // If we found it, show it. Otherwise, create a new one as a backup.
            if (startingForm != null)
            {
                startingForm.Show();
            }
            else
            {
                startingForm = new Starting();
                startingForm.Show();
            }

            // Close the current login form
            this.Close();
        }
    }
}