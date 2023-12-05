using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Views.Pharmacist
{
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
        }

        private void dtgv_medicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            dtgv_medicine.Rows.Add(15);
            dtgv_medicine.Rows[0].Cells[0].Value = "1234";
            dtgv_medicine.Rows[0].Cells[1].Value = "Nguyen Lam Nhat Anh";
        }
    }
}
