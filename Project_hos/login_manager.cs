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
    public partial class login_manager : Form
    {
        public login_manager()
        {
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (textBoxname.Text != "" && textBoxid.Text != "")
            {
                Class_DB db = new Class_DB();
                db.ConnectDB();
                DataSet ds = new DataSet();
                ds = db.selectdb("Select * from [user] where user_name='" + textBoxname.Text + "' and password='" + textBoxid.Text + "'", "User");

                if (ds.Tables["User"].Rows.Count >= 1)
                {
                      welcome_manager f = new welcome_manager();
                    f.Show();
                    this.Hide();
                }
                else
                {

                    label4.Text = "your Name or your Password not Vaild";
                }

            }
            else
            {
                label4.Text = "your must Enter your Name and your Password";
            }
        }

       
        
        private void login_manager_Load(object sender, EventArgs e)
        {

        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            welcome_manager f = new welcome_manager();
            f.Show();
            this.Hide();
        }

        private void buttonclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
