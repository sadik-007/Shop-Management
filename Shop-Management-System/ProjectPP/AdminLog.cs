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
    public partial class AdminLog: Form
    {
        public AdminLog()
        {
            InitializeComponent();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admlogusername_Click(object sender, EventArgs e)
        {

        }

        private void admlogforgotpass_Click(object sender, EventArgs e)
        {

            Admresetpass admres = new Admresetpass();
            admres.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminLog_Load(object sender, EventArgs e)
        {
           
        }

        private void admloggreg_Click(object sender, EventArgs e)
        {
            admreg Admreg = new admreg();
            Admreg.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = false;   
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void admloglogin_Click(object sender, EventArgs e)
        {
          

                }
              
            

          


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

        }
    

