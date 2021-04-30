using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LoginForm
{
    class Fuction
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            //String V = "Data Source = (local)/Databases;Initial Catalog=Restro;integrated security = True";
            con.ConnectionString = @"Data Source =DESKTOP-36T64TV\SQLEXPRESS;Initial Catalog=PracticeDB;User ID=sa;Password=1";
            return con;
        }
        public DataSet GetData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public void SetData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
