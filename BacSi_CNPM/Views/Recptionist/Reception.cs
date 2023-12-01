using Guna.UI2.WinForms;
using Hospital.User_Controls;
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

namespace Hospital.Views.Receptionist
{
    public partial class ReceptionForm : Form
    {
        public ReceptionForm()
        {
            InitializeComponent();
            customDesign();
        }

        private void ReceptionForm_Load(object sender, EventArgs e)
        {
            hideSubMenu();

        }

        private void customDesign()
        {
            panelSubMenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelSubMenu.Visible)
            {
                panelSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }

        private void LoadForm(object Form)
        {
            if (this.mainPanelReception.Controls.Count > 0)
            {
                this.mainPanelReception.Controls.Clear();
            }
            Form fm = Form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.mainPanelReception.Controls.Add(fm);
            this.mainPanelReception.Tag = fm;
            fm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new DashBoard());
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            LoadForm(new ListPatient());
        }

        private void mainPanelReception_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
