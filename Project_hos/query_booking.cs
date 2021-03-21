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
    public partial class query_booking : Form
    {
        Class_DB db;
        DataSet ds, ds2, ds3;
        public query_booking()
        {
            InitializeComponent();
        }

        private void query_booking_Load(object sender, EventArgs e)
        {
            db = new Class_DB();
            db.ConnectDB();
            ds = new DataSet();
            ds2 = new DataSet();

            ds = db.selectdb("select * from booking ", "booking");
            textBoxB_id.DataBindings.Add("Text", ds, "booking.booking_id");
            dateTimePickerDate.DataBindings.Add("Value", ds, "booking.date_booking");
            maskedTextBoxTime.DataBindings.Add("Text", ds, "booking.time_booking");
            comboBoxPay.DataBindings.Add("Text", ds, "booking.required_pay");


            ds2 = db.selectdb("select * from doctor ", "doctor");
            comboBoxD_name.DataSource = ds2;
            comboBoxD_name.DisplayMember = "doctor.doctor_name";
            comboBoxD_name.ValueMember = "doctor.doctor_id";
            //  comboBox2.DataBindings.Add("Text", ds, "booking.doctor_name");

            ds3 = db.selectdb("select * from patient", "patient");
            comboBoxP_name.DataSource = ds3;
            comboBoxP_name.DisplayMember = "patient.patient_name";
            comboBoxP_name.ValueMember = "patient.patient_id";
            // comboBox3.ValueMember = "patient.patient_id";


            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "booking";
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

        private void buttonQuery_doctor_Click(object sender, EventArgs e)
        {
            query_doctor f = new query_doctor();
            f.Show();
            this.Hide();
        }

        private void buttonQuery_dept_Click(object sender, EventArgs e)
        {
            query_dept f = new query_dept();
            f.Show();
            this.Hide();
        }



    }
}
