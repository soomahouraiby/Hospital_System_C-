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
    public partial class query_doctor : Form
    {
        Class_DB db;
        DataSet ds, ds2;
        public query_doctor()
        {
            InitializeComponent();
        }

        

        private void buttonAdd_booking_Click(object sender, EventArgs e)
        {
            add_booking1 f = new add_booking1();
            f.Show();
            this.Hide();
        }


       
        private void buttonAdd_patient_Click_1(object sender, EventArgs e)
        {
            add_patient1 f = new add_patient1();
            f.Show();
            this.Hide();
        }

        private void buttonQuery_doctor_Click_1(object sender, EventArgs e)
        {
            query_doctor f = new query_doctor();
            f.Show();
            this.Hide();
        }

        private void buttonQuery_dept_Click_1(object sender, EventArgs e)
        {
            query_dept f = new query_dept();
            f.Show();
            this.Hide();
        }

        private void query_doctor_Load(object sender, EventArgs e)
        {
            db = new Class_DB();
            db.ConnectDB();
            ds = new DataSet();
            ds2 = new DataSet();
            ds = db.selectdb("select * from doctor ", "doctor");

            textBoxd_id.DataBindings.Add("Text", ds, "doctor.doctor_id");
            textBoxd_name.DataBindings.Add("Text", ds, "doctor.doctor_name");
            // comboBoxdp_id.DataBindings.Add("Text", ds, "doctor.dept_id");
            textBoxmajor.DataBindings.Add("Text", ds, "doctor.major");
            maskedTextBoxidt_no.DataBindings.Add("Text", ds, "doctor.identity_no");
            maskedTextBoxphone.DataBindings.Add("Text", ds, "doctor.phone_no");
            textBoxemail.DataBindings.Add("Text", ds, "doctor.email");
            textBoxstreet.DataBindings.Add("Text", ds, "doctor.street");
            checkedListBoxday.DataBindings.Add("Text", ds, "doctor.day_work");
            maskedTextBoxtime.DataBindings.Add("Text", ds, "doctor.time_work");

            ds2 = db.selectdb("select * from dept", "dept");
            comboBoxdp_id.DataSource = ds2;
            comboBoxdp_id.DisplayMember = "dept.dept_name";
            comboBoxdp_id.ValueMember = "dept.dept_id";


            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "doctor";
        }
    }
}
