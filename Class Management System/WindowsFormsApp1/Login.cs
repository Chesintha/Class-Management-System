using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Institute.mdf;Integrated Security = True";
        SqlConnection connection = new SqlConnection(connectionString);
        public Login()
        {
            InitializeComponent();            
        }

        private void materialSingleLineTextFieldUsername_Click(object sender, EventArgs e)
        {            
        }

        private void materialSingleLineTextFieldPassword_Click(object sender, EventArgs e)
        {            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string Query = "SELECT Username,Password FROM Admin WHERE Username = '" + materialSingleLineTextFieldUsername.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, connection);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    sdr.Read();
                    string pword = Convert.ToString(sdr["Password"]);
                    if (pword.Equals(materialSingleLineTextFieldPassword.Text))
                    {
                        Dashboard dbrd = new Dashboard();
                        dbrd.Show();
                        this.Hide();
                    }
                    else
                    {
                        errorProviderPassword.SetError(this.materialSingleLineTextFieldPassword, "Password is incorrect..!");
                    }
                }
                else
                {
                    errorProviderUserName.SetError(this.materialSingleLineTextFieldUsername,"User name is incorrect..!");
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
