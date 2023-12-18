using BusinessLogicTier;
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
        private System.Windows.Forms.BindingSource bindingSource1 = new System.Windows.Forms.BindingSource();
        private CashierBUS cashier;
        public MedicinePrescription(int BN_ID)
        {
            cashier = CashierBUS.GetInstance();
            curr.patient = BN_ID;
            InitializeComponent();
            LoadDonThuoc(BN_ID);
            Loadpatientbill(BN_ID);
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
                bindingSource.DataSource = cashier.GetDonThuocBenhNhan(BN_ID);
                this.dtgv_medicinePrescription.DataSource = bindingSource;
                this.dtgv_medicinePrescription.AutoGenerateColumns = true;
                this.dtgv_medicinePrescription.BorderStyle = BorderStyle.Fixed3D;
                this.dtgv_medicinePrescription.AllowUserToAddRows = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


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

        private void Loadpatientbill(int BN_ID)
        {
            try
            {
                bindingSource1.DataSource = cashier.GetHoaDonBenhNhan(BN_ID);
                this.dtgv_patientBill.DataSource = bindingSource1;
                this.dtgv_patientBill.AutoGenerateColumns = true;
                this.dtgv_patientBill.BorderStyle = BorderStyle.Fixed3D;
                this.dtgv_patientBill.AllowUserToAddRows = false;

                this.dtgv_patientBill.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dtgv_patientBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_patientBill.Rows.Count)
            {
                var cellValue = dtgv_patientBill.Rows[e.RowIndex].Cells[0].Value;
                var cellValue1 = dtgv_patientBill.Rows[e.RowIndex].Cells[3].Value;
                var cellValue2 = dtgv_patientBill.Rows[e.RowIndex].Cells[4].Value;

                if (cellValue != null)
                {
                    int HD_ID = Convert.ToInt32(cellValue);
                    int tongtien = Convert.ToInt32(cellValue1);
                    string thanhtoan = Convert.ToString(cellValue2);
                    showMiddleForm(new BillDetail(HD_ID, tongtien, thanhtoan));
                }
            }
        }

        private void dtgv_medicinePrescription_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_patientBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
