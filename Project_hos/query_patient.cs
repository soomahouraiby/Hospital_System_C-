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
    public partial class query_patient : Form
    {
        Class_DB db;
        DataSet ds;
        public query_patient()
        {
            InitializeComponent();
        }

            

        private void query_patient_Load(object sender, EventArgs e)
        {
            db = new Class_DB();
            db.ConnectDB();
            ds = new DataSet();

            ds = db.selectdb("select * from patient ", "patient");

            textBox1.DataBindings.Add("Text", ds, "patient.patient_id");
            textBox2.DataBindings.Add("Text", ds, "patient.patient_name");
            label3.DataBindings.Add("Text", ds, "patient.sex");
            maskedTextBox1.DataBindings.Add("Text", ds, "patient.age");
            maskedTextBox3.DataBindings.Add("Text", ds, "patient.identity_no");
            maskedTextBox2.DataBindings.Add("Text", ds, "patient.phone_no");
            textBox3.DataBindings.Add("Text", ds, "patient.email");
            textBox4.DataBindings.Add("Text", ds, "patient.street");


            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "patient";
        }

        private void buttonQuery_booking_Click(object sender, EventArgs e)
        {
            query_booking f = new query_booking();
            f.Show();
            this.Hide();
        }

        private void buttonQuery_patient_Click(object sender, EventArgs e)
        {
            query_patient f = new query_patient();
            f.Show();
            this.Hide();
        }

        private void buttonAdd_file_Click(object sender, EventArgs e)
        {
            add_file f = new add_file();
            f.Show();
            this.Hide();
        }
    }
}
