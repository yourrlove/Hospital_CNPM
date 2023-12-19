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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hospital.Views.Doctor
{
    public partial class Medical : Form
    {

        private DoctorRoomBUS room;
        private System.Windows.Forms.BindingSource binding;
        private List<PatientRecord> data = new List<PatientRecord>();
        private int selectedIndex;
        public Medical()
        {
            room = DoctorRoomBUS.GetInstance();
            binding = new System.Windows.Forms.BindingSource();
            selectedIndex = 0;
            InitializeComponent();
            Load_DatagrigView_Records();
        }

        void Load_DatagrigView_Records()
        {
            data = room.GetPatientRecords(room.KH_ID);
            binding.DataSource = data;
            //bind datagridview to binding source
            dgvRecords.DataSource = binding;
            this.recordCount.Text = data.Count().ToString();
        }


        private void guna2TextBox_Search_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox_Search.PlaceholderText != "")
            {
                var foundData = room.FindPatientRecords(guna2TextBox_Search.Text, room.KH_ID);
                this.recordCount.Text = foundData.Count().ToString();
                binding.DataSource = foundData;
                dgvRecords.DataSource = binding;

            }
            else
            {
                binding.DataSource = data;
                dgvRecords.DataSource = binding;
            }

        }

        private void dgvRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(selectedIndex > 0 && dgvRecords.Rows[selectedIndex].Cells[0].Value != null)
            {
                room.BA_ID = (int)dgvRecords.Rows[selectedIndex].Cells[0].Value;
                showMiddleForm(new MedicalRecord());
            }

        }

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
                    fm.Show();
                    showForm.StartPosition = FormStartPosition.CenterScreen;
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

        private void dgvRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                selectedIndex = e.RowIndex;
            }
        }
    }
}
