using BacSi_CNPM.User_Controls;
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

namespace BacSi_CNPM
{

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            CollapseMenu();
            customDesign();
        }

        private void customDesign()
        {
            panelSubMenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if(panelSubMenu.Visible) {
                panelSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu) {
            if(subMenu.Visible == false) {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            dropDownMenu1.IsMainMenu = true;
            //dropDownMenu1.PrimaryColor = Color.Orange;
            //dropDownMenu1.MenuItemTextColor = Color.OrangeRed;
        }

        private void left_side_bar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void top_bar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

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


        private void guna2PictureBox1_val_Click(object sender, EventArgs e)
        {

        }

        private void container(object _form)
        {
            if(guna2Panel_container.Controls.Count > 0) { guna2Panel_container.Controls.Clear(); }
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();
        }

        private void guna2Panel1_container_Paint(object sender, PaintEventArgs e)
        {

        }



        private void uC_Button1_Click(object sender, EventArgs e)
        {
        }

        private void uC_ComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void uC_ComboBox1_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void uC_Button2_Click(object sender, EventArgs e)
        {

        }

        private void uC_PlaceHolderTextBoX1__TextChanged(object sender, EventArgs e)
        {

        }

        #region SlidingMenu
        private void menuBtn_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        private void CollapseMenu()
        {
            if(this.sidebar.Width > 200)
            {
                sidebar.Width = 75;
                logoPictueBox.Visible = false;
                menuBtn.Visible = true;
                menuBtn.BringToFront();
                menuBtn.Dock = DockStyle.Top;
                foreach(Button menuButton in sidebar.Controls.OfType<Button>())
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
            showSubMenu(panelSubMenu);
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            label1_val.Text = "Patient List";
            guna2PictureBox1_val.Image = Properties.Resources.icons8_person_64;
            container(new Patient());
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            Form formBackGround = new Form();
            using (Prescription prescribe = new Prescription())
            {
                formBackGround.StartPosition = FormStartPosition.Manual;
                formBackGround.FormBorderStyle = FormBorderStyle.None;
                formBackGround.Opacity = .70d;
                formBackGround.BackColor = Color.Black;
                formBackGround.WindowState = FormWindowState.Maximized;
                formBackGround.TopMost = true;
                formBackGround.Location = this.Location;
                formBackGround.ShowInTaskbar = false;
                formBackGround.Show(this);
                prescribe.Owner = formBackGround;
                prescribe.ShowDialog();

                formBackGround.Dispose();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form formBackGround = new Form();
            try
            {
                using (Setting set = new Setting())
                {
                    formBackGround.StartPosition = FormStartPosition.Manual;
                    formBackGround.FormBorderStyle = FormBorderStyle.None;
                    formBackGround.Opacity = .70d;
                    formBackGround.BackColor = Color.Black;
                    formBackGround.WindowState = FormWindowState.Maximized;
                    formBackGround.TopMost = true;
                    formBackGround.Location = this.Location;
                    formBackGround.ShowInTaskbar = false;
                    formBackGround.Show();
                    formBackGround.StartPosition = FormStartPosition.CenterScreen;
                    set.Owner = formBackGround;
                    set.ShowDialog();

                    formBackGround.Dispose();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                formBackGround.Dispose();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void dropDownMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void uC_Button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
