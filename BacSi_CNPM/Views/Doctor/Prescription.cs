using BusinessLogicTier;
using DataAccessTier;
using DTO;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private DoctorRoomBUS room;
        private List<ThuocDOC> data;
        private int selectedRowIndex_Medicine;
        private int selectedRowIndex_KeDon;
        private BindingList<DTO.ThuocDOC> list;

        // This BindingSource binds the list to the DataGridView control.
        private BindingSource customersBindingSource = new BindingSource();

        public Prescription(int BN_ID)
        {
            room = DoctorRoomBUS.GetInstance();
            list = new BindingList<ThuocDOC>();
            //binding = new BindingSource();
            InitializeComponent();
            data = room.GetListThuoc();
            //binding.DataSource = data;
            this.guna2DataGridView_Medicines.DataSource = data;
            this.guna2DataGridView_Medicines.ClearSelection();

            if (!room.temp1.list.IsNullOrEmpty())
            {
                list.Clear();
                foreach (var item in room.temp1.list)
                {
                    list.Add(item);
                }
                // Bind the list to the BindingSource.
                this.customersBindingSource.DataSource = list;

                // Attach the BindingSource to the DataGridView.
                this.guna2DataGridView_KeDon.DataSource = this.customersBindingSource;
            }
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

        private void uC_Button_Delete_Click(object sender, EventArgs e)
        {
            // Get a reference to the list from the BindingSource.
            BindingList<DTO.ThuocDOC> list = this.customersBindingSource.DataSource as BindingList<DTO.ThuocDOC>;
            list.RemoveAt(selectedRowIndex_KeDon);
        }

        private void guna2DataGridView_Medicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in a valid row (not header or empty space).
            if (e.RowIndex >= 0)
            {
                // Store the selected row index.
                selectedRowIndex_Medicine = e.RowIndex;
                int TH_ID = (int)guna2DataGridView_Medicines.Rows[selectedRowIndex_Medicine].Cells[0].Value;
                var medicine = room.GetThuocDetail(TH_ID);
                NameMedicine.Text = $"Name: {medicine.TenThuoc}";
                Manufacturor.Text = $"Manufacturor: {medicine.XuatXu}";
                ManufatDate.Text = $"Manufaturing Date: {medicine.NgayNhap.ToString("dd/MM/yyyy")}";
                ExpireDay.Text = $"Expiry Date: {medicine.NgayHetHan.ToString("dd/MM/yyyy")}";
                contraindicated.Text = $"Contraindication: {medicine.ChongChiDinh}";
                SideEffect.Text = $"Side Effect: {medicine.TacDungPhu}";
                MedicineImage.Image = room.LoadImage(medicine.ImageData);
            }
        }

        private void uC_Button4_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Quantity.Text == "" || !int.TryParse(Quantity.Text, out int result))
            {
                Guna2TextBox textBox = (Guna2TextBox)this.Controls.Find("Quantity", true).FirstOrDefault();
                // Clear any existing error for the control before setting a new one
                errorProvider1.SetError(textBox, string.Empty);

                // Set the new error message for the control
                errorProvider1.SetError(textBox, "Please enter quantity!");
            }
            else
            {
                var newItem = new DTO.ThuocDOC()
                {
                    TH_ID = int.Parse(guna2DataGridView_Medicines.Rows[selectedRowIndex_Medicine].Cells[0].Value.ToString()),
                    Name = guna2DataGridView_Medicines.Rows[selectedRowIndex_Medicine].Cells[1].Value.ToString(),
                    Quantity = int.Parse(Quantity.Text),
                    Buoi = guna2ComboBox_Buoi.Text,
                };

                if (list.Any(item => item.Name == newItem.Name))
                {
                    // Get a reference to the list from the BindingSource.
                    BindingList<DTO.ThuocDOC> list = this.customersBindingSource.DataSource as BindingList<DTO.ThuocDOC>;
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
        }

        private void uC_Button_Save_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                room.temp1.list.Clear();
                foreach (var item in list)
                {
                    room.temp1.list.Add(item);
                }
                room.temp1.prescriptionName = TenDonThuoc.Text ?? "";
                room.temp1.createDate = NgayKeDon.Value;
                Notification.SucccessNotification("Save Successfully!");
            }
            else
            {
                Notification.ErrorNotification("Fail to save!");
            }
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

        private bool Validate()
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (TenDonThuoc.Text == "")
            {
                Guna2TextBox textBox = (Guna2TextBox)this.Controls.Find("TenDonThuoc", true).FirstOrDefault();
                // Clear any existing error for the control before setting a new one
                errorProvider1.SetError(textBox, string.Empty);

                // Set the new error message for the control
                errorProvider1.SetError(textBox, "Prescription name is required!");

                isValid = false;
            }
            return isValid;
        }

        private void guna2DataGridView_Medicines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
