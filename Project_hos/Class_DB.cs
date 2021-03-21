using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Project_hos
{
    class Class_DB
    {
        SqlConnection con;
        string path = System.Windows.Forms.Application.StartupPath;
        public void ConnectDB()
        {
            string subPath = path.Substring(0, path.LastIndexOf(@"\bin") + 1);
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + subPath + "hospital.mdf;Integrated Security=True";

        }
        public DataSet selectdb(string qurey, string TableName)
        {
            SqlDataAdapter dp = new SqlDataAdapter(qurey, con);
            DataSet ds = new DataSet();
            con.Open();
            dp.Fill(ds,TableName);
            con.Close();
            return ds;
        }
        public void Insert_Update_deleteDB(string Query)
        {

            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = Query;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();



        }
        ////public DataSet SelectDB(string Query,string TableName)
        //        {
        //            try
        //            {
        //                SqlDataAdapter adpat = new SqlDataAdapter(Query, con);

        //                ds = new DataSet();

        //                con.Open();
        //                adpat.Fill(ds, TableName);

        //                con.Close();

        //            }
        //            catch (Exception Error)
        //            {
        //                MessageBox.Show(Error.Message);
        //            }
        //            return ds;
        //        }
    }
}
