using BusinessLogicTier;
using Guna.UI2.WinForms.Suite;
using Hospital.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Hospital.Views.Doctor
{

    public partial class DoctorForm : Form
    {
        private DoctorRoomBUS room;
        public DoctorForm()
        {
            InitializeComponent();
            room = DoctorRoomBUS.GetInstance();
            //CollapseMenu();
        }

        private void showMiddleForm(Form showForm)
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
        private void Form2_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
           // dropDownMenu1.IsMainMenu = true;
            //dropDownMenu1.PrimaryColor = Color.Orange;
            //dropDownMenu1.MenuItemTextColor = Color.OrangeRed;
        }


        private void guna2Button5_Click(object sender, EventArgs e)
        {
            label1_val.Text = "Messages";
            guna2PictureBox1_val.Image = Properties.Resources.icons8_dashboard_48;
        }


        private void Dashboard_Click(object sender, EventArgs e)
        {
            label1_val.Text = "Dashboard Overview";
            guna2PictureBox1_val.Image = Properties.Resources.icons8_dashboard_48;
            container(new Dashboard());
        }



        private void container(object _form)
        {
            if (DoctorMainPanel.Controls.Count > 0) {
                if (DoctorMainPanel.Controls["Requests"]  != null)
                {
                    Requests obj = (Requests)Application.OpenForms["Requests"];
                    obj.Close();
                }
                DoctorMainPanel.Controls.Clear(); 
            }
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            DoctorMainPanel.Controls.Add(fm);
            DoctorMainPanel.Tag = fm;
            fm.Show();
        }

        #region SlidingMenu
        private void menuBtn_Click(object sender, EventArgs e)
        {
           // CollapseMenu();
        }
        private void CollapseMenu()
        {
            if (this.sidebar.Width > 200)
            {
                sidebar.Width = 75;
                logoPictueBox.Visible = false;
                menuBtn.Visible = true;
                menuBtn.BringToFront();
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
        #endregion

        private void btnMedicalRecord_Click(object sender, EventArgs e)
        {
            label1_val.Text = "Medical Record";
            guna2PictureBox1_val.Image = (Image)Properties.Resources.ResourceManager.GetObject("icons8-medical-64");
            container(new Medical());
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            showMiddleForm(new Setting());
        }

        //button Requests
        private void btnRequest_Click(object sender, EventArgs e)
        {
            label1_val.Text = "Requests";
            guna2PictureBox1_val.Image = Properties.Resources.icons8_user_50;
            container(new Requests());
        }

        private void topBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
