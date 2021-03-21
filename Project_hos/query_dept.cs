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
    public partial class query_dept : Form
    {
        Class_DB db;
        DataSet ds;
        public query_dept()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void query_dept_Load(object sender, EventArgs e)
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
    }
}
