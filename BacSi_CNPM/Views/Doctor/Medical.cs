using BusinessLogicTier;
using DataAccessTier;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.IdentityModel.Tokens;
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
        DoctorRoomBUS room;
        System.Windows.Forms.BindingSource binding;
        List<PatientRecord> data = new List<PatientRecord>();
        public Medical()
        {
            room = new DoctorRoomBUS();
            binding = new System.Windows.Forms.BindingSource();
            InitializeComponent();
            Load_DatagrigView_Records();
        }

        void Load_DatagrigView_Records()
        {
            data = room.GetPatientRecords(4);
            binding.DataSource = data;
            //bind datagridview to binding source
            dgvRecords.DataSource = binding;
            this.recordCount.Text = data.Count().ToString();
        }


        private void Medical_Load(object sender, EventArgs e)
        {
            Load_DatagrigView_Records();

        }
        private void dgvRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox_Search_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox_Search.PlaceholderText != "")
            {
                var foundData = room.FindPatientRecords(guna2TextBox_Search.Text, 2);
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
    }
}
