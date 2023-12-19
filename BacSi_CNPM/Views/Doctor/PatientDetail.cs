using BusinessLogicTier;
using DTO;
using Guna.UI2.WinForms;
using Hospital.Views.Receptionist;
using Microsoft.IdentityModel.Tokens;
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
    public partial class PatientDetail : Form
    {
        private DoctorRoomBUS room;
        private bool firstSave;
        public PatientDetail()
        {
            InitializeComponent();
            firstSave = true;

            room = DoctorRoomBUS.GetInstance();
            
            if (!room.temp1.list.IsNullOrEmpty())
            {
                Prescription.DataSource = room.temp1.list;
            }
        }

        private void showMiddleForm(Form showForm)
        {
            Form fm = new Form();
            try
            {
                using (showForm)
                {
                    fm.StartPosition = FormStartPosition.Manual;
                    fm.FormBorderStyle = FormBorderStyle.None;
                    fm.Opacity = .70d;
                    fm.BackColor = Color.Black;
                    fm.WindowState = FormWindowState.Maximized;
                    fm.TopMost = true;
                    fm.Location = this.Location;
                    fm.ShowInTaskbar = false;
                    //fm.Show();
                    showForm.StartPosition = FormStartPosition.CenterScreen;
                    showForm.TopMost = true;
                    showForm.Owner = fm;
                    showForm.ShowDialog();

                    fm.Dispose();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                fm.Dispose();
            }
        }

        private void uC_Button_Prescription_Click(object sender, EventArgs e)
        {
            showMiddleForm(new Prescription(room.BN_ID));
            if (room.temp1.list.Count > 0)
            {
                Prescription.DataSource = room.temp1.list;
                uC_Button_Prescription.Text = "Edit Prescription";
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

        private void PatientDetail_Load(object sender, EventArgs e)
        {
            var patientDetail = room.GetPatientDetail(room.BN_ID, room.BS_ID, room.PH_ID, room.KH_ID);
            MessageBox.Show(patientDetail["RecordName"]);
            room.BA_ID = int.Parse(patientDetail["BA_ID"]);
            this.PatientName.Text = patientDetail["Name"];
            this.DoB.Text = patientDetail["DoB"];
            this.Sex.Text = patientDetail["Sex"];
            this.Height.Text = patientDetail["Height"];
            this.Weight.Text = patientDetail["Weight"];
            this.BloodType.Text = patientDetail["BloodType"];
            this.TrieuChung.Text = patientDetail["Symtomp"];
            this.TenBenhAn.Text = patientDetail["RecordName"];
            this.Ngay.Text = patientDetail["CheckIn"];


            if (room.temp1.list.Count > 0)
            {
                Prescription.DataSource = room.temp1.list;
                uC_Button_Prescription.Text = "Edit Prescription";
            }
        }

        private void uC_Button_Save_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                if (room.temp1.list.Count > 0)
                {
                    
                    if (room.ResolvePatientRecord(
                         room.KH_ID,
                         room.BA_ID,
                         TenBenhAn.Text ?? "",
                         TrieuChung.Text ?? "",
                         TienSu.Text ?? "",
                         Ngay.Value,
                         room.BS_ID,
                         room.temp1.prescriptionName,
                         room.temp1.createDate,
                         room.temp1.list
                         ))
                    {
                        Notification.SucccessNotification("Update Record & Prescription Successfully!");
                    }
                }
                else
                {
                    if(room.UpdateRerod(room.BA_ID, TenBenhAn.Text ?? "", Symtomp.Text ?? "", Ngay.Value))
                    {
                        Notification.SucccessNotification("Update record Successfully!");
                    }
                }
            }
            else
            {
                Notification.ErrorNotification("Failed to Update!");
            }

        }

        private bool Validate()
        {
            BenhAn2 record = new BenhAn2();

            // Update the user instance with input values
            record.TenBenhAn = TenBenhAn.Text;
            record.Ngay = Ngay.Value;
            // Clear any existing error messages
            errorProvider1.Clear();

            // Validate the model using data annotations
            var results = new List<ValidationResult>();
            var context = new ValidationContext(record, serviceProvider: null, items: null);
            bool isValid = Validator.TryValidateObject(record, context, results, true);

            if (isValid)
            {
                return true;
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

                return false;
            }
        }

    }
}
