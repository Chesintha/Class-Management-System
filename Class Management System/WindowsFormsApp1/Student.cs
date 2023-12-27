using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace WindowsFormsApp1.Properties
{
    public partial class FormStudent : Form
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Institute.mdf;Integrated Security = True";
        SqlConnection connection = new SqlConnection(connectionString);
        ErrorProvider err1 = new ErrorProvider();
        public FormStudent()
        {
            InitializeComponent();
        }

        private void dateTimePickerReg_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {

        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            FormStaff stf = new FormStaff();
            if (stf == null || stf.IsDisposed)
            {
                stf = new FormStaff();
            }

            stf.Show();
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

        public Boolean Validatestd()
        {
            err1.Clear();
            if (!Regex.IsMatch(firstNameStd.Text, @"^[A-Za-z\s]+$"))
            {
                err1.SetError(firstNameStd, "Invalid input");
                return false;
            }
            if (!Regex.IsMatch(lastNameStd.Text, @"^[A-Za-z\s]+$"))
            {
                err1.SetError(lastNameStd, "Invalid input");
                return false;
            }
            if (!Regex.IsMatch(emailStd.Text, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                err1.SetError(emailStd, "Invalid input");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Query1 = "INSERT INTO Student(First_Name, Last_Name, Gender, Date_of_Birth, Email, Telephone_Number, Registration_Date, Address) VALUES ('" + firstNameStd.Text + "','" + lastNameStd.Text + "','" + materialRadioButton1.Text + "','" + dateTimePickerDOB.Value.ToString("yyyy-MM-dd") + "','" + emailStd.Text + "','" + tpNOStd.Text + "','" + dateTimePickerReg.Value.ToString("yyyy-MM-dd") + "','" + addressStd.Text + "')";
            string Query2 = "INSERT INTO Student(First_Name, Last_Name, Gender, Date_of_Birth, Email, Telephone_Number, Registration_Date, Address) VALUES ('" + firstNameStd.Text + "','" + lastNameStd.Text + "','" + materialRadioButton2.Text + "','" + dateTimePickerDOB.Value.ToString("yyyy-MM-dd") + "','" + emailStd.Text + "','" + tpNOStd.Text + "','" + dateTimePickerReg.Value.ToString("yyyy-MM-dd") + "','" + addressStd.Text + "')";

            if (Validatestd())
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
        private void firstNameStd_Click(object sender, EventArgs e)
        {

        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}


