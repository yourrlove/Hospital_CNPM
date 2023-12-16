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
    public partial class MedicinePrescription : Form
    {
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        public MedicinePrescription(int BN_ID)
        {
            InitializeComponent();
            LoadDonThuoc(BN_ID);
        }
        /// <summary>
        /// show the pop up of bill and prescription
        /// </summary>
        /// <param name="showForm"></param>

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
                    //fm.Show();
                    showForm.StartPosition = FormStartPosition.CenterParent;
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


        Current curr = new Current();
        /// <summary>
        /// Load prescription based on the bindingsource
        /// </summary>
        /// <param name="BN_ID"></param>
        private void LoadDonThuoc(int BN_ID)
        {
            try
            {
                curr.patient = BN_ID;
                bindingSource.DataSource = DonThuocDBContext.GetDonThuocBN(BN_ID);
                this.dtgv_medicinePrescription.DataSource = bindingSource;
                this.dtgv_medicinePrescription.AutoGenerateColumns = true;
                this.dtgv_medicinePrescription.BorderStyle = BorderStyle.Fixed3D;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// Clicking on the cell to display the list of patient prescription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgv_medicinePrescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_medicinePrescription.Rows.Count)
            {
                var cellValue = dtgv_medicinePrescription.Rows[e.RowIndex].Cells[0].Value;
                // MessageBox.Show("Donthuoc ID " + Convert.ToString(cellValue));
                if (cellValue != null)
                {
                    int DT_ID = Convert.ToInt32(cellValue);

                    showMiddleForm(new PrescriptionBills(DT_ID, curr.patient));
                }
            }
        }
    }
}
