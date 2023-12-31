﻿using DataAccessTier;
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
using Tulpep.NotificationWindow;
using BussinessLogicTier;

namespace Hospital.Views.Pharmacist
{
    public partial class PharmacistPrescription : Form
    {
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.BindingSource bindingSource1 = new System.Windows.Forms.BindingSource();
        private PharmacistBUS pharmacist;
        public PharmacistPrescription()
        {
            pharmacist = PharmacistBUS.GetInstance();
            InitializeComponent();
            LoadHoaDon();
            LoadDonePrescription();
        }

        Current1 curr = new Current1();

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
                bindingSource.DataSource = pharmacist.ListHoaDon1();
                this.dtgv_patient.DataSource = bindingSource;
                //this.dtgv_patient.AutoGenerateColumns = true;
                this.dtgv_patient.Columns[0].Visible = false;
                this.dtgv_patient.Columns[1].Visible = false;

                this.dtgv_patient.BorderStyle = BorderStyle.Fixed3D;
                this.dtgv_patient.AllowUserToAddRows = false;
            }
            catch
            {

            }
        }

        private void LoadDonePrescription()
        {
            try
            {
                bindingSource1.DataSource = pharmacist.ListHoaDon();
                this.dtgv_done_prescription.DataSource = bindingSource1;
                //this.dtgv_done_prescription.AutoGenerateColumns = true;
                this.dtgv_done_prescription.Columns[0].Visible = false;
                this.dtgv_done_prescription.Columns[1].Visible = false;
                this.dtgv_done_prescription.AllowUserToAddRows = false;
                //this.dtgv_done_prescription = BorderStyle.Fixed3D;
            }//
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
        /// <summary>
        /// Load the bills of patients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DonePrescriptionDBContext.addPrescription(curr.BN_ID, curr.HD_ID);
            HoaDonDuocSiDBContext.deleteRecord1(curr.BN_ID, curr.HD_ID);
            LoadHoaDon();
            LoadDonePrescription();
        }
        //success pop up notification 


        /// <summary>
        /// delete the prescription that has been done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guna2Button2_Click(object sender, EventArgs e)
        {

            DonePrescriptionDBContext.deleteRecord(curr.BN_ID, curr.HD_ID);
            LoadDonePrescription();
        }

        /// <summary>
        /// Get patient ID and bill ID of each prescription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgv_done_prescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = dtgv_done_prescription.Rows[e.RowIndex].Cells[0].Value;
            var cellValue1 = dtgv_done_prescription.Rows[e.RowIndex].Cells[1].Value;
            int BN_ID = Convert.ToInt32(cellValue1.ToString());
            int HD_ID = Convert.ToInt32(cellValue.ToString());
            curr.BN_ID = BN_ID;
            curr.HD_ID = HD_ID;

        }


        /// <summary>
        /// Search prescription to give to patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tx_search_completed_prescription_TextChanged_1(object sender, EventArgs e)
        {
            if (tx_search_completed_prescription.Text != "")
            {
                dtgv_done_prescription.DataSource = pharmacist.SearchCompletedPrescription(tx_search_completed_prescription.Text);
            }
            else
            {

            }
        }

        private void listHTchoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
