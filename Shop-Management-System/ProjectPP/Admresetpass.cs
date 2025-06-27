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
    public partial class Admresetpass: Form
    {
        public Admresetpass()
        {
            InitializeComponent();
        }

        private void resback_Click(object sender, EventArgs e)
        {

            AdminLog admlog = new AdminLog();
            admlog.Show();
            this.Hide();
        }
    }
}
