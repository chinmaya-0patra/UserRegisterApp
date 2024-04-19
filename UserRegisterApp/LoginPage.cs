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

namespace UserRegisterApp
{
    public partial class LoginPage : Form
    {

        SqlConnection con = new SqlConnection("Data Source=CHINMAYA-PATRA\\SQLEXPRESS;Initial Catalog=RegisterForm;Integrated Security=True;TrustServerCertificate=True");
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogPage_Click(object sender, EventArgs e)
        {
            string logusername = txtLogUN.Text;
            string logpass = txtLogPass.Text;

            if(logusername != "" && logpass != "")
            {
                string selectDatacmd = "SELECT COUNT(*) FROM UserData WHERE username = '" + logusername + "' and pass = '" + logpass + "' ";
                con.Open();
                SqlCommand cmd = new SqlCommand(selectDatacmd, con);
                int rowsaffected = (int)cmd.ExecuteScalar();
                con.Close();
                if (rowsaffected != 1)
                {
                    MessageBox.Show("Invalid Username & Password");
                }
                else
                {
                    MessageBox.Show("Login Successful");

                }
            }
            else
            {
                MessageBox.Show("Username & Pass are empty");

            }

        }
    }
}
