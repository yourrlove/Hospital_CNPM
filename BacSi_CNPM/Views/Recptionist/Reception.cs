using Guna.UI2.WinForms;
using Hospital.User_Controls;
using Hospital.Views.Doctor;
using Hospital.Views.Recptionist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Views.Receptionist
{
    public partial class Reception : Form
    {
        private int borderSize = 2;
        public Reception()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(98, 102, 244);//Border color
            CollapseMenu();

        }

        private void ReceptionForm_Load(object sender, EventArgs e)
        {


        }
        private void CollapseMenu()
        {
            if (this.sidebar.Width > 200) //Collapse menu
            {
                sidebar.Width = 75;
                logoPictueBox.Visible = false;
                menuBtn.Dock = DockStyle.Top;
                foreach (Button menuButton in sidebar.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                sidebar.Width = 288;
                logoPictueBox.Visible = true;
                menuBtn.Dock = DockStyle.None;
                foreach (Button menuButton in sidebar.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
        private void showFormMiddle(Form showForm)
        {
            Form fm = new Form();
            try
            {
                using (showForm)
                {
                    fm.StartPosition = FormStartPosition.Manual;
                    fm.FormBorderStyle = FormBorderStyle.None;
                    fm.Opacity = .70d;
                    fm.BackColor = Color.Black;
                    fm.WindowState = FormWindowState.Maximized;
                    fm.TopMost = true;
                    fm.Location = this.Location;
                    fm.ShowInTaskbar = false;
                    fm.Show();
                    showForm.StartPosition = FormStartPosition.CenterScreen;
                    showForm.TopMost = true;
                    showForm.Owner = fm;
                    showForm.ShowDialog();

                    fm.Dispose();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                fm.Dispose();
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
            header_val.Text = "Dashboard Overview";
            guna2PictureBox2_val.Image = Properties.Resources.icons8_dashboard_48;
            LoadForm(new DashBoard());
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            header_val.Text = "Patient List";
            guna2PictureBox2_val.Image = (Image)Properties.Resources.ResourceManager.GetObject("patientlist");
            LoadForm(new ListPatient());
            //MessageBox.Show("May dung r do");
        }

        private void mainPanelReception_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void btnRegistPatient_Click(object sender, EventArgs e)
        {
            header_val.Text = "Patient Registration";
            guna2PictureBox2_val.Image = (Image)Properties.Resources.ResourceManager.GetObject("registerpatient");
            LoadForm(new PatientRegistation());
        }

        private void topBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reception_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void changeLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (changeLanguage.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    RightToLeftLayout = false;
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
                    RightToLeftLayout = true;
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
            RightToLeftLayout = true;
            Reception_Load(sender, e);
            
            /*CultureInfo newCulture;
            switch (changeLanguage.SelectedIndex)
            {
                case 0:
                    newCulture = new CultureInfo("en-US");
                    RightToLeftLayout = false;
                    break;
                case 1:
                    newCulture = new CultureInfo("vi-VN");
                    RightToLeftLayout = true;
                    break;
                default:
                    return;
            }

            LanguageManager.ChangeLanguage(newCulture);
            UpdateLanguageForAllForms();*/

        }
        /*private void UpdateLanguageForAllForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Reception)
                {
                    form.Controls.Clear();
                    InitializeComponent();
                    form.RightToLeftLayout = RightToLeftLayout;
                }

            }
        }*/
    }
}
