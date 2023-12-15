using BusinessLogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private int BN_ID;
        private DoctorRoomBUS room;
        private int PH_ID;
        private int BS_ID;
        private int KH_ID;

        public PatientDetail(int BN_ID, int BS_ID, int PH_ID, int KH_ID)
        {
            InitializeComponent();
            this.BN_ID = BN_ID;
            this.BS_ID = BS_ID;
            this.PH_ID = PH_ID;
            this.KH_ID = KH_ID;
            room = new DoctorRoomBUS();
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
                    fm.Show();
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
            showMiddleForm(new Prescription(BN_ID));
        }

        private void PatientDetail_Load(object sender, EventArgs e)
        {
            var patientDetail = room.GetPatientDetail(BN_ID, BS_ID, PH_ID, KH_ID);

            this.PatientName.Text = patientDetail["Name"];
            this.DoB.Text = patientDetail["DoB"];
            this.Sex.Text = patientDetail["Sex"];
            this.Height.Text = patientDetail["Height"];
            this.Weight.Text = patientDetail["Weight"];
            this.BloodType.Text = patientDetail["BloodType"];
            this.TrieuChung.Text = patientDetail["Symtomp"];
            this.RecordName.Text = patientDetail["RecordName"];
            this.Checkin.Text = patientDetail["CheckIn"];
            this.Doctor.Text = patientDetail["Doctor"];
            this.Room.Text = patientDetail["Room"];
            this.Specialist.Text = patientDetail["Specialist"];
        }

        private void label_DoB_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
