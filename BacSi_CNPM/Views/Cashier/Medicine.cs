using BusinessLogicTier;
using DataAccessTier;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Views.Cashier
{
    public partial class Medicine_details : Form
    {
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        private CashierBUS cashier;
        public Medicine_details()
        {
            cashier = CashierBUS.GetInstance();
            InitializeComponent();
            LoadThuoc();
            panel_medicineDetail.Visible = false;
        }

        Current curr = new Current();

        /// <summary>
        /// Load the prescription list in the datagridview
        /// </summary>
        private void LoadThuoc()
        {
            try
            {
                this.dtgv_medicine.AutoGenerateColumns = true;
                bindingSource.DataSource = cashier.GetThuoc();
                this.dtgv_medicine.DataSource = bindingSource;
                this.dtgv_medicine.BorderStyle = BorderStyle.Fixed3D;


                this.dtgv_medicine.Columns[3].Visible = false;
                this.dtgv_medicine.Columns[4].Visible = false;
                this.dtgv_medicine.Columns[5].Visible = false;
                this.dtgv_medicine.Columns[6].Visible = false;
                this.dtgv_medicine.Columns[7].Visible = false;
                this.dtgv_medicine.Columns[8].Visible = false;
                this.dtgv_medicine.Columns[9].Visible = false;

                this.dtgv_medicine.AllowUserToAddRows = false;

            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// Searching the medicine and display realtime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_medicine_TextChanged(object sender, EventArgs e)
        {
            if (search_medicine.Text != "")
            {
                dtgv_medicine.DataSource = cashier.SearchThuoc(search_medicine.Text);
            }
            else
            {

            }
        }

        private void dtgv_medicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dtgv_medicine.Rows.Count)
            {
                var cellValue = dtgv_medicine.Rows[e.RowIndex].Cells[0].Value;
                // MessageBox.Show("Thuoc ID " + Convert.ToString(cellValue));
                if (cellValue != null)
                {
                    curr.TH_ID = Convert.ToInt32(cellValue);
                    var image = cashier.LoadImage(curr.TH_ID);
                    if (image != null)
                    {
                        // Assuming you have a PictureBox named pictureBox
                        medicine_box.Image = image;

                    }
                }
            }

            tenthuoc.Text = dtgv_medicine.Rows[e.RowIndex].Cells[1].Value.ToString().ToUpper();
            giaban.Text = dtgv_medicine.Rows[e.RowIndex].Cells[2].Value.ToString() + "dong";
            soluong.Text = dtgv_medicine.Rows[e.RowIndex].Cells[3].Value.ToString();
            ngaynhap.Text = dtgv_medicine.Rows[e.RowIndex].Cells[4].Value.ToString();
            ngayhethan.Text = dtgv_medicine.Rows[e.RowIndex].Cells[5].Value.ToString();
            chongchidinh.Text = dtgv_medicine.Rows[e.RowIndex].Cells[6].Value.ToString();
            xuatxu.Text = dtgv_medicine.Rows[e.RowIndex].Cells[7].Value.ToString();
            tacdungjphu.Text = dtgv_medicine.Rows[e.RowIndex].Cells[8].Value.ToString();

            panel_medicineDetail.Visible = true;
        }
    }
}
