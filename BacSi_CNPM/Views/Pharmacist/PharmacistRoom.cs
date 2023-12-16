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

namespace Hospital.Views.Pharmacist
{
    public partial class PharmacistRoom : Form
    {
        Bitmap myBitmap;
        public PharmacistRoom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load the container
        /// </summary>
        /// <param name="_form"></param>
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

        private void PharmacistRoom_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Search the medicines and display the result realtime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMedicine_Click(object sender, EventArgs e)
        {
            text_val.Text = "Search Medicine";
            image_val.Image = (Image)Properties.Resources.ResourceManager.GetObject("icons8-pill-48");
            container(new SearchMedicine());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            text_val.Text = "Prescription";
            image_val.Image = (Image)Properties.Resources.ResourceManager.GetObject("prescription");
            container(new PharmacistPrescription());
        }

        private void topbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            text_val.Text = "Prescription Checking";
            image_val.Image = (Image)Properties.Resources.ResourceManager.GetObject("icons8-pill-48");
            container(new PrescriptionChecking());
        }
    }
}
