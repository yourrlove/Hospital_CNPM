using BusinessLogicTier;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Views.Cashier
{
    public partial class FirstBill : Form
    {
        CashierBUS cashier;
        private int ph_id;
        private int bn_id;
        private bool isSave = false;
        private bool ispaid = false;
        private bool isOK = false;
        private string thanhtoan;

        public FirstBill(int BN_ID, string tenkhoa, string tenphong, string giakham, int PH_ID)
        {
            ph_id = PH_ID;
            bn_id = BN_ID;
            cashier = CashierBUS.GetInstance();
            InitializeComponent();
            LoadInfo(BN_ID, tenkhoa, tenphong, giakham);
        }

        private void LoadInfo(int BN_ID, string tenkhoa, string tenphong, string giakham)
        {
            phong.Text = tenphong;
            gia.Text = giakham;
            price.Text = giakham + " (dong)";
            gia.Text = giakham;
            khoa.Text = tenkhoa;

            List<BenhNhan> bn = cashier.getPatientName(BN_ID).ToList();
            BenhNhan patient = bn[0];
            patientName.Text = patient.HoTen.ToString();
            age.Text = patient.NgaySinh.ToShortDateString();
            so.Text = patient.SoDienThoai.ToString();
            gioitinh.Text = patient.GioiTinh.ToString();

        }

        private void btn_cash_Click_1(object sender, EventArgs e)
        {
            ispaid = true;
            thanhtoan = "Tien mat";
        }

        private void btn_banking_Click_1(object sender, EventArgs e)
        {
            thanhtoan = "Internet banking";
            ispaid = true;
            MessageBox.Show(thanhtoan);

            this.Hide();
            printPreviewDialog2.Document = printDocument2;

            printPreviewDialog2.Left = Left - 200;
            printPreviewDialog2.Top = Top;
            printPreviewDialog2.Width = 800;
            printPreviewDialog2.Height = 1600;

            DialogResult result = printPreviewDialog2.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                string fileName = $"Document_{DateTime.Now.ToString("yyyyMMddHHmmss")}.pdf";

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.ShowDialog();
                    this.Activate();
                }
            }
            this.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isSave == false && ispaid == true)
            {
                cashier.AssignPatient(bn_id, ph_id);
                double giakham = Convert.ToDouble(gia.Text);
                cashier.addHoaDon(DateTime.Now, giakham, cashier.TN_ID, bn_id, thanhtoan);
                isSave = true;
            }
            else if(ispaid == false)
            {
                MessageBox.Show("Please choose payment methods");
            }
        }

        private void print_Click_1(object sender, EventArgs e)
        {
            if (isSave == true && ispaid == true)
            {

                this.Hide();
                printPreviewDialog2.Document = printDocument1;

                printPreviewDialog2.Left = Left - 200;
                printPreviewDialog2.Top = Top;
                printPreviewDialog2.Width = 800;
                printPreviewDialog2.Height = 1600;

                DialogResult result = printPreviewDialog2.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    string fileName = $"Document_{DateTime.Now.ToString("yyyyMMddHHmmss")}.pdf";

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.ShowDialog();
                        this.Activate();
                    }
                }
                cashier.DeleteDonKham(bn_id);
                //this.Show();
            }
            else
            {
                MessageBox.Show("Please choose the payment methods or save the record");
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
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
                "Hotline: 1900 6067",
                "Website: hoanmithienduong.vn"
            };

            List<BenhNhan> listBenhNhan = cashier.getPatientName(bn_id);
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


            e.Graphics.DrawString("HOA DON KHAM BENH", headingFont, Brushes.Black, new Point(centerPoint - 50, centerY));
            e.Graphics.DrawString(" ~~~~*~~~~", headingFont, Brushes.Black, new Point(centerPoint + 15, centerY + 40));


            // Print patient information
            e.Graphics.DrawString($"Ho Ten: {benhnhan.HoTen}", normalFont, Brushes.Black, new Point(leftMargin, centerY + 120));
            e.Graphics.DrawString($"Ngay Sinh: {benhnhan.NgaySinh.ToShortDateString()}", normalFont, Brushes.Black, new Point(leftMargin, centerY + 160));
            e.Graphics.DrawString($"Can nang: {benhnhan.CanNang}", normalFont, Brushes.Black, new Point(300 + leftMargin, centerY + 160));
            e.Graphics.DrawString($"Gioi tinh: {benhnhan.GioiTinh}", normalFont, Brushes.Black, new Point(500 + leftMargin, centerY + 160));
            e.Graphics.DrawString($"Dia Chi: {benhnhan.DiaChi}", normalFont, Brushes.Black, new Point(leftMargin, centerY + 200));


            e.Graphics.DrawString($"Moi ban di chuyen toi phong so: {phong.Text}", normalFont, Brushes.Black, new Point(leftMargin, centerY + 250));
            e.Graphics.DrawString($"Khoa: {khoa.Text}", normalFont, Brushes.Black, new Point(leftMargin + 500, centerY + 250));
            e.Graphics.DrawString($"Gia kham benh: {gia.Text}  (dong)", normalFont, Brushes.Black, new Point(leftMargin, centerY + 300));
            e.Graphics.DrawString($"Thu Ngan: {cashier.TN_ID} ", normalFont, Brushes.Black, new Point(leftMargin+200, centerY + 350));
            int height = centerY + 240;

            DateTime myDateTime = DateTime.Now;

            e.Graphics.DrawString($"Ngay {myDateTime.ToString("yyyy-MM-dd HH:mm:ss")}", normalFont, Brushes.Black, new Point(500, height + 100));
            e.Graphics.DrawString($"Xin chan thanh cam on quy khach", ita, Brushes.Black, new Point(leftMargin + 150, height + 200));

        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
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

            List<BenhNhan> listBenhNhan = cashier.getPatientName(bn_id);
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

            var image = (Image)Hospital.Properties.Resources.ResourceManager.GetObject("logo");
            e.Graphics.DrawImage(image, new RectangleF(100, 40, 150, 150));


            e.Graphics.DrawString("MOI BAN QUET MA", headingFont, Brushes.Black, new Point(centerPoint, centerY));

            DateTime myDateTime = DateTime.Now;
            DateTime adjustedDateTime = myDateTime.AddMinutes(3);

            e.Graphics.DrawString($"Ma QR co thoi han den: {adjustedDateTime.ToString("yyyy-MM-dd HH:mm:ss")}", normalFont, Brushes.Black, new Point(100, 250));
            e.Graphics.DrawString($"Thu Ngan: {cashier.TN_ID}", normalFont, Brushes.Black, new Point(100, 250));
            e.Graphics.DrawString($"Tong Tien:", headertable, Brushes.Black, new Point(100, 280));
            string totalbill = gia.Text.ToString();
            e.Graphics.DrawString($"{Convert.ToString(totalbill)} (dong)", headertable, Brushes.Black, new Point(250, 280));
            var qrcode = (Image)Hospital.Properties.Resources.ResourceManager.GetObject("QR");
            e.Graphics.DrawImage(qrcode, new RectangleF(200, 400, 400, 500));
        }
    }
}
