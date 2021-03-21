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
    public partial class add_patient1 : Form
    {
        public add_patient1()
        {
            InitializeComponent();
        }

        private void buttonQuery_dept_Click(object sender, EventArgs e)
        {
            query_dept f = new query_dept();
            f.Show();
            this.Hide();
        }

        private void buttonAdd_booking_Click(object sender, EventArgs e)
        {
            add_booking1 f = new add_booking1();
            f.Show();
            this.Hide();
        }

        private void buttonAdd_patient_Click(object sender, EventArgs e)
        {
            add_patient1 f = new add_patient1();
            f.Show();
            this.Hide();
        }

        private void buttonQuery_doctor_Click(object sender, EventArgs e)
        {
            query_doctor f = new query_doctor();
            f.Show();
            this.Hide();
        }
    }
}
