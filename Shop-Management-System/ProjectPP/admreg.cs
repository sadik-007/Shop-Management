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
    public partial class admreg: Form
    {
        public admreg()
        {
            InitializeComponent();
        }

        private void admreg_Load(object sender, EventArgs e)
        {

        }

        private void regback_Click(object sender, EventArgs e)
        {
            Starting starting = new Starting();
            starting.Show();
            this.Hide();

        }

        private void regregister_Click(object sender, EventArgs e)
        {

            AdminLog admlog = new AdminLog();
            admlog.Show();
            this.Hide();
        }

        private void admnewacc_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void reggmail_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void admreguser_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void regpass_Click(object sender, EventArgs e)
        {

        }

        private void regdob_Click(object sender, EventArgs e)
        {

        }

        private void admreggmail_Click(object sender, EventArgs e)
        {

        }

        private void admregusername_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
