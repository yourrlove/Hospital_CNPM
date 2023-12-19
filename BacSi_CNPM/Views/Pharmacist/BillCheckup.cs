using BusinessLogicTier;
using DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
    public partial class BillCheckup : Form
    {
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.BindingSource bindingSource1 = new System.Windows.Forms.BindingSource();
        private CashierBUS cashier;
        public BillCheckup()
        {
            InitializeComponent();
            cashier = CashierBUS.GetInstance();
            LoadBenhNhan();
            //Loadpatientbill();
        }

        Current curr = new Current();

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

        private void LoadBenhNhan()
        {
            try
            {
                this.dtgv_patient.AutoGenerateColumns = true;
                bindingSource.DataSource = cashier.GetListBenhNhan();
                this.dtgv_patient.DataSource = bindingSource;
                this.dtgv_patient.BorderStyle = BorderStyle.Fixed3D;
            }
            catch (Exception ex) { }
        }

        private void Loadpatientbill(int BN_ID)
        {
            try
            {
                bindingSource1.DataSource = cashier.GetHoaDonBenhNhan(BN_ID);
                this.dtgv_patientbills.DataSource = bindingSource1;
                this.dtgv_patientbills.AutoGenerateColumns = true;
                this.dtgv_patientbills.BorderStyle = BorderStyle.Fixed3D;
                this.dtgv_patientbills.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgv_patientbills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_patientbills.Rows.Count)
            {
                var cellValue = dtgv_patientbills.Rows[e.RowIndex].Cells[0].Value;
                var cellValue1 = dtgv_patientbills.Rows[e.RowIndex].Cells[3].Value;
                var cellValue2 = dtgv_patientbills.Rows[e.RowIndex].Cells[4].Value;

                if (cellValue != null)
                {
                    int HD_ID = Convert.ToInt32(cellValue);
                    int tongtien = Convert.ToInt32(cellValue1);
                    string thanhtoan = Convert.ToString(cellValue2);
                    showMiddleForm(new BillDetail(HD_ID, tongtien, thanhtoan));
                }
            }
        }

        private void dtgv_patient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_patient.Rows.Count)
            {
                var cellValue = dtgv_patient.Rows[e.RowIndex].Cells[0].Value;
               
                if (cellValue != null)
                {
                    int BN_ID = Convert.ToInt32(cellValue);
                    Loadpatientbill(BN_ID);
                }
            }
        }
    }
}
