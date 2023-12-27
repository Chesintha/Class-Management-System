using MaterialSkin.Controls;
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

namespace WindowsFormsApp1
{    
    public partial class FormClasses : Form
    {

        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Institute.mdf;Integrated Security = True";
        SqlConnection connection = new SqlConnection(connectionString);
        public FormClasses()
        {
            InitializeComponent();
        }

        private void FormClasses_Load(object sender, EventArgs e)
        {

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

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Query1 = "INSERT INTO Classes(Subject,StaffId,Grade,year, Month) VALUES ('" + subName.Text + "','" + grade.Text + "','" + year.Text + "','" + comboBoxMonth.SelectedItem.ToString()+"')";
            
            try
            {
                connection.Open();      
                adapter.InsertCommand = new SqlCommand(Query1, connection);
                //adapter.InsertCommand.ExecuteNonQuery();
                int rowsAdded = adapter.InsertCommand.ExecuteNonQuery();
                if (rowsAdded > 0)
                    MessageBox.Show("Row inserted!!");
                else
                    MessageBox.Show("No row inserted");
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
            connection.Close();
        }

        private void groupBoxClassAll_Enter(object sender, EventArgs e)
        {

        }
    }
}
