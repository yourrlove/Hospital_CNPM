using DataAccessTier;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
    public partial class Bill : Form
    {
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        public Bill()
        {
            InitializeComponent();
            LoadThuoc();
        }


        private void LoadThuoc()
        {
            try
            {
                dtgv_bill.DataSource = ThuocDBContext.GetThuoc();
                this.dtgv_bill.AutoGenerateColumns = true;
                this.dtgv_bill.DataSource = bindingSource;
                this.dtgv_bill.BorderStyle = BorderStyle.Fixed3D;
            }
            catch (Exception ex) { }
        }

        private void dtgv_bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
