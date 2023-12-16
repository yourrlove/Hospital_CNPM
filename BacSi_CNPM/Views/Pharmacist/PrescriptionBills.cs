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
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Syncfusion.Pdf.Tables;


using static DataAccessTier.ChiTietDonThuocDBContext;



namespace Hospital.Views.Pharmacist
{
    public partial class PrescriptionBills : Form
    {
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.BindingSource bindingSource1 = new System.Windows.Forms.BindingSource();

        Current curr = new Current();
        public PrescriptionBills(int DT_ID, int BN_ID)
        {
            curr.patient = BN_ID;
            curr.DT_ID = DT_ID;
            InitializeComponent();
            LoadChiTietDonThuoc(DT_ID);
        }


        /// <summary>
        /// Load the details of each prescription
        /// </summary>
        /// <param name="DT_ID"></param>
        public void LoadChiTietDonThuoc(int DT_ID)
        {
            // curr.DT_ID = DT_ID;
            tendt.Text = ChiTietDonThuocDBContext.TenDon(DT_ID);
            try
            {

                bindingSource.DataSource = ChiTietDonThuocDBContext.LoadDonThuoc(DT_ID);
                this.dtgv_Presciption.DataSource = bindingSource;
                this.dtgv_Presciption.AutoGenerateColumns = true;
                this.dtgv_Presciption.BorderStyle = BorderStyle.Fixed3D;

                //this.dtgv_Presciption.Columns[0].Visible = false;
                //this.dtgv_Presciption.Columns[1].Visible = false;

                LoadBill(DT_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Display the Bill of medicine of patient based of the prescription ID
        /// </summary>
        /// <param name="DT_ID"></param>
        public void LoadBill(int DT_ID)
        {
            bill_name.Text = "Bill " + ChiTietDonThuocDBContext.TenDon(DT_ID);
            try
            {
                bindingSource1.DataSource = ChiTietDonThuocDBContext.Kiemtradonthuoc(DT_ID);
                this.dtgv_bill.DataSource = bindingSource1;
                this.dtgv_bill.AutoGenerateColumns = true;
                this.dtgv_bill.BorderStyle = BorderStyle.Fixed3D;

                //this.dtgv_bill.Columns[0].Visible = false;
                //this.dtgv_bill.Columns[1].Visible = false;

                TongTien_text.Text = Convert.ToString(TongTien(DT_ID));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Display the total price of the bill
        /// </summary>
        /// <param name="DT_ID"></param>
        /// <returns></returns>
        public double TongTien(int DT_ID)
        {
            double tongtien = 0;
            BindingList<donthuocLoaded> HoaDon = ChiTietDonThuocDBContext.Kiemtradonthuoc(DT_ID);
            foreach (var i in HoaDon)
            {
                double gia = ThuocDBContext.getGiaBanThuoc(i.TH_ID);
                double dongia = Convert.ToDouble(i.SoLuong) * gia;
                tongtien += dongia;
            }
            return tongtien;
        }
        /// <summary>
        /// The button has many events
        ///     1. Create the bill
        ///     2. Create details of bill (medicines) instance
        ///     3. Adding the details of bill in database of pharmacist to prepare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void print_btn_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime NgayLap = DateTime.Now;
                double tongtien = TongTien(curr.DT_ID);
                int TN_ID = 1;
                int BN_ID = curr.patient;
                MessageBox.Show(Convert.ToString("benh Nhan" + BN_ID));
                HoaDonDBContext.addHoaDon(NgayLap, tongtien, TN_ID, BN_ID);

                int HD_ID = HoaDonDBContext.getLastHD_ID();
                //int DT_ID = curr.DT_ID+1;
                MessageBox.Show(Convert.ToString("Hoa Don" + HD_ID));
                BindingList<donthuocLoaded> HoaDon = ChiTietDonThuocDBContext.Kiemtradonthuoc(curr.DT_ID);


                foreach (var i in HoaDon)
                {
                    double gia = ThuocDBContext.getGiaBanThuoc(i.TH_ID);

                    int hd_id = HD_ID;
                    int th_id = i.TH_ID;
                    int soluong = i.SoLuong;
                    ThuocDBContext.updateSoLuongThuoc(th_id, soluong);
                    double dongia = Convert.ToDouble(i.SoLuong) * gia;
                    MessageBox.Show(Convert.ToString("Thuoc " + th_id));
                    ChiTietHoaDonDBContext.addChiTietHoaDon(hd_id, th_id, soluong, dongia);
                }


                HoaDonDuocSiDBContext.addHoaDon(HD_ID, BN_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uC_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.Left = Left - 200;
            printPreviewDialog1.Top = Top;
            printPreviewDialog1.Width = 800;
            printPreviewDialog1.Height = 1600;

            DialogResult result = printPreviewDialog1.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                string fileName = $"Document_{DateTime.Now.ToString("yyyyMMddHHmmss")}.pdf";

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.ShowDialog();
                    this.Activate();
                }
            }
            this.Close();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font normalFont = new Font("times new roman", 15, FontStyle.Regular);
            Font headingFont = new Font("times new roman", 20, FontStyle.Bold);
            Font headertable = new Font("times new roman", 15, FontStyle.Bold);
            Font ita = new Font("times new roman", 15, FontStyle.Italic);

            StringFormat rightAlignFormat = new StringFormat();
            rightAlignFormat.Alignment = StringAlignment.Far;

            string[] lines = {
                "Benh Vien Hoan My",
                "Dia Chi: 79/12 Thien Duong Vinh Cuu",
                "Hotline: 1900 8067",
                "Website: hoanmithienduong.vn"
            };

            List<BenhNhan> listBenhNhan = BenhNhanDBContext.getPatientName(curr.patient);
            List<donthuocLoaded> donthuoc = ChiTietDonThuocDBContext.Kiemtradonthuoc(curr.DT_ID).ToList();
            BenhNhan benhnhan = listBenhNhan.FirstOrDefault();

            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Far;

            // Set margin
            int centerPoint = 330;
            int leftMargin = 50;
            int topMargin = 50;
            int regionHeight = 100;
            int rightMargin = 10;

            foreach (string line in lines)
            {
                e.Graphics.DrawString(line, normalFont, Brushes.Black, new RectangleF(450, topMargin, 350, 30), format);
                topMargin += 30;
            }

            int centerY = topMargin + 50 + (regionHeight - topMargin) / 2;
            // e.Graphics.DrawRectangle(Pens.White, 120, 120, 120, 120);

            var image = (Image)Hospital.Properties.Resources.ResourceManager.GetObject("logo");
            e.Graphics.DrawImage(image, new RectangleF(100, 40, 150, 150));


            e.Graphics.DrawString("DON THUOC", headingFont, Brushes.Black, new Point(centerPoint, centerY));
            e.Graphics.DrawString(" ~~~~*~~~~", headingFont, Brushes.Black, new Point(centerPoint + 15, centerY + 40));


            // Print patient information
            e.Graphics.DrawString($"Ho Ten: {benhnhan.HoTen}", normalFont, Brushes.Black, new Point(leftMargin, centerY + 120));
            e.Graphics.DrawString($"Ngay Sinh: {benhnhan.NgaySinh.ToShortDateString()}", normalFont, Brushes.Black, new Point(leftMargin, centerY + 160));
            e.Graphics.DrawString($"Can nang: 1000kg", normalFont, Brushes.Black, new Point(300 + leftMargin, centerY + 160));
            e.Graphics.DrawString($"Gioi tinh: {benhnhan.GioiTinh}", normalFont, Brushes.Black, new Point(500 + leftMargin, centerY + 160));
            e.Graphics.DrawString($"Dia Chi: {benhnhan.DiaChi}", normalFont, Brushes.Black, new Point(leftMargin, centerY + 200));
            e.Graphics.DrawString($"Chan Doan: ", normalFont, Brushes.Black, new Point(leftMargin, centerY + 240));

            // Draw a table for prescription information
            int tableX = leftMargin;
            int tableY = centerY + 280;
            int cellWidth = 150;
            int cellHeight = 30;


            // Draw table header
            e.Graphics.DrawRectangle(Pens.Black, tableX, tableY, cellWidth, cellHeight);
            e.Graphics.DrawString("Tên Thuốc", headertable, Brushes.Black, new RectangleF(tableX, tableY, cellWidth, cellHeight));

            e.Graphics.DrawRectangle(Pens.Black, tableX + cellWidth, tableY, cellWidth, cellHeight);
            e.Graphics.DrawString("Giá Bán", headertable, Brushes.Black, new RectangleF(tableX + cellWidth, tableY, cellWidth, cellHeight));

            e.Graphics.DrawRectangle(Pens.Black, tableX + 2 * cellWidth, tableY, cellWidth, cellHeight);
            e.Graphics.DrawString("Số Lượng", headertable, Brushes.Black, new RectangleF(tableX + 2 * cellWidth, tableY, cellWidth, cellHeight));

            e.Graphics.DrawRectangle(Pens.Black, tableX + 3 * cellWidth, tableY, cellWidth, cellHeight);
            e.Graphics.DrawString("Liều Dùng", headertable, Brushes.Black, new RectangleF(tableX + 3 * cellWidth, tableY, cellWidth, cellHeight));

            e.Graphics.DrawRectangle(Pens.Black, tableX + 4 * cellWidth, tableY, cellWidth, cellHeight);
            e.Graphics.DrawString("Thành Tiền", headertable, Brushes.Black, new RectangleF(tableX + 4 * cellWidth, tableY, cellWidth, cellHeight));

            int height = centerY + 240;
            double totalbill = 0;
            // Draw table rows
            for (int i = 0; i < donthuoc.Count; i++)
            {
                e.Graphics.DrawRectangle(Pens.Black, tableX, tableY + (i + 1) * cellHeight, cellWidth, cellHeight);
                e.Graphics.DrawString(donthuoc[i].TenThuoc, normalFont, Brushes.Black, new RectangleF(tableX, tableY + (i + 1) * cellHeight, cellWidth, cellHeight));

                e.Graphics.DrawRectangle(Pens.Black, tableX + cellWidth, tableY + (i + 1) * cellHeight, cellWidth, cellHeight);
                e.Graphics.DrawString(Convert.ToString(donthuoc[i].DonGia), normalFont, Brushes.Black, new RectangleF(tableX + cellWidth, tableY + (i + 1) * cellHeight, cellWidth, cellHeight));

                e.Graphics.DrawRectangle(Pens.Black, tableX + 2 * cellWidth, tableY + (i + 1) * cellHeight, cellWidth, cellHeight);
                e.Graphics.DrawString(Convert.ToString(donthuoc[i].SoLuong), normalFont, Brushes.Black, new RectangleF(tableX + 2 * cellWidth, tableY + (i + 1) * cellHeight, cellWidth, cellHeight));

                e.Graphics.DrawRectangle(Pens.Black, tableX + 3 * cellWidth, tableY + (i + 1) * cellHeight, cellWidth, cellHeight);
                e.Graphics.DrawString(donthuoc[i].LieuDung, normalFont, Brushes.Black, new RectangleF(tableX + 3 * cellWidth, tableY + (i + 1) * cellHeight, cellWidth, cellHeight));

                e.Graphics.DrawRectangle(Pens.Black, tableX + 4 * cellWidth, tableY + (i + 1) * cellHeight, cellWidth, cellHeight);
                e.Graphics.DrawString(Convert.ToString(donthuoc[i].DonGia * donthuoc[i].SoLuong), normalFont, Brushes.Black, new RectangleF(tableX + 4 * cellWidth, tableY + (i + 1) * cellHeight, cellWidth, cellHeight));

                height = tableY + (i + 1) * cellHeight;
                totalbill += donthuoc[i].DonGia * donthuoc[i].SoLuong;
            }

            e.Graphics.DrawString($"Tong Tien:", headertable, Brushes.Black, new Point(500, height + 70));
            e.Graphics.DrawString($"{Convert.ToString(totalbill)} (dong)", normalFont, Brushes.Black, new Point(620, height + 70));
            e.Graphics.DrawString($"Ngay {DateTime.Now.Date}", normalFont, Brushes.Black, new Point(500, height + 100));
            e.Graphics.DrawString("Chu ki bac si", headertable, Brushes.Black, new Point(570, height + 130));
            e.Graphics.DrawString("(Ghi ro ho ten)", ita, Brushes.Black, new Point(570, height + 160));

            e.Graphics.DrawString("Kham lai xin mang theo giay nay", normalFont, Brushes.Black, new Point(leftMargin, height + 250));
            e.Graphics.DrawString("So dien thoai lien he: 1900 6067", normalFont, Brushes.Black, new Point(leftMargin, height + 280));

        }

    }
}
