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
using TheArtOfDevHtmlRenderer.Adapters;

namespace Hospital.Views.Admin
{
    public partial class AdminRoom : Form
    {
        private Color clickedButtonColor = Color.Blue;
        private Color defaultButtonColor = Color.FromArgb(24, 25, 53);
        private Guna.UI2.WinForms.Guna2Button currentButton;
        private int borderSize = 2;

        public AdminRoom()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(98, 102, 244);//Border color
            CollapseMenu();
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


        //Change color when click on the button on menu side bar
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
                else if (clickedButton == btnDatabase)
                {
                    currentButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("databasewhite");
                }
                else if (clickedButton == btnRegister)
                {
                    currentButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("add_user_white");
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
                    else if (previousBtn == btnDatabase)
                    {
                        previousBtn.Image = (Image)Properties.Resources.ResourceManager.GetObject("database");
                    }
                    else if (previousBtn == btnRegister)
                    {
                        previousBtn.Image = (Image)Properties.Resources.ResourceManager.GetObject("add_user");
                    }

                }
            }
        }


        private void AdminRoom_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void logoPictueBox_Click(object sender, EventArgs e)
        {

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
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


        private void menuBtn_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            text_val.Text = "Dashboard Overview";
            image_val.Image = Properties.Resources.icons8_dashboard_48;
            container(new AdminDashboard());
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            text_val.Text = "Database Record";
            image_val.Image = (Image)Properties.Resources.ResourceManager.GetObject("database"); ;
            container(new DatabaseRecord());
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            text_val.Text = "New Account";
            image_val.Image = (Image)Properties.Resources.ResourceManager.GetObject("account"); ;
            container(new NewAccount());
        }

        private void topbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}



