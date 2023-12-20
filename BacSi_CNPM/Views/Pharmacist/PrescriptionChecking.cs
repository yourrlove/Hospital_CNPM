using BussinessLogicTier;
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
using static DataAccessTier.ChiTietHoaDonDBContext;

namespace Hospital.Views.Pharmacist
{
    public partial class PrescriptionChecking : Form
    {
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();

        private System.Windows.Forms.BindingSource bindingSource1 = new System.Windows.Forms.BindingSource();
        private PharmacistBUS pharmacist;
        public PrescriptionChecking()
        {
            pharmacist = PharmacistBUS.GetInstance();
            InitializeComponent();
            LoadNotRecievedPrescription();
        }

        private void LoadNotRecievedPrescription()
        {
            bindingSource.DataSource = pharmacist.ListHoaDon();
            this.dtgv_notRecieved.AutoGenerateColumns = true;
            this.dtgv_notRecieved.DataSource = bindingSource;
            this.dtgv_notRecieved.BorderStyle = BorderStyle.Fixed3D;
            this.dtgv_notRecieved.AllowUserToAddRows = false;
        }

        Current1 curr = new Current1();
        private void dtgv_notRecieved_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = dtgv_notRecieved.Rows[e.RowIndex].Cells[0].Value;
            var cellValue1 = dtgv_notRecieved.Rows[e.RowIndex].Cells[1].Value;
            if (cellValue != null)
            {
                curr.BN_ID = Convert.ToInt32(cellValue1);
                curr.HD_ID = Convert.ToInt32(cellValue);

                BindingList<HoaDonTonKho> list = this.bindingSource1.DataSource as BindingList<HoaDonTonKho>;
                bindingSource1.DataSource = pharmacist.getHoaDonTonkho(curr.HD_ID);
                this.dtgv_Updated.AutoGenerateColumns = true;
                this.dtgv_Updated.DataSource = bindingSource1;
            }
        }

        private void btn_reciept_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> items = pharmacist.UpdateItem(curr.HD_ID);
            BindingList<HoaDonTonKho> list = this.bindingSource1.DataSource as BindingList<HoaDonTonKho>;

            pharmacist.UpdateQuantity(items);

            foreach (var item in items)
            {
                HoaDonTonKho existingItem = list.FirstOrDefault(i => i.th_id == item.Key);

                if (existingItem != null)
                {
                    // Item already exists in the list, update quantity
                    existingItem.TonKho += item.Value;
                }
                else
                {
                    // Item doesn't exist, add a new one
                    HoaDonTonKho newItem = new HoaDonTonKho
                    {
                        th_id = item.Key,
                        TonKho = item.Value
                    };

                    list.Add(newItem);
                }
            }
            this.bindingSource1.DataSource = list;
            this.dtgv_Updated.DataSource = this.bindingSource1;

            pharmacist.deleteRecord(curr.BN_ID, curr.HD_ID);
            LoadNotRecievedPrescription();
        }
    }
}
