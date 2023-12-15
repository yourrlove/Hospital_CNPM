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
        private int patientID;
        public EditPatientInfor(int BN_ID)
        {
            reception = new ReceptionBUS();
            patientID = BN_ID;
            InitializeComponent();

            if (patientID != null)
            {
                BenhNhan patient = reception.GetBenhNhan(patientID);
                guna2TextBox_Name.Text = patient.HoTen;
                radioButton_Female.Checked = (patient.GioiTinh == "Nu");
                radioButton_Male.Checked = (patient.GioiTinh == "Nam");
                dateTimePicker_DoB.Value = patient.NgaySinh;
                Address.Text = patient.DiaChi;
                guna2TextBox_Tel.Text = patient.SoDienThoai;
                ChieuCao.Text = patient.ChieuCao.ToString();
                CanNang.Text = patient.CanNang.ToString();
                NhomMau.SelectedItem = patient.NhomMau.ToString();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void EditPatientInfor_Load(object sender, EventArgs e)
        {
            if (patientID != 0)
            {
                BenhNhan patient = reception.GetBenhNhan(patientID);
                guna2TextBox_Name.Text = patient.HoTen;
                radioButton_Female.Checked = (patient.GioiTinh == "Nu");
                radioButton_Male.Checked = (patient.GioiTinh == "Nam");
                dateTimePicker_DoB.Value = patient.NgaySinh;
                Address.Text = patient.DiaChi;
                guna2TextBox_Tel.Text = patient.SoDienThoai;
                ChieuCao.Text = patient.ChieuCao.ToString();
                CanNang.Text = patient.CanNang.ToString();
                NhomMau.SelectedItem = patient.NhomMau.ToString();
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
                reception.UpdatePatient(
                patientID,
                guna2TextBox_Name.Text,
                sex,
                dateTimePicker_DoB.Value,
                Address.Text,
                guna2TextBox_Tel.Text
                );
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uC_Button_Delete_Click(object sender, EventArgs e)
        {
            guna2TextBox_Name.Text = string.Empty;
            radioButton_Female.Checked = false;
            radioButton_Male.Checked = false;
            guna2TextBox_Tel.Text = string.Empty;
            dateTimePicker_DoB.Value = DateTime.Now;
            Address.Text = string.Empty;

        }
    }
}
