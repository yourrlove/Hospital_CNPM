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
using Tulpep.NotificationWindow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital.Views.Receptionist
{

    public partial class ListPatient : Form
    {
        ReceptionBUS reception;
        private int selectedRowIndex = 0;
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
        //success pop up notification 
        private void successNotification()
        {
            PopupNotifier success = new PopupNotifier();
            success.Image = (Image)Properties.Resources.ResourceManager.GetObject("successcolor");
            success.BodyColor = Color.FromArgb(40, 167, 69);
            success.TitleText = "Delete Successfully!";
            success.TitleColor = Color.Black;
            success.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            success.ContentText = "Success!";
            success.ContentColor = Color.White;
            success.ContentFont = new Font("Century Gothic", 12);
            success.Popup();
        }
        private void warningNotification()
        {
            PopupNotifier warning = new PopupNotifier();
            warning.Image = (Image)Properties.Resources.ResourceManager.GetObject("errorcolor");
            warning.BodyColor = Color.FromArgb(220, 53, 69);
            warning.TitleText = "Warning!";
            warning.TitleColor = Color.Black;
            warning.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            warning.ContentText = "Failed!";
            warning.ContentColor = Color.White;
            warning.ContentFont = new Font("Century Gothic", 12);
            warning.Popup();
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
                if (flag == 0)
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
            successNotification();
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

        private void DataGridViewPatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_patientcount_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
