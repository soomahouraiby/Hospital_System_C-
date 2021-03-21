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
    public partial class add_doctor : Form
    {
        Class_DB db;
        DataSet ds, ds2;
        public add_doctor()
        {
            InitializeComponent();
        }

        private void query_patient_Load(object sender, EventArgs e)
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

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            //>>
            this.BindingContext[ds, "doctor"].Position -= 1;
        }

        private void buttonFristOne_Click(object sender, EventArgs e)
        {
            //|>>
            this.BindingContext[ds, "doctor"].Position = 0;
        }

        private void buttonLastone_Click(object sender, EventArgs e)
        {
            //<<|
            this.BindingContext[ds, "doctor"].Position = this.BindingContext[ds, "patient"].Count - 1;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //<<
            this.BindingContext[ds, "doctor"].Position += 1;
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

        private void buttonNew_Click(object sender, EventArgs e)
        {
            //new
            BindingContext[ds, "doctor"].AddNew();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //save
            string query = "insert into doctor ([doctor_name],[dept_id],[major],[identity_no],[phone_no],[email],[street],[day_work],[time_work]) values('" + textBoxd_name.Text + "','" + comboBoxdp_id.Text + "','" + textBoxmajor.Text + "','" + maskedTextBoxidt_no.Text + "','" + maskedTextBoxphone.Text + "','" + textBoxemail.Text + "','" + textBoxstreet.Text + "','" + checkedListBoxday.Text + "' ,'" + maskedTextBoxtime.Text + "')";
            db.Insert_Update_deleteDB(query);
            MessageBox.Show("Your Data Saved ");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //update
            string query = "update doctor set doctor_name='" + textBoxd_name.Text + "', set dept_id='" + comboBoxdp_id.Text + "' , set major='" + textBoxmajor.Text + "' , set identity_no='" + maskedTextBoxidt_no.Text + "' , set phone_no='" + maskedTextBoxphone.Text + "',set email='" + textBoxemail.Text + "' , set street='" + textBoxstreet.Text + "',set day_work='" + checkedListBoxday.Text + "' , set time_work='" + maskedTextBoxtime.Text + "' where doctor_id=" + Convert.ToInt16(textBoxd_id.Text);
            db.Insert_Update_deleteDB(query);
            MessageBox.Show("Your Data Updated ");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //delete
            if (MessageBox.Show("Are you sure You want to delete the recored", "Delet doctor", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {

                string query = "delete from doctor where doctor_id=" + Convert.ToInt16(textBoxd_id.Text);
                db.Insert_Update_deleteDB(query);
                MessageBox.Show("Your Data Deleted ");
            }
        }

        private void buttonRefrech_Click(object sender, EventArgs e)
        {
            //refrech
            ds = db.selectdb("select * from doctor", "doctor");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "doctor";
        }
    }
}
