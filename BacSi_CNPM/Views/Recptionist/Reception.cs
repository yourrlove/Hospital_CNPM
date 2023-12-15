using Guna.UI2.WinForms;
using Hospital.User_Controls;
using Hospital.Views.Doctor;
using Hospital.Views.Recptionist;
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
    public partial class Reception : Form
    {
        public Reception()
        {
            InitializeComponent();

        }

        private void ReceptionForm_Load(object sender, EventArgs e)
        {


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

        }

        private void btnRegistPatient_Click(object sender, EventArgs e)
        {
            LoadForm(new PatientRegistation());
        }
    }
}
