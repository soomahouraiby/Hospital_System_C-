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
    public partial class welcome_manager : Form
    {
        public welcome_manager()
        {
            InitializeComponent();
        }

  

        private void buttonAdd_booking_Click(object sender, EventArgs e)
        {
            add_booking f = new add_booking();
            f.Show();
            this.Hide();
        }

        private void buttonAdd_patient_Click(object sender, EventArgs e)
        {
            add_patient f = new add_patient();
            f.Show();
            this.Hide();
        }

        private void buttonAdd_doctor_Click(object sender, EventArgs e)
        {
            add_doctor f = new add_doctor();
            f.Show();
            this.Hide();
        }

        private void buttonAdd_file_Click(object sender, EventArgs e)
        {
            add_file f = new add_file();
            f.Show();
            this.Hide();
        }

        private void buttonAdd_dept_Click(object sender, EventArgs e)
        {
            add_dept f = new add_dept();
            f.Show();
            this.Hide();
        }
    }
}
