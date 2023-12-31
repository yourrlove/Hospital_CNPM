﻿using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessTier;
using Guna.UI2.WinForms;
using System.Data.Common;
using BusinessLogicTier;

namespace Hospital.Views.Cashier
{
    public partial class Prescription : Form
    {
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        private CashierBUS cashier;
        public Prescription()
        {
            cashier = CashierBUS.GetInstance();
            InitializeComponent();
            LoadBenhNhan();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_form"></param>
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

        /// <summary>
        /// Load the patient list based on the bindingsource
        /// </summary>
        private void LoadBenhNhan()
        {
            try
            {
                this.dtgv_searchPatients.AutoGenerateColumns = true;
                bindingSource.DataSource = cashier.GetListBenhNhan();
                this.dtgv_searchPatients.DataSource = bindingSource;
                this.dtgv_searchPatients.BorderStyle = BorderStyle.Fixed3D;

                this.dtgv_searchPatients.Columns[0].Visible = false;
                this.dtgv_searchPatients.Columns[4].Visible = false;
                this.dtgv_searchPatients.Columns[6].Visible = false;
                this.dtgv_searchPatients.Columns[7].Visible = false;
                this.dtgv_searchPatients.Columns[8].Visible = false;
                this.dtgv_searchPatients.AllowUserToAddRows = false;
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// Event double click on the cell the display the medicine prescription  based on the patient ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgv_searchPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dtgv_searchPatients.Rows.Count)
            {

                var cellValue = dtgv_searchPatients.Rows[e.RowIndex].Cells[0].Value;

                if (cellValue != null)
                {
                    int patientId = Convert.ToInt32(cellValue);
                    container(new MedicinePrescription(patientId));
                }
            }
        }
        Current curr = new Current();

        /// <summary>
        /// Event click on the cell the display the medicine prescription  based on the patient ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgv_searchPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_searchPatients.Rows.Count)
            {

                var cellValue = dtgv_searchPatients.Rows[e.RowIndex].Cells[0].Value;

                if (cellValue != null)
                {
                    int patientId = Convert.ToInt32(cellValue);
                    curr.patient = patientId;
                    container(new MedicinePrescription(patientId));
                }
            }
        }


        /// <summary>
        /// display the results realtime the patient in searching process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_patient_TextChanged(object sender, EventArgs e)
        {
            if (search_patient.Text != "")
            {
                dtgv_searchPatients.DataSource = cashier.SearchPatient(search_patient.Text);
            }
            else
            {
            }
        }

        private void dtgv_searchPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void containerPrescription_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
