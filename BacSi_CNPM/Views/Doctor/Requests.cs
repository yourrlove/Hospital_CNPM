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
    public partial class Requests : Form
    {
        System.Timers.Timer timer;
        int m, s;
        public Requests()
        {
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
            dtgvRequests.Rows.Add(9);
            dtgvRequests.Rows[0].Cells[1].Value = Image.FromFile("status\\1.png");
            dtgvRequests.Rows[0].Cells[2].Value = "001";
            dtgvRequests.Rows[0].Cells[3].Value = "Nguyen Lam Nhat Anh";
            dtgvRequests.Rows[0].Cells[4].Value = "23";
            dtgvRequests.Rows[0].Cells[5].Value = "O+";
            dtgvRequests.Rows[0].Cells[6].Value = "Headache";

            dtgvRequests.Rows[1].Cells[1].Value = Image.FromFile("status\\2.png");
            dtgvRequests.Rows[1].Cells[2].Value = "001";
            dtgvRequests.Rows[1].Cells[3].Value = "Nguyen Lam Nhat Anh";
            dtgvRequests.Rows[1].Cells[4].Value = "23";
            dtgvRequests.Rows[1].Cells[5].Value = "O+";
            dtgvRequests.Rows[1].Cells[6].Value = "Headache";
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uC_Button4_Click(object sender, EventArgs e)
        {
            showMiddleForm(new Prescription());
        }

        private void addRequest_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
