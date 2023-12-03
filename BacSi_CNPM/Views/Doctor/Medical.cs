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
    public partial class Medical : Form
    {
        public Medical()
        {
            InitializeComponent();
        }
        private void Medical_Load(object sender, EventArgs e)
        {
            dgvRecords.Rows.Add(9);
            dgvRecords.Rows[0].Cells[1].Value = Image.FromFile("status\\1.png");
            dgvRecords.Rows[0].Cells[2].Value = "001";
            dgvRecords.Rows[0].Cells[3].Value = "Nguyen Lam Nhat Anh";
            dgvRecords.Rows[0].Cells[4].Value = "23";
            dgvRecords.Rows[0].Cells[5].Value = "O+";
            dgvRecords.Rows[0].Cells[6].Value = "Headache";

            dgvRecords.Rows[1].Cells[1].Value = Image.FromFile("status\\2.png");
            dgvRecords.Rows[1].Cells[2].Value = "001";
            dgvRecords.Rows[1].Cells[3].Value = "Nguyen Lam Nhat Anh";
            dgvRecords.Rows[1].Cells[4].Value = "23";
            dgvRecords.Rows[1].Cells[5].Value = "O+";
            dgvRecords.Rows[1].Cells[6].Value = "Headache";
        }
        private void dgvRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
