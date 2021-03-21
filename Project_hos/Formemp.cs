using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_hos
{
    public partial class Formemp : Form
    {
        public Formemp()
        {
            InitializeComponent();
        }

        private void buttonmanger_Click(object sender, EventArgs e)
        {
            login_manger f = new login_manger();
            f.Show();
            this.Hide();
        }

        private void buttonemp_Click(object sender, EventArgs e)
        {
            login_emp f = new login_emp();
            f.Show();
            this.Hide();
        }

        private void buttondoctor_Click(object sender, EventArgs e)
        {
            login_doctor f = new login_doctor();
            f.Show();
            this.Hide();
        }
    }
}
