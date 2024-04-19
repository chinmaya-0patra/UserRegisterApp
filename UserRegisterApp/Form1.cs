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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            emptyChcker();

            


        }

        private void emptyChcker()
        {
            bool isEmpty = false;
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        isEmpty = true;
                        break;
                    }
                }
                else if(control is DateTimePicker)
                {
                    if(((DateTimePicker)control).Value == null)
                    {
                        isEmpty = true;
                        break;
                    }
                }
                else if(control is ComboBox) 
                {
                    if(((ComboBox)control).SelectedIndex == -1)
                    {
                        isEmpty = true;
                        break;
                    }
                }
            }
            if( isEmpty )
            {
                MessageBox.Show("Fields can not be blank! Enter Values and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=CHINMAYA-PATRA\\SQLEXPRESS;Initial Catalog=RegisterForm;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                string insertQ = "INSERT INTO UserData VAlUES(@fname, @lname, @dob, @gender, @mail, @phone, @username, @pass, @country)";
                SqlCommand cmd = new SqlCommand(insertQ, con);
                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                cmd.Parameters.AddWithValue("@country", txtCountry.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successful!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lgp = new LoginPage();
            lgp.Show();
        }
    }
}
