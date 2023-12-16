using BusinessLogicTier;
using DTO;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hospital.Views.Receptionist
{
    public partial class PatientRegistation : Form
    {
        private bool isUnderlined = false; //tạo biến bool khi nào sử dụng underline
        private ReceptionBUS reception;
        private Dictionary<int, string> specialists, rooms;
        private BenhAn record;
        private BenhNhan patient;
        private int KH_ID, PH_ID, BN_ID;

        public PatientRegistation()
        {
            InitializeComponent();
            reception = new ReceptionBUS();
            specialists = rooms = new Dictionary<int, string>();
            record = new BenhAn();
            patient = new BenhNhan();
            KH_ID = PH_ID = BN_ID = -1;
        }

        public PatientRegistation(int BN_ID)
        {
            InitializeComponent();
            reception = new ReceptionBUS();
            specialists = rooms = new Dictionary<int, string>();
            record = new BenhAn();
            patient = new BenhNhan();
            KH_ID = PH_ID = -1;
            this.BN_ID = BN_ID;

            if (BN_ID > 0)
            {

                BenhNhan patient = reception.GetBenhNhan(BN_ID);
                HoTen.Text = patient.HoTen;
                Nu.Checked = (patient.GioiTinh == "Nu");
                Nam.Checked = (patient.GioiTinh == "Nam");
                NgaySinh.Value = patient.NgaySinh;
                DiaChi.Text = patient.DiaChi;
                SoDienThoai.Text = patient.SoDienThoai;
                ChieuCao.Text = patient.ChieuCao.ToString();
                CanNang.Text = patient.CanNang.ToString();
                NhomMau.SelectedItem = patient.NhomMau.ToString();
            }
        }

        private void PatientDetail_Load(object sender, EventArgs e)
        {
            rooms = reception.GetALLRoomID();
            specialists = reception.GetSpecialistInfor();
            foreach (var specialist in specialists)
            {
                this.TenKhoa.Items.Add(specialist.Value);
            }
        }

        private void uC_Button_Save_Click(object sender, EventArgs e)
        {

            string sex;
            if (Nu.Checked)
            {
                sex = "Nu";
            }
            else
            {
                sex = "Nam";
            }

            string nameInput = HoTen.Text;
            DateTime DoBInput = NgaySinh.Value;
            string telInput = SoDienThoai.Text;
            string addressInput = DiaChi.Text;

            //string 


            // Update the user instance with input values
            patient.HoTen = nameInput;
            patient.GioiTinh = sex;
            patient.SoDienThoai = telInput;
            patient.NgaySinh = DoBInput;
            patient.DiaChi = addressInput;

            // Clear any existing error messages
            errorProvider1.Clear();


            if (!Nu.Checked && !Nam.Checked)
            {
                // Clear any existing error for the control before setting a new one
                errorProvider1.SetError(Nu, "Please select your gender!");
            }

            if (this.TenKhoa.SelectedIndex == -1)
            {
                errorProvider1.SetError(TenKhoa, "Please select specialist!");
            }

            if (this.TenPhong.SelectedIndex == -1)
            {
                errorProvider1.SetError(TenPhong, "Please select room!");
            }

            // Validate the model using data annotations
            var results = new List<ValidationResult>();
            var context = new ValidationContext(patient, serviceProvider: null, items: null);
            bool isValid = Validator.TryValidateObject(patient, context, results, true);


            if (isValid)
            {
                PH_ID = rooms.FirstOrDefault(x => x.Value == this.TenPhong.Text).Key;
                reception.PatientRegistration(
                    patient,
                    this.ChieuCao.Text,
                    this.CanNang.Text,
                    this.NhomMau.Text,
                    this.TrieuChung.Text,
                    this.Ngay.Value,
                    PH_ID,
                    KH_ID
                    );
                successNotification();
            }
            else
            {
                // Display validation errors using ErrorProvider
                foreach (var result in results)
                {
                    string propertyName = result.MemberNames.FirstOrDefault();
                    Guna2TextBox textBox = (Guna2TextBox)this.Controls.Find(propertyName, true).FirstOrDefault();
                    if (textBox != null)
                    {
                        // Clear any existing error for the control before setting a new one
                        errorProvider1.SetError(textBox, string.Empty);

                        // Set the new error message for the control
                        errorProvider1.SetError(textBox, result.ErrorMessage);
                    }
                }
                warningNotification();

            }
        }



        private void uC_Button_Delete_Click(object sender, EventArgs e)
        {
            HoTen.Text = string.Empty;
            Nu.Checked = false;
            Nam.Checked = false;
            SoDienThoai.Text = string.Empty;
            NhomMau.Text = string.Empty;
            TenPhong.SelectedIndex = -1;
            TenKhoa.SelectedIndex = -1;
            NgaySinh.Value = DateTime.Now;
            ChieuCao.Text = string.Empty;
            DiaChi.Text = string.Empty;
            TrieuChung.Text = string.Empty;
            CanNang.Text = string.Empty;
            Ngay.Value = DateTime.Now;
            //dateTimePicker2.Value = DateTime.Now;
            successNotification();
        }

        private void guna2ComboBox_Specialist_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.TenPhong.Items.Clear();
            if (TenKhoa.SelectedIndex >= 0)
            {
                string specialist = this.TenKhoa.SelectedItem.ToString();
                KH_ID = specialists.FirstOrDefault(x => x.Value == specialist).Key;
                var data = reception.GetRoomInfor(KH_ID);
                foreach (var room in data)
                {
                    this.TenPhong.Items.Add(room.TenPhong);
                }
            }
        }

        private void panel_registerForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        #region event handle for text box

        //Text box Fullname
        private void HoTen_Paint(object sender, PaintEventArgs e)
        {
            if (isUnderlined)
            {
                using (Pen pen = new Pen(Color.RoyalBlue, 2)) // Define the color and thickness of the underline
                {
                    e.Graphics.DrawLine(pen, 0, HoTen.Height - 1, HoTen.Width, HoTen.Height - 1);
                }
            }
        }
        private void HoTen_Click(object sender, EventArgs e)
        {
            isUnderlined = true;
            HoTen.Invalidate(); //redraw the control
        }

        private void HoTen_Leave(object sender, EventArgs e)
        {
            isUnderlined = false;
            HoTen.Invalidate(); // Redraw the control
        }


        //Text box telephone
        private void SoDienThoai_Paint(object sender, PaintEventArgs e)
        {
            if (isUnderlined)
            {
                using (Pen pen = new Pen(Color.RoyalBlue, 2)) // Define the color and thickness of the underline
                {
                    e.Graphics.DrawLine(pen, 0, SoDienThoai.Height - 1, SoDienThoai.Width, SoDienThoai.Height - 1);
                }
            }
        }

        private void SoDienThoai_Leave(object sender, EventArgs e)
        {
            isUnderlined = false;
            SoDienThoai.Invalidate(); // Redraw the control
        }

        private void SoDienThoai_Click(object sender, EventArgs e)
        {
            isUnderlined = true;
            SoDienThoai.Invalidate(); // Redraw the control
        }


        //text box Address
        private void DiaChi_Paint(object sender, PaintEventArgs e)
        {
            if (isUnderlined)
            {
                using (Pen pen = new Pen(Color.RoyalBlue, 2)) // Define the color and thickness of the underline
                {
                    e.Graphics.DrawLine(pen, 0, DiaChi.Height - 1, DiaChi.Width, DiaChi.Height - 1);
                }
            }
        }

        private void DiaChi_Click(object sender, EventArgs e)
        {
            isUnderlined = true;
            DiaChi.Invalidate(); // Redraw the control
        }

        private void DiaChi_Leave(object sender, EventArgs e)
        {
            isUnderlined = false;
            DiaChi.Invalidate(); // Redraw the control
        }

        //make undeerline textbox for Sympton
        private void TrieuChung_Paint(object sender, PaintEventArgs e)
        {
            if (isUnderlined)
            {
                using (Pen pen = new Pen(Color.RoyalBlue, 2)) // Define the color and thickness of the underline
                {
                    e.Graphics.DrawLine(pen, 0, TrieuChung.Height - 1, TrieuChung.Width, TrieuChung.Height - 1);
                }
            }
        }

        private void TrieuChung_Click(object sender, EventArgs e)
        {
            isUnderlined = true;
            TrieuChung.Invalidate(); // Redraw the control
        }

        private void TrieuChung_Leave(object sender, EventArgs e)
        {
            isUnderlined = false;
            TrieuChung.Invalidate(); // Redraw the control
        }


        // make undeerline textbox for Height
        private void ChieuCao_Paint(object sender, PaintEventArgs e)
        {
            if (isUnderlined)
            {
                using (Pen pen = new Pen(Color.RoyalBlue, 2)) // Define the color and thickness of the underline
                {
                    e.Graphics.DrawLine(pen, 0, ChieuCao.Height - 1, ChieuCao.Width, ChieuCao.Height - 1);
                }
            }
        }

        private void ChieuCao_Click(object sender, EventArgs e)
        {
            isUnderlined = true;
            ChieuCao.Invalidate(); // Redraw the control
        }

        private void ChieuCao_Leave(object sender, EventArgs e)
        {
            isUnderlined = false;
            ChieuCao.Invalidate(); // Redraw the control
        }

        private void CanNang_Paint(object sender, PaintEventArgs e)
        {
            if (isUnderlined)
            {
                using (Pen pen = new Pen(Color.RoyalBlue, 2)) // Define the color and thickness of the underline
                {
                    e.Graphics.DrawLine(pen, 0, CanNang.Height - 1, CanNang.Width, CanNang.Height - 1);
                }
            }
        }

        // make undeerline textbox for Weight
        private void CanNang_Click(object sender, EventArgs e)
        {
            isUnderlined = true;
            CanNang.Invalidate(); // Redraw the control
        }

        private void CanNang_Leave(object sender, EventArgs e)
        {
            isUnderlined = false;
            CanNang.Invalidate(); // Redraw the control
        }

        #endregion

        //Warning pop up notification
        private void warningNotification()
        {
            PopupNotifier warning = new PopupNotifier();
            warning.Image = (Image)Properties.Resources.ResourceManager.GetObject("errorcolor");
            warning.BodyColor = Color.FromArgb(220, 53, 69);
            warning.TitleText = "Warning!";
            warning.TitleColor = Color.Black;
            warning.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            warning.ContentText = "You must enter the required information";
            warning.ContentColor = Color.White;
            warning.ContentFont = new Font("Century Gothic", 12);
            warning.Popup();
        }

        //success pop up notification 
        private void successNotification()
        {
            PopupNotifier success = new PopupNotifier();
            success.Image = (Image)Properties.Resources.ResourceManager.GetObject("successcolor");
            success.BodyColor = Color.FromArgb(40, 167, 69);
            success.TitleText = "Success!";
            success.TitleColor = Color.Black;
            success.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            success.ContentText = "Success!";
            success.ContentColor = Color.White;
            success.ContentFont = new Font("Century Gothic", 12);
            success.Popup();
        }
        
    }
}
