using BusinessLogicTier;
using DataAccessTier;
using DTO;
using Hospital.Properties;
using Hospital.User_Controls;
using Hospital.Views.Receptionist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Views.Doctor
{
    public partial class Requests : Form
    {
        private DoctorRoomBUS room;
        private System.Windows.Forms.BindingSource binding;
        private List<int> data = new List<int>();

        private Form fm;
        private int selectedRowIndex;
        private int BN_ID_active; //BN_ID record is being editted

        public Requests()
        {
            room = DoctorRoomBUS.GetInstance();
            binding = new BindingSource();
            InitializeComponent();
        }

        private void label1_patientnum_Click(object sender, EventArgs e)
        {

        }


        private void Patient_Load(object sender, EventArgs e)
        {
            initializePatients();
        }

        private void initializePatients()
        {
            data = room.GetListWaitingPatients(room.PH_ID);

            int x = 250;
            int y = 26;
            int i = 0;
            for (; i < data.Count; i++)
            {
                if (i >= 5) break;
                WaitingPatient waitingPatient = new WaitingPatient();
                waitingPatient.Location = new Point(x, y);
                this.guna2Panel1.Controls.Add(waitingPatient);
                int index = data[i];
                waitingPatient.Click += (sender, EventArgs) => WaitingPatient_Click(sender, EventArgs, index);
                x += 140;
            }

            for (; i < 5; i++)
            {
                WaitingPatient waitingPatient = new WaitingPatient();
                waitingPatient.Location = new Point(x, y);
                waitingPatient.BackColor = Color.Silver;
                this.guna2Panel1.Controls.Add(waitingPatient);
                x += 140;
            }
            this.requestCount.Text = data.Count().ToString();
        }


        private void container(object _form)
        {
            if (guna2Panel_PatientDetails.Controls.Count > 0)
            {
                guna2Panel_PatientDetails.Controls.Clear();
            }
            fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_PatientDetails.Controls.Add(fm);
            guna2Panel_PatientDetails.Tag = fm;
            fm.Show();
        }

        private void WaitingPatient_Click(object sender, EventArgs e, int BN_ID)
        {
            if (fm == null || fm.IsDisposed || BN_ID_active != BN_ID)
            {
                BN_ID_active = room.BN_ID = BN_ID;
                room.sender = sender;
                container(new PatientInformation());
            }
            else
            {
                fm.Activate(); // Bring the existing form to the front
            }
        }

        private void uC_Button_Next_Click(object sender, EventArgs e)
        {

            if (room.temp1.list.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure ?? This record's prescription will be lost if not save!!",
                                     "Move to Next Patient!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    room.temp1.list.Clear();
                    room.temp1.prescriptionName = string.Empty;
                    room.temp1.createDate = DateTime.Now;
                    Form targetForm = Application.OpenForms["PatientDetail"];
                    if (targetForm != null)
                    {
                        targetForm.Close();
                        room.MovePatient(BN_ID_active, room.PH_ID);
                    }
                    initializePatients();
                }
                else
                {
                    // If 'No', do something here.
                }
                RefreshForm();
            }
        }

        private void RefreshForm()
        {
            if (Application.OpenForms["DoctorForm"].Controls["DoctorMainPanel"].Controls.Count > 0)
            {
                Application.OpenForms["DoctorForm"].Controls["DoctorMainPanel"].Controls.Clear();
            }

            // Add new subform after clearing
            Requests newForm = new Requests();
            newForm.TopLevel = false;
            Application.OpenForms["DoctorForm"].Controls["DoctorMainPanel"].Controls.Add(newForm);
            newForm.Dock = DockStyle.Fill;
            newForm.Show();
            this.Dispose();
        }

        private void guna2Panel_PatientDetails_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
