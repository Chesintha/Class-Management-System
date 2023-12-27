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
using WindowsFormsApp1.Properties;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class FormStaff : Form
    {

        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Institute.mdf;Integrated Security = True";
        SqlConnection connection = new SqlConnection(connectionString);
        ErrorProvider err1 = new ErrorProvider();
        public FormStaff()
        {
            InitializeComponent();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            FormStudent stdn = new FormStudent();
            if (stdn == null || stdn.IsDisposed)
            {
                stdn = new FormStudent();
            }

            stdn.Show();
            this.Hide();
        }

        private void buttonClass_Click(object sender, EventArgs e)
        {
            FormClasses clss = new FormClasses();
            if (clss == null || clss.IsDisposed)
            {
                clss = new FormClasses();
            }

            clss.Show();
            this.Hide();
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {

        }
        public Boolean Validatestf ()
        {
            err1.Clear();
            if (!Regex.IsMatch(firstNameStf.Text, @"^[A-Za-z\s]+$"))
            {
                err1.SetError(firstNameStf, "Invalid input");
                return false;
            }
            if (!Regex.IsMatch(lastNameStf.Text, @"^[A-Za-z\s]+$"))
            {
                err1.SetError(lastNameStf, "Invalid input");
                return false;
            }
            if (!Regex.IsMatch(emailStf.Text, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                err1.SetError(emailStf, "Invalid input");
                return false;
            }
            return true;
        }

        private void btnSaveStf_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Query1 = "INSERT INTO Staff(First_Name,Last_Name,Gender,Date of Birth, Email,Telephone_Number, Registration_Date, Address, Subject) VALUES ('" + firstNameStf.Text + "','" + lastNameStf.Text + "','" + materialRadioButton1.Text + "','" + dateTimePickerDOBStf.Value.ToString("yyyy-MM-dd") + "','" + emailStf.Text + "','" + tpNOStf.Text + "','" + dateTimePickerRegStf.Value.ToString("yyyy-MM-dd") + "','" + addressStf.Text + "','"+ subjectStf.Text+ "')";
            string Query2 = "INSERT INTO Staff(First_Name,Last_Name,Gender,Date of Birth, Email,Telephone_Number, Registration_Date, Address, Subject) VALUES ('" + firstNameStf.Text + "','" + lastNameStf.Text + "','" + materialRadioButton2.Text + "','" + dateTimePickerDOBStf.Value.ToString("yyyy-MM-dd") + "','" + emailStf.Text + "','" + tpNOStf.Text + "','" + dateTimePickerRegStf.Value.ToString("yyyy-MM-dd") + "','" + addressStf.Text + "','"+ subjectStf.Text+ "')";

            if (Validatestf())
            {
                try
                {
                    connection.Open();
                    if (materialRadioButton1.Checked)
                    {
                        adapter.InsertCommand = new SqlCommand(Query1, connection);
                        //adapter.InsertCommand.ExecuteNonQuery();
                        int rowsAdded = adapter.InsertCommand.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            MessageBox.Show("Row inserted!!");
                        else
                            MessageBox.Show("No row inserted");
                        // MessageBox.Show("Row inserted !! ");
                    }
                    if (materialRadioButton2.Checked)
                    {
                        adapter.InsertCommand = new SqlCommand(Query2, connection);
                        int rowsAdded = adapter.InsertCommand.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            MessageBox.Show("Row inserted!!");
                        else
                            MessageBox.Show("No row inserted");
                        // MessageBox.Show("Row inserted !! ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
                connection.Close();
            }

        }
            
    }
}
