using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogicTier;
using DataAccessTier;
using DTO;
using Guna.UI2.WinForms.Suite;
using Hospital.Views.Recptionist;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Tulpep.NotificationWindow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital.Views.Receptionist
{

    public partial class ListPatient : Form
    {
        ReceptionBUS reception;
        private int selectedRowIndex = 0;
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        private List<BenhNhanCheckup> lists;

        public ListPatient()
        {
            reception = ReceptionBUS.GetInstance();
            InitializeComponent();
            lists = new List<BenhNhanCheckup>();
            lists = reception.GetListPatients();
            this.DataGridViewPatientList.ClearSelection();
            reception.BN_ID = 0;
        }

        private void ListPatient_Load(object sender, EventArgs e)
        {
            this.DataGridViewPatientList.ClearSelection();
            RefreshList(1);

        }

        private void guna2Button_Filter_Click(object sender, EventArgs e)
        {
            string name = PatientName.Texts ?? "";
            string tel = Tel.Texts ?? "";
            if(name != "" || tel != "")
            {
                var list = reception.SearchRecord(name, tel);
                bindingSource.DataSource = list;
                this.DataGridViewPatientList.DataSource = bindingSource;
                this.label_patientcount.Text = bindingSource.Count.ToString();
                selectedRowIndex = 0;
            } else
            {
                bindingSource.Clear();
                this.DataGridViewPatientList.DataSource = bindingSource;
                this.label_patientcount.Text = "0";
                selectedRowIndex = -1;
            }
 
        }

        private void DataGridViewPatientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in a valid row (not header or empty space).
            if (e.RowIndex >= 0)
            {
                // Store the selected row index.
                selectedRowIndex = e.RowIndex;
            }
        }

        private void guna2Button4_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRowIndex >= 0 && DataGridViewPatientList.Rows[selectedRowIndex].Cells[0].Value != null)
                {
                    int BN_ID = int.Parse(this.DataGridViewPatientList.Rows[selectedRowIndex].Cells[0].Value.ToString());
                    reception.BN_ID = BN_ID;
                    reception.edit = true;

                    Form showForm = new EditPatientInfor();
                    Form fm = new Form();
                    fm.StartPosition = FormStartPosition.Manual;
                    fm.FormBorderStyle = FormBorderStyle.None;
                    fm.Opacity = .70d;
                    fm.BackColor = Color.Black;
                    fm.WindowState = FormWindowState.Maximized;
                    fm.TopMost = true;
                    fm.Location = this.Location;
                    fm.ShowInTaskbar = false;
                    //fm.Show();
                    showForm.StartPosition = FormStartPosition.CenterScreen;
                    showForm.TopMost = true;
                    showForm.Owner = fm;
                    showForm.ShowDialog();
                    fm.Dispose();

                    if(reception.edit)
                    {
                        Notification.SucccessNotification("Change Successfully!");
                    }

                    RefreshList(0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void RefreshList(int flag)
        {

            try
            {
                if(flag == 0)
                {
                    lists = reception.GetListPatients();
                }
                this.DataGridViewPatientList.ClearSelection();
                bindingSource.DataSource = lists;
                this.DataGridViewPatientList.DataSource = bindingSource;
                this.label_patientcount.Text = lists.Count.ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("error");
            }
        }

        private void guna2Button5_Delete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && DataGridViewPatientList.Rows[selectedRowIndex].Cells[0].Value != null)
            {
                int BN_ID = int.Parse(this.DataGridViewPatientList.Rows[selectedRowIndex].Cells[0].Value.ToString());
                reception.DeletePatient(BN_ID);
                RefreshList(0);
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            
            if (selectedRowIndex >= 0 && DataGridViewPatientList.Rows[selectedRowIndex].Cells[0].Value != null)
            {
                int BN_ID = int.Parse(this.DataGridViewPatientList.Rows[selectedRowIndex].Cells[0].Value.ToString());
                reception.BN_ID = BN_ID;
                // Create and show the new child form (PatientRegistation)

                if (Application.OpenForms["Reception"].Controls["mainPanelReception"].Controls.Count != 0)
                {
                    Application.OpenForms["Reception"].Controls["mainPanelReception"].Controls.Clear();
                }

                // Add new subform after clearing 
                PatientRegistation patientRegist = new PatientRegistation();
                patientRegist.TopLevel = false;
                Application.OpenForms["Reception"].Controls["mainPanelReception"].Controls.Add(patientRegist);
                patientRegist.Dock = DockStyle.Fill;
                patientRegist.Show();
                this.Dispose();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            PatientName.Texts = "";
            Tel.Texts = "";
            RefreshList(1);
        }
    }
}
