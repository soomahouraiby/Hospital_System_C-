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
    public partial class add_patient : Form
    {
        Class_DB db;
        DataSet ds;
        public add_patient()
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

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            //>>
            this.BindingContext[ds, "patient"].Position -= 1;
        }

        private void buttonFristOne_Click(object sender, EventArgs e)
        {
            //|>>
            this.BindingContext[ds, "patient"].Position = 0;
        }

        private void buttonLastone_Click(object sender, EventArgs e)
        {
            //<<|
            this.BindingContext[ds, "patient"].Position = this.BindingContext[ds, "patient"].Count - 1;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //<<
            this.BindingContext[ds, "patient"].Position += 1;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            //new
            BindingContext[ds, "patient"].AddNew();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //save
         //   string query = "insert into patient ([patient_name],[sex],[age],[identity_no],[phone_no],[email],[street]) values('" + textBox2.Text + "','" + this.GetSelectedRadioButtonText(new[] { radioButton1, radioButton1 }) + "','" + maskedTextBox1.Text + "','" + maskedTextBox3.Text + "','" + maskedTextBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
         //   db.Insert_Update_deleteDB(query);
            MessageBox.Show("Your Data Saved ");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //update


            if (radioButton1.Checked == true)
            {
                label3.Text = "Male";
            }
            if (radioButton2.Checked == true)
            {
                label3.Text = "Female";
            }
            string query = "update patient set patient_name='" + textBox2.Text + "', set sex='" + label3.Text + "' , set age='" + maskedTextBox1.Text + "' ,set identity_no='" + maskedTextBox3.Text + "' , set phone_no='" + maskedTextBox2.Text + "', set email='" + textBox3.Text + "', set street='" + textBox4.Text + "' where patient_id=" + Convert.ToInt16(textBox1.Text);

            db.Insert_Update_deleteDB(query);
            MessageBox.Show("Your Data Updated ");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {//delete
            if (MessageBox.Show("Are you sure You want to delete the recored", "Delet Patient", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                string query = "delete from patient where patient_id=" + Convert.ToInt16(textBox1.Text);
                db.Insert_Update_deleteDB(query);
                MessageBox.Show("Your Data Deleted ");
            }
        }

        private void add_patient_Load(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void buttonRefrech_Click(object sender, EventArgs e)
        {//refrech
            ds = db.selectdb("select * from patient", "patient");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "patient";
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //private void buttonAdd_doctor_Click(object sender, EventArgs e)
        //{

        //} 
    }
}
