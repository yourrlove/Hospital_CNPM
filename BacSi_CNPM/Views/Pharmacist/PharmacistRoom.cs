using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Views.Pharmacist
{
    public partial class PharmacistRoom : Form
    {
        public PharmacistRoom()
        {

            InitializeComponent();
            text_val.Text = "Pharmacist View";
            image_val.Image = Properties.Resources.icons8_user_50;
        }

        // -> Container
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


        // -> Show Form at middle scrreen
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

        private void menuBtn_Click(object sender, EventArgs e)
        {

        }

        private void PharmacistRoom_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            text_val.Text = "Dashboard Overview";
            image_val.Image = Properties.Resources.icons8_dashboard_48;
            container(new Dashboard());
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            text_val.Text = "Medicine Store";
            image_val.Image = Properties.Resources.icons8_dashboard_48;
            container(new Medicine_details());
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            text_val.Text = "Prescription";
            image_val.Image = Properties.Resources.icons8_dashboard_48;
            container(new Prescription());
        }
    }
}
