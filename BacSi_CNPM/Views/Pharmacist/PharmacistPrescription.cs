using DataAccessTier;
using DTO;
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
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.BindingSource bindingSource1 = new System.Windows.Forms.BindingSource();

        public PharmacistPrescription()
        {
            InitializeComponent();
            LoadHoaDon();
            LoadDonePrescription();
        }

        Current curr = new Current();

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

        /// <summary>
        /// Load the Bill in data gridview
        /// </summary>
        private void LoadHoaDon()
        {
            try
            {
                bindingSource.DataSource = HoaDonDuocSiDBContext.ListHoaDon();
                this.dtgv_patient.DataSource = bindingSource;
                this.dtgv_patient.AutoGenerateColumns = true;

                //this.dtgv_patient.Columns[0].Visible = false;
                //this.dtgv_patient.Columns[1].Visible = false;

                this.dtgv_patient.BorderStyle = BorderStyle.Fixed3D;
            }
            catch
            {

            }
        }

        private void LoadDonePrescription()
        {
            try
            {
                bindingSource1.DataSource = DonePrescriptionDBContext.ListHoaDon();
                this.dtgv_done_prescription.DataSource = bindingSource1;
                this.dtgv_done_prescription.AutoGenerateColumns = true;
                //this.dtgv_done_prescription = BorderStyle.Fixed3D;
            }
            catch
            {

            }

        }

        /// <summary>
        /// Click on the patient to display the details prescription of the pation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgv_patient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_patient.Rows.Count)
            {

                var cellValue = dtgv_patient.Rows[e.RowIndex].Cells[0].Value;
                var cellValue1 = dtgv_patient.Rows[e.RowIndex].Cells[1].Value;
                if (cellValue != null)
                {
                    int BN_ID = Convert.ToInt32(cellValue1.ToString());
                    int HD_ID = Convert.ToInt32(cellValue.ToString());
                    curr.BN_ID = BN_ID;
                    curr.HD_ID = HD_ID;
                    container(new PrescriptionDetail(HD_ID, BN_ID));
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DonePrescriptionDBContext.addPrescription(curr.BN_ID, curr.HD_ID);
            HoaDonDuocSiDBContext.deleteRecord(curr.BN_ID, curr.HD_ID);
            LoadHoaDon();
            LoadDonePrescription();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DonePrescriptionDBContext.deleteRecord(curr.BN_ID, curr.HD_ID);
            LoadDonePrescription();
        }
        private void dtgv_done_prescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = dtgv_done_prescription.Rows[e.RowIndex].Cells[0].Value;
            var cellValue1 = dtgv_done_prescription.Rows[e.RowIndex].Cells[1].Value;
            int BN_ID = Convert.ToInt32(cellValue1.ToString());
            int HD_ID = Convert.ToInt32(cellValue.ToString());
            curr.BN_ID = BN_ID;
            curr.HD_ID = HD_ID;

        }
    }
}
