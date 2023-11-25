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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void label1_patientnum_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(9);
            guna2DataGridView1.Rows[0].Cells[1].Value = "Nguyen Lam Nhat Anh";
            guna2DataGridView1.Rows[0].Cells[2].Value = "0399245850";
            guna2DataGridView1.Rows[0].Cells[3].Value = "Vung Tau City";
            guna2DataGridView1.Rows[0].Cells[4].Value = "8:30AM (16/11/2023)";
            guna2DataGridView1.Rows[0].Cells[5].Value = "10/11/2023";
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
