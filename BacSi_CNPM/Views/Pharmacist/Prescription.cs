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
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }


        // -> container prescription
        private void container(object _form)
        {
            if (containerPrescription.Controls.Count > 0) { containerPrescription.Controls.Clear(); }
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            containerPrescription.Controls.Add(fm);
            containerPrescription.Tag = fm;
            fm.Show();
        }

        private void dtgv_seachPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_searchPatients_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Prescription_Load(object sender, EventArgs e)
        {

        }

        private void dtgv_searchPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            container(new MedicinePrescription());

        }

        private void containerPrescription_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
