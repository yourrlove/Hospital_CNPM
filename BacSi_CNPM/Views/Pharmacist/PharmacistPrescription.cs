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
    public partial class PharmacistPrescription : Form
    {
        public PharmacistPrescription()
        {
            InitializeComponent();
        }
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
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            container(new PrescriptionDetail());
        }

        private void text_val_Click(object sender, EventArgs e)
        {

        }
    }
}
