using Hospital.Views.Doctor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Views.Admin
{
    public partial class AdminRoom : Form
    {
        public AdminRoom()
        {
            InitializeComponent();
        }
        //-> container
        private void container(object _form)
        {
            if (panel_container.Controls.Count > 0) { panel_container.Controls.Clear(); }
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            panel_container.Controls.Add(fm);
            panel_container.Tag = fm;
            fm.Show();
        }
        private void AdminRoom_Load(object sender, EventArgs e)
        {

        }





        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            text_val.Text = "Dashboard Overview";
            image_val.Image = Properties.Resources.icons8_dashboard_48;
            container(new AdminDashboard());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            text_val.Text = "New Account";
            image_val.Image = (Image)Properties.Resources.ResourceManager.GetObject("account"); ;
            container(new NewAccount());
        }

        private void logoPictueBox_Click(object sender, EventArgs e)
        {

        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            text_val.Text = "Database Record";
            image_val.Image = (Image)Properties.Resources.ResourceManager.GetObject("database"); ;
            container(new DatabaseRecord());
        }
    }
}
