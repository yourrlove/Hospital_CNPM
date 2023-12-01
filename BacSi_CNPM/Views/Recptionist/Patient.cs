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
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Data.SqlClient;

namespace Hospital.Views.Receptionist
{
    public partial class ListPatient : Form
    {
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        public ListPatient()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            try
            {
                // Query Section !!! - Khong chinh sua phan cua DataGridViewPatientList

                // Automatically generate the DataGridView columns.
                this.DataGridViewPatientList.AutoGenerateColumns = true;
 

                // Set up the data source.
                bindingSource.DataSource = BenhNhanDBContext.GetListPatient();

                // Automatically resize the visible rows.   
                //this.DataGridViewPatientList.AutoSizeRowsMode =
                //    DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                // Set the DataGridView control's border.
                this.DataGridViewPatientList.BorderStyle = BorderStyle.Fixed3D;

                //
            }
            catch (SqlException)
            {
                MessageBox.Show("error");
            }
        }



        private void label1_patientnum_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListPatient_Load(object sender, EventArgs e)
        {

        }

    }
}
