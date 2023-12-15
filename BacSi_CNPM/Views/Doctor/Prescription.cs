using BusinessLogicTier;
using DataAccessTier;
using DTO;
using Microsoft.EntityFrameworkCore.ValueGeneration;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital.Views.Doctor
{

    public partial class Prescription : Form
    {
        private string BS_ID;
        
        
        
        private DoctorRoomBUS room;
        private List<Thuoc> data;
        private int selectedRowIndex_Medicine;
        private int selectedRowIndex_KeDon;
        private BindingList<Medicine> list;

        // This BindingSource binds the list to the DataGridView control.
        private BindingSource customersBindingSource = new BindingSource();

        public Prescription(int BN_ID)
        {
            room = new DoctorRoomBUS();
            list = new BindingList<Medicine>();
            //binding = new BindingSource();
            InitializeComponent();

        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            data = room.GetListThuoc();
            //binding.DataSource = data;
            this.guna2DataGridView_Medicines.DataSource = data;
            this.guna2DataGridView_Medicines.ClearSelection();
        }



        private void guna2TextBox_SearchMedicine_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox_SearchMedicine.Text != "")
            {
                List<Thuoc> foundData = room.SearchMedicines(guna2TextBox_SearchMedicine.Text);
                guna2DataGridView_Medicines.DataSource = foundData;
            }
            else
            {
                guna2DataGridView_Medicines.DataSource = data;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void uC_Button_Delete_Click(object sender, EventArgs e)
        {
            // Get a reference to the list from the BindingSource.
            BindingList<Medicine> list = this.customersBindingSource.DataSource as BindingList<Medicine>;
            list.RemoveAt(selectedRowIndex_KeDon);
        }

        private void guna2DataGridView_Medicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in a valid row (not header or empty space).
            if (e.RowIndex >= 0)
            {
                // Store the selected row index.
                selectedRowIndex_Medicine = e.RowIndex;
            }
        }

        private void uC_Button4_Click(object sender, EventArgs e)
        {
            var newItem = new Medicine()
            {
                Name = guna2DataGridView_Medicines.Rows[selectedRowIndex_Medicine].Cells[0].Value.ToString(),
                Quantity = int.Parse(guna2TextBox_Quantity.Text),
                Buoi = guna2ComboBox_Buoi.Text,
            };

            if (list.Any(item => item.Name == newItem.Name))
            {
                // Get a reference to the list from the BindingSource.
                BindingList<Medicine> list = this.customersBindingSource.DataSource as BindingList<Medicine>;
                var toUpdate = list.FirstOrDefault(item => item.Name == newItem.Name);
                if (toUpdate != null)
                {
                    toUpdate.Buoi = newItem.Buoi;
                    toUpdate.Quantity = newItem.Quantity;
                }
            }
            else
            {
                list.Add(newItem);
                // Bind the list to the BindingSource.
                this.customersBindingSource.DataSource = list;

                // Attach the BindingSource to the DataGridView.
                this.guna2DataGridView_KeDon.DataSource = this.customersBindingSource;
            }
        }

        private void uC_Button_Save_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView_KeDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in a valid row (not header or empty space).
            if (e.RowIndex >= 0)
            {
                // Store the selected row index.
                selectedRowIndex_KeDon = e.RowIndex;
            }
        }
    }
}
