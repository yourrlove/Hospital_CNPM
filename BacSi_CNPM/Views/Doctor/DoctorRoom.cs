using BusinessLogicTier;
using Guna.UI2.WinForms.Suite;
using Hospital.User_Controls;
using Hospital.Views.Login;
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
        private Color clickedButtonColor = Color.Blue;
        private Color defaultButtonColor = Color.FromArgb(24, 25, 53);
        private Guna.UI2.WinForms.Guna2Button currentButton;
        private int borderSize = 2;
        public DoctorForm(int BS_ID)
        {
            InitializeComponent();
            room = DoctorRoomBUS.GetInstance();
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(98, 102, 244);//Border color
            room.BS_ID = BS_ID;
            CollapseMenu();
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

        private void ActivateButton(object btnSender)
        {
            if (btnSender is Guna.UI2.WinForms.Guna2Button clickedButton)
            {
                if (currentButton != null)
                {
                    // Reset the previous button to its default state
                    DisableButton();
                }

                // Set the new current button
                currentButton = clickedButton;

                // Change the appearance of the new current button
                currentButton.FillColor = clickedButtonColor;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

                // Determine which image to use based on the button clicked
                if (clickedButton == btnDashboard)
                {
                    currentButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("dashboard_white");
                }
                else if (clickedButton == btnRequest)
                {
                    currentButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("request_white");
                }
                else if (clickedButton == btnMedicalRecord)
                {
                    currentButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("medicalRecord_white");
                }
                else if (clickedButton == btnHome)
                {
                    currentButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("home_white");
                }

            }
        }



        //Change to previous state if another button is clicked
        private void DisableButton()
        {
            foreach (Guna.UI2.WinForms.Guna2Button previousBtn in sidebar.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                if (previousBtn.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    previousBtn.FillColor = defaultButtonColor;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    if (previousBtn == btnDashboard)
                    {
                        previousBtn.Image = (Image)Properties.Resources.ResourceManager.GetObject("dashboard");
                    }
                    else if (previousBtn == btnRequest)
                    {
                        previousBtn.Image = (Image)Properties.Resources.ResourceManager.GetObject("request");
                    }
                    else if (previousBtn == btnMedicalRecord)
                    {
                        previousBtn.Image = (Image)Properties.Resources.ResourceManager.GetObject("medicalRecord");
                    }
                    else if (previousBtn == btnHome)
                    {
                        previousBtn.Image = (Image)Properties.Resources.ResourceManager.GetObject("home");
                    }
                }
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            text_val.Text = "Messages";
            image_val.Image = Properties.Resources.icons8_dashboard_48;
        }


        private void Dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            text_val.Text = "Dashboard Overview";
            image_val.Image = Properties.Resources.icons8_dashboard_48;
            container(new Dashboard());
        }



        private void container(object _form)
        {
            if (DoctorMainPanel.Controls.Count > 0)
            {
                if (DoctorMainPanel.Controls["Requests"] != null)
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

        private void menuBtn_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }


        private void btnMedicalRecord_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            text_val.Text = "Medical Record";
            image_val.Image = (Image)Properties.Resources.ResourceManager.GetObject("icons8-medical-64");
            container(new Medical());
        }


        //button Requests
        private void btnRequest_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            text_val.Text = "Requests";
            image_val.Image = Properties.Resources.icons8_user_50;
            container(new Requests());
        }

        private void topBar_Paint(object sender, PaintEventArgs e)
        {

        }
        //Change color when click on the button on menu side bar

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Controls.Clear();
            InitializeComponent();
            RightToLeftLayout = true;
            DoctorForm_Load(sender, e);
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            ActivateButton(btnHome);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit application?",
             "Confirmation",
             MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}
