using BusinessLogicTier;
using DTO;
using Guna.UI2.WinForms;
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

namespace Hospital.Views.Doctor
{
    public partial class MedicalRecord : Form
    {
        private DoctorRoomBUS room;

        public MedicalRecord()
        {
            InitializeComponent();
            room = DoctorRoomBUS.GetInstance();
            InitializeMedicalRecord();
        }

        private void PatientDetail_Load(object sender, EventArgs e)
        {
            InitializeMedicalRecord();
        }

        private void InitializeMedicalRecord()
        {
            Record medical = room.GetMedicalRecord(room.BA_ID, room.BN_ID);
            PatientName.Text = $"Name:  {medical.HoTen ?? ""}";
            Sex.Text = $"Sex:  {medical.GioiTinh ?? ""}";
            DoB.Text = $"Date Of Birth:  {medical.NgaySinh ?? ""}";
            Telephone.Text = $"Tel:  {medical.SoDienThoai ?? ""}";
            Address.Text = $"Address:  {medical.DiaChi ?? ""}";
            Height.Text = $"Height:  {medical.ChieuCao ?? ""}";
            Weight.Text = $"Weight:  {medical.CanNang ?? ""}";
            BloodType.Text = $"Blood Type: {medical.NhomMau ?? ""}";
            Department.Text = $"Department:  {medical.TenKhoa ?? ""}";
            RecordName.Text = $"Record Name:  {medical.TenBenhAn ?? ""}";
            Doctor.Text = $"Doctor:  {medical.BacSi ?? ""}";
            Checkin.Text = $"Check-in:  {medical.Ngay ?? ""}";
            Symtomp.Text = $"Symptomp:  {medical.TrieuChung ?? ""}";
            MedicalHis.Text = $"Medical History:  {medical.TSBenhLi ?? ""}";
            Medicines.DataSource = medical.lists;
        }
    }
}
