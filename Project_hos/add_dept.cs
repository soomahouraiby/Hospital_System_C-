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
    public partial class add_dept : Form
    {
        Class_DB db;
        DataSet ds;
        public add_dept()
        {
            InitializeComponent();
        }

        private void add_dept_Load(object sender, EventArgs e)
        {
            db = new Class_DB();
            db.ConnectDB();
            ds = new DataSet();


            ds = db.selectdb("select * from dept ", "dept");
            textBoxid.DataBindings.Add("Text", ds, "dept.dept_id");
            textBoxname.DataBindings.Add("Text", ds, "dept.dept_name");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "dept";
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
            this.BindingContext[ds, "booking"].Position -= 1; 
        }

        private void buttonFristOne_Click(object sender, EventArgs e)
        {
            //|>>
            this.BindingContext[ds, "booking"].Position = 0;
        }

        private void buttonLastone_Click(object sender, EventArgs e)
        {
            //<<|
            this.BindingContext[ds, "booking"].Position = this.BindingContext[ds, "booking"].Count - 1;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //<<
            this.BindingContext[ds, "booking"].Position += 1;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            //new
            BindingContext[ds, "dept"].AddNew();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //save
            string query = "insert into dept ([dept_name]) values('" + textBoxname.Text + "')";
            db.Insert_Update_deleteDB(query);
            MessageBox.Show("Your Data Saved ");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //update
            string query = "update dept set dept_name='" + textBoxname.Text + "' where dept_id=" + Convert.ToInt16(textBoxid.Text);
            db.Insert_Update_deleteDB(query);
            MessageBox.Show("Your Data Updated ");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //delete
            if (MessageBox.Show("Are you sure You want to delete the recored", "Delet dept", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {

                string query = "delete from booking where dept_id=" + Convert.ToInt16(textBoxid.Text);
                db.Insert_Update_deleteDB(query);
                MessageBox.Show("Your Data Deleted ");
            }
        }

        private void buttonRefrech_Click(object sender, EventArgs e)
        {
            //refrech
            ds = db.selectdb("select * from dept", "dept");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "dept";
        }
    }
}
