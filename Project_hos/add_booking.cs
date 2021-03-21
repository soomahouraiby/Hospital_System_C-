using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data;

namespace Project_hos
{
    public partial class add_booking : Form
    {
         Class_DB db;
        DataSet ds,ds2,ds3;
        public add_booking()
        {
            InitializeComponent();
        }

        private void add_booking_Load(object sender, EventArgs e)
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

        

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            //save
            string query = "insert into booking ([doctor_name],[patient_name],[date_booking],[time_booking],[required_pay]) values('" + comboBoxD_name.Text + "','" + comboBoxP_name.Text + "','" + dateTimePickerDate.Text + "','" + maskedTextBoxTime.Text + "','" + comboBoxPay.Text + "')";
            db.Insert_Update_deleteDB(query);
            MessageBox.Show("Your Data Saved ");
        }
       

        

         private void buttonUpdate_Click_1(object sender, EventArgs e)
         {
             //update
             string query = "update booking set doctor_name='" + comboBoxD_name.Text + "', set patient_name='" + comboBoxP_name.Text + "' , set date_booking='" + dateTimePickerDate.Text + "' ,set time_booking='" + maskedTextBoxTime.Text + "' , set required_pay='" + comboBoxPay.Text + "' where booking_id=" + Convert.ToInt16(textBoxB_id.Text);
             db.Insert_Update_deleteDB(query);
             MessageBox.Show("Your Data Updated ");
         }
         private void buttonDelete_Click(object sender, EventArgs e)
        {//delete
         if (MessageBox.Show("Are you sure You want to delete the recored", "Delet booking", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {

                string query = "delete from booking where booking_id=" + Convert.ToInt16(textBoxB_id.Text);
                db.Insert_Update_deleteDB(query);
                MessageBox.Show("Your Data Deleted ");
            }
        }

         private void buttonRefrech_Click(object sender, EventArgs e)
         {//refrech
             ds = db.selectdb("select * from booking", "booking");
             dataGridView1.DataSource = null;
             dataGridView1.DataSource = ds;
             dataGridView1.DataMember = "booking";
         }

         
         private void buttonAdd_booking_Click_1(object sender, EventArgs e)
         {
             add_booking f = new add_booking();
             f.Show();
             this.Hide();
         }

        
         private void buttonAdd_patient_Click_1(object sender, EventArgs e)
         {
             add_patient f = new add_patient();
             f.Show();
             this.Hide();
         }
        
         private void buttonAdd_doctor_Click_1(object sender, EventArgs e)
         {
             add_doctor f = new add_doctor();
             f.Show();
             this.Hide();
         }

         
         private void buttonAdd_file_Click_1(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {//new
            BindingContext[ds, "booking"].AddNew();
            
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {//>>
            this.BindingContext[ds, "booking"].Position -= 1; 
        }

        private void buttonFristOne_Click(object sender, EventArgs e)
        {//|>>
            this.BindingContext[ds, "booking"].Position = 0;
        }

        private void buttonLastone_Click(object sender, EventArgs e)
        {//<<|
            this.BindingContext[ds, "booking"].Position = this.BindingContext[ds, "booking"].Count - 1;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {//<<
            this.BindingContext[ds, "booking"].Position += 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

       

       
       

       

       

       

       

        

       

       

        
    }
}
