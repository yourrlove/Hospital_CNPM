using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;
using DataAccessTier;
using Guna.UI2.WinForms.Suite;
using Hospital.Views.Recptionist;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital.Views.Receptionist
{

    public partial class ListPatient : Form
    {
        ReceptionBUS reception;
        private int selectedRowIndex = -1;
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        List<PatientRecord> records;

        public ListPatient()
        {
            reception = new ReceptionBUS();
            InitializeComponent();
            Sex.SelectedItem = null;
            records = new List<PatientRecord>();
            records = reception.GetOldPatientRecords();
        }

        private void label1_patientnum_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListPatient_Load(object sender, EventArgs e)
        {
            RefreshList(1);
        }

        private void guna2Button_Filter_Click(object sender, EventArgs e)
        {
            string name = Name.Texts ?? "";
            DateTime DoB = this.DoB.Value;
            string sex = (Sex.SelectedItem != null) ? Sex.SelectedItem.ToString() : "";
            var list = reception.SearchRecord(name, DoB, sex);
            bindingSource.DataSource = list;
            this.DataGridViewPatientList.DataSource = bindingSource;
            this.label_patientcount.Text = bindingSource.Count.ToString();
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
                if (selectedRowIndex >= 0)
                {
                    int BN_ID = int.Parse(this.DataGridViewPatientList.Rows[selectedRowIndex].Cells[0].Value.ToString());
                    Form showForm = new EditPatientInfor(BN_ID);
                    Form fm = new Form();
                    fm.StartPosition = FormStartPosition.Manual;
                    fm.FormBorderStyle = FormBorderStyle.None;
                    fm.Opacity = .70d;
                    fm.BackColor = Color.Black;
                    fm.WindowState = FormWindowState.Maximized;
                    fm.TopMost = true;
                    fm.Location = this.Location;
                    fm.ShowInTaskbar = false;
                    fm.Show();
                    showForm.StartPosition = FormStartPosition.CenterScreen;
                    showForm.TopMost = true;
                    showForm.Owner = fm;
                    showForm.ShowDialog();

                    fm.Dispose();
                }
                RefreshList(0);
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
                    records = reception.GetOldPatientRecords();
                }
                this.DataGridViewPatientList.ClearSelection();
                bindingSource.DataSource = records;
                this.DataGridViewPatientList.DataSource = bindingSource;
                this.label_patientcount.Text = records.Count.ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("error");
            }
        }

        private void guna2Button5_Delete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {

                int BN_ID = int.Parse(this.DataGridViewPatientList.Rows[selectedRowIndex].Cells[1].Value.ToString());
                MessageBox.Show(BN_ID.ToString());
                reception.DeletePatient(BN_ID);
                RefreshList(0);
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                int BN_ID = int.Parse(this.DataGridViewPatientList.Rows[selectedRowIndex].Cells[0].Value.ToString());
                // Create and show the new child form (PatientRegistation)

                if (Application.OpenForms["Reception"].Controls["mainPanelReception"].Controls.Count != 0)
                {
                    Application.OpenForms["Reception"].Controls["mainPanelReception"].Controls.Clear();
                }

                // Add new subform after clearing
                PatientRegistation patientRegist = new PatientRegistation(BN_ID);
                patientRegist.TopLevel = false;
                Application.OpenForms["Reception"].Controls["mainPanelReception"].Controls.Add(patientRegist);
                patientRegist.Dock = DockStyle.Fill;
                patientRegist.Show();
                this.Close();
                this.Dispose();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Name.Texts = "";
            DoB.Value = DateTime.Now;
            Sex.SelectedIndex = -1;
            RefreshList(1);
        }
    }
}
