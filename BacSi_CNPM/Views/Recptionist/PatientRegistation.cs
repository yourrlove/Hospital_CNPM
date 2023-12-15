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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hospital.Views.Receptionist
{
    public partial class PatientRegistation : Form
    {
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
            dateTimePicker2.Value = DateTime.Now;
        }

        private void guna2ComboBox_Specialist_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.TenPhong.Items.Clear();
            if(TenKhoa.SelectedIndex >= 0)
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
    }
}
