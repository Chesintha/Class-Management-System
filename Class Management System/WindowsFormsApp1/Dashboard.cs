using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{    
    public partial class Dashboard : Form
    {
        //private FormStudent stdn = new FormStudent();
        //private FormStaff stf = new FormStaff();
        //private FormClasses clss = new FormClasses();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
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
    }
}
