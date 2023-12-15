using BusinessLogicTier;
using DataAccessTier;
using DTO;
using Hospital.Properties;
using Hospital.User_Controls;
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
        DoctorRoomBUS room;
        System.Windows.Forms.BindingSource binding;
        List<int> data = new List<int>();

        private Form fm;
        private int selectedRowIndex;
        private int BS_ID;
        private int PH_ID;
        private int KH_ID;

        public Requests(int BS_ID, int PH_ID, int KH_ID)
        {
            this.BS_ID = BS_ID;
            this.PH_ID = PH_ID;
            this.KH_ID = KH_ID;
            room = new DoctorRoomBUS();
            binding = new BindingSource();
            InitializeComponent();
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

        private void label1_patientnum_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            data = room.GetListWaitingPatients(PH_ID);

            int x = 300;
            int y = 36;
            int i = 0;
            for(; i < data.Count; i++)
            {
                WaitingPatient waitingPatient = new WaitingPatient();
                waitingPatient.Location = new Point(x, y);
                this.guna2Panel1.Controls.Add(waitingPatient);
                int index = data[i];
                waitingPatient.Click += (sender, EventArgs) => WaitingPatient_Click(sender, EventArgs, index);
                x += 180;
            }

            for (; i < 3; i++)
            {
                WaitingPatient waitingPatient = new WaitingPatient();
                waitingPatient.Location = new Point(x, y);
                waitingPatient.BackColor = Color.Silver;
                this.guna2Panel1.Controls.Add(waitingPatient);
                x += 180;
            }
            this.requestCount.Text = data.Count().ToString();
        }


        private void addRequest_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

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
            if (fm == null || fm.IsDisposed)
            {
                container(new PatientDetail(BN_ID, BS_ID, PH_ID, KH_ID));
            }
            else
            {
                fm.Activate(); // Bring the existing form to the front
            }
        }

        private void uC_Button_Next_Click(object sender, EventArgs e)
        {
            Form targetForm = Application.OpenForms["PatientDetail"];
            if (targetForm != null)
            {
                targetForm.Close();
            }

        }
    }
}
