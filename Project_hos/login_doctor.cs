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
    public partial class login_doctor : Form
    {
        public login_doctor()
        {
            InitializeComponent();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Formemp f = new Formemp();
            f.Show();
            this.Hide();
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            Class_DB db = new Class_DB();
                db.ConnectDB();
                DataSet ds = new DataSet();
                ds = db.selectdb("Select * from [user] where username='" + textBoxname.Text + "' and password='" + textBoxpass.Text + "'", "user");

                if (ds.Tables["user"].Rows.Count >= 1)
                {
                    welcome_doctor f = new welcome_doctor();
                    f.Show();
                    this.Hide();
                }
                else
                {

                    label4.Text = "your Name or your Password not Vaild";
                }

            }
            
        }
    }

