using BusinessLogicTier;
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

namespace Hospital.Views.Recptionist
{
    public partial class EditPatientInfor : Form
    {
        ReceptionBUS reception;
        private string patientName;
        private string patientSex;
        private DateTime patientDate;
        private string patientAddress;
        private string patientTel;
        private string patientWeight;
        private string patientHeight;
        private string patientBloodType;

        public EditPatientInfor()
        {
            reception = ReceptionBUS.GetInstance();
            InitializeComponent();

            if (reception.BN_ID != 0)
            {
                BenhNhan patient = reception.GetBenhNhan(reception.BN_ID);
                guna2TextBox_Name.Text = patientName = patient.HoTen;
                radioButton_Female.Checked = (patient.GioiTinh == "Nu");
                radioButton_Male.Checked = (patient.GioiTinh == "Nam");
                patientSex = patient.GioiTinh;
                dateTimePicker_DoB.Value = patientDate = patient.NgaySinh;
                Address.Text = patientAddress = patient.DiaChi;
                guna2TextBox_Tel.Text = patientTel = patient.SoDienThoai;
                ChieuCao.Text = patientHeight = patient.ChieuCao.ToString();
                CanNang.Text = patientWeight = patient.CanNang.ToString();
                NhomMau.SelectedItem = patientBloodType = (patient.NhomMau == null) ? null : patient.NhomMau.ToString();
            }
        }

        private void EditPatientInfor_Load(object sender, EventArgs e)
        {
            if (reception.BN_ID != 0)
            {
                BenhNhan patient = reception.GetBenhNhan(reception.BN_ID);
                guna2TextBox_Name.Text = patient.HoTen;
                radioButton_Female.Checked = (patient.GioiTinh == "Nu");
                radioButton_Male.Checked = (patient.GioiTinh == "Nam");
                dateTimePicker_DoB.Value = patient.NgaySinh;
                Address.Text = patient.DiaChi;
                guna2TextBox_Tel.Text = patient.SoDienThoai;
                ChieuCao.Text = patient.ChieuCao.ToString();
                CanNang.Text = patient.CanNang.ToString();
                NhomMau.SelectedItem = (patient.NhomMau == null) ? null : patient.NhomMau.ToString();

            }
        }

        private void uC_Button_Confirm_Click(object sender, EventArgs e)
        {
            string sex;
            if (radioButton_Female.Checked)
            {
                sex = radioButton_Female.Text;
            }
            else
            {
                sex = radioButton_Male.Text;
            }

            try
            {
                if(IsChanging())
                {
                    reception.UpdatePatient(
                    reception.BN_ID,
                    guna2TextBox_Name.Text,
                    sex,
                    dateTimePicker_DoB.Value,
                    Address.Text,
                    guna2TextBox_Tel.Text
                    );
                } else
                {
                    reception.edit = false;
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uC_Button_Delete_Click(object sender, EventArgs e)
        {

            guna2TextBox_Name.Text = patientName;
            radioButton_Female.Checked = (patientSex == "Nu");
            radioButton_Male.Checked = (patientSex == "Nam");
            dateTimePicker_DoB.Value = patientDate;
            Address.Text = patientAddress;
            guna2TextBox_Tel.Text = patientTel;
            ChieuCao.Text = patientHeight;
            CanNang.Text = patientWeight;
            NhomMau.SelectedItem = patientBloodType;
            reception.edit = false;
        }

        public bool IsChanging()
        {
            return (guna2TextBox_Name.Text != patientName)
            || (radioButton_Female.Checked && (patientSex != "Nu")) || (radioButton_Male.Checked && (patientSex != "Nam"))
            || (dateTimePicker_DoB.Value != patientDate)
            || (Address.Text != patientAddress)
            || (ChieuCao.Text != patientHeight)
            || (CanNang.Text != patientWeight)
            || (guna2TextBox_Tel.Text != patientTel)
            || (NhomMau.SelectedItem.ToString() != patientBloodType);
        }
    }
}
