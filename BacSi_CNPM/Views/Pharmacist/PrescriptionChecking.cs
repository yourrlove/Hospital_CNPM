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

namespace Hospital.Views.Pharmacist
{
    public partial class PrescriptionChecking : Form
    {
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();

        private System.Windows.Forms.BindingSource bindingSource1 = new System.Windows.Forms.BindingSource();

        public PrescriptionChecking()
        {
            InitializeComponent();
            LoadNotRecievedPrescription();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadNotRecievedPrescription()
        {
            bindingSource.DataSource = DonePrescriptionDBContext.ListHoaDon();
            this.dtgv_notRecieved.AutoGenerateColumns = true;
            this.dtgv_notRecieved.DataSource = bindingSource;
            this.dtgv_notRecieved.BorderStyle = BorderStyle.Fixed3D;
        }

        Current curr = new Current();
        private void dtgv_notRecieved_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = dtgv_notRecieved.Rows[e.RowIndex].Cells[0].Value;
            var cellValue1 = dtgv_notRecieved.Rows[e.RowIndex].Cells[1].Value;
            if (cellValue != null)
            {
                curr.BN_ID = Convert.ToInt32(cellValue1);
                curr.HD_ID = Convert.ToInt32(cellValue);

                bindingSource1.DataSource = ChiTietHoaDonDBContext.getHoaDon(curr.HD_ID);
                this.dtgv_Updated.AutoGenerateColumns = true;
                this.dtgv_Updated.DataSource = bindingSource1;
                this.dtgv_Updated.BorderStyle = BorderStyle.Fixed3D;

            }
        }

        private void btn_reciept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hell");
            MessageBox.Show($"{curr.BN_ID.ToString()}" + $"{curr.HD_ID.ToString()}");
            Dictionary<int, int> item = ThuocDBContext.UpdateItem(curr.BN_ID, curr.HD_ID);
            ThuocDBContext.UpdateQuantity(item);

        }

        private void dtgv_notRecieved_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
