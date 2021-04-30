using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isValid()
        {
            if (usernamebox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("username cannot be empty");
                return false;
            }
            if (passwordbox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("password cannont be empty");
                return false;
            }
            return true;
        }

        public void loginbtn_Click(object sender, EventArgs e)
        {


            if (isValid())
            {


                SqlConnection con = new SqlConnection();
                //String V = "Data Source = (local)/Databases;Initial Catalog=Restro;integrated security = True";
                con.ConnectionString = @"Data Source =DESKTOP-36T64TV\SQLEXPRESS;Initial Catalog=PracticeDB;User ID=sa;Password=1";


                string query = "SELECT * FROM LoginTable where Username = '" + usernamebox.Text.Trim() + "' and Password = '" + passwordbox.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dta = new DataTable();
                sda.Fill(dta);

                if (dta.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful");
                    Dashboard objDashBoard = new Dashboard();
                    this.Hide();
                    objDashBoard.Show();

                }
                else
                {
                    MessageBox.Show("Check your username and password");
                }

                //Fuction Func = new Fuction();
                //string query = "SELECT * FROM LoginTable";
                //DataSet data = new DataSet();

                //data = Func.GetData(query);
                //DataRow drow = data.Tables[0].Rows[0];
                //string str = drow.ItemArray.GetValue(0).ToString();
                //MessageBox.Show(str);
                //Dashboard objDashBoard = new Dashboard();
                //this.Hide();
                //objDashBoard.Show();


            }
        
        

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            RegisterPage objRegisterpage = new RegisterPage();
            this.Hide();
            objRegisterpage.Show();
        }

        
    }
}

