using DataAccessTier;
using DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
    public partial class SearchMedicine : Form
    {

        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        public SearchMedicine()
        {
            InitializeComponent();
            LoadThuoc();
            medicineDetailsForm.Visible = false;
        }
        Current curr = new Current();
        /// <summary>
        /// Using binding list to display the list medicines in the datagrid view
        /// </summary>
        private void LoadThuoc()
        {
            try
            {
                this.dtgv_SearchMedicine.AutoGenerateColumns = true;
                bindingSource.DataSource = ThuocDBContext.GetThuoc();
                this.dtgv_SearchMedicine.DataSource = bindingSource;
                this.dtgv_SearchMedicine.BorderStyle = BorderStyle.Fixed3D;

                this.dtgv_SearchMedicine.Columns[3].Visible = false;
                this.dtgv_SearchMedicine.Columns[4].Visible = false;
                this.dtgv_SearchMedicine.Columns[5].Visible = false;
                this.dtgv_SearchMedicine.Columns[6].Visible = false;
                this.dtgv_SearchMedicine.Columns[7].Visible = false;
                this.dtgv_SearchMedicine.Columns[8].Visible = false;
                this.dtgv_SearchMedicine.Columns[9].Visible = false;
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// Search the item base and display the result real time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                dtgv_SearchMedicine.DataSource = ThuocDBContext.SearchThuoc(searchBox.Text);
            }
            else
            {

            }
        }

        private void dtgv_SearchMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = dtgv_SearchMedicine.Rows[e.RowIndex].Cells[0].Value;
            // MessageBox.Show("Thuoc ID " + Convert.ToString(cellValue));
            if (cellValue != null)
            {
                curr.TH_ID = Convert.ToInt32(cellValue);


                var image = ThuocDBContext.LoadImage(curr.TH_ID);
                if (image != null)
                {
                    // Assuming you have a PictureBox named pictureBox
                    picbox_medicineImage.Image = image;

                }
            }


            medicine_name.Text = dtgv_SearchMedicine.Rows[e.RowIndex].Cells[1].Value.ToString().ToUpper();
            giaban.Text = dtgv_SearchMedicine.Rows[e.RowIndex].Cells[2].Value.ToString() + " (dong)";
            tonkho.Text = dtgv_SearchMedicine.Rows[e.RowIndex].Cells[3].Value.ToString();
            ngaysx.Text = dtgv_SearchMedicine.Rows[e.RowIndex].Cells[4].Value.ToString();
            ngayhethan.Text = dtgv_SearchMedicine.Rows[e.RowIndex].Cells[5].Value.ToString();
            xuatxu.Text = dtgv_SearchMedicine.Rows[e.RowIndex].Cells[7].Value.ToString();
            chongchidinh.Text = dtgv_SearchMedicine.Rows[e.RowIndex].Cells[6].Value.ToString();
            tacdungphu.Text = dtgv_SearchMedicine.Rows[e.RowIndex].Cells[8].Value.ToString();

            medicineDetailsForm.Visible = true;

        }

        private void SearchMedicine_Load(object sender, EventArgs e)
        {

        }

        private void lb_tacdungphu_Click(object sender, EventArgs e)
        {

        }

        private void lb_xuatxu_Click(object sender, EventArgs e)
        {

        }

        private void picbox_medicineImage_Click(object sender, EventArgs e)
        {

        }

        private void lb_ngaynhan_Click(object sender, EventArgs e)
        {

        }
    }
}
