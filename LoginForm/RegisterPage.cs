using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LoginForm
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            Fuction Func = new Fuction();
            
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;
            string t4 = textBox4.Text;
            string query = "Insert into Users (RegisterId,Fullname,Username,Password) Values(" + t1 +","+t2+","+ t3 +"," +
                t4+")";
            Func.SetData(query);

            //SqlCommand insertCommand = new SqlCommand(query);
            //insertCommand.Parameters.AddWithValue("@reg", textBox1.Text);
            //insertCommand.Parameters.AddWithValue("@fn", textBox2.Text);
            //insertCommand.Parameters.AddWithValue("@un", textBox3.Text);
            //insertCommand.Parameters.AddWithValue("@pwd", textBox4.Text);
            //insertCommand.ExecuteNonQuery();
        }
    }
}
