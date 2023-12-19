using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;
using DTO;
using Guna.UI2.WinForms;
using Hospital.User_Controls;
using Hospital.Views.Receptionist;

namespace Hospital.Views.Doctor
{
    public partial class PatientInformation : Form
    {
        private DoctorRoomBUS room;
        public PatientInformation()
        {
            InitializeComponent();
            room = DoctorRoomBUS.GetInstance();
            InitializePatientInformation();
        }

        private void InitializePatientInformation()
        {
            PatientInfor patient = new PatientInfor();
            patient = room.GetPatientInfor(room.BN_ID);

            PatientName.Text = $"Name:  {patient.HoTen}";
            Sex.Text = $"Sex:  {patient.GioiTinh}";
            DoB.Text = $"Date of Birth:  {patient.NgaySinh}";
            Height.Text = $"Height:  " + patient.ChieuCao + " cm";
            Weight.Text = $"Weight:  " + patient.CanNang + " kg";
            BloodType.Text = $"Blood Type:  {patient.NhomMau}";
            RecordName.Text = $"Record Name:  {patient.TenBenhAn}";
            Symtomp.Text = $"Symptomp:  {patient.TrieuChung}";
            CheckIn.Text = $"Check-in:  {patient.CheckIn}";
        }

        private void uC_Button_Resolve_Click(object sender, EventArgs e)
        {
            if (room.BN_ID > 0)
            {

                foreach (Control control in Application.OpenForms["Requests"].Controls["guna2Panel1"].Controls)
                {
                    if (control is WaitingPatient button && button != room.sender)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }

                if (Application.OpenForms["Requests"].Controls["guna2Panel_PatientDetails"].Controls.Count > 0)
                {
                    Application.OpenForms["Requests"].Controls["guna2Panel_PatientDetails"].Controls.Clear();
                }

                // Add new subform after clearing 
                PatientDetail newForm = new PatientDetail
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.None
                };
                Application.OpenForms["Requests"].Controls["guna2Panel_PatientDetails"].Controls.Add(newForm);
                Application.OpenForms["Requests"].Controls["guna2Panel_PatientDetails"].Tag = newForm; ;
                newForm.Show();
                this.Dispose();

            }
        }
    }
}
