﻿using DataAccessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataAccessTier.ChiTietDonThuocDBContext;

namespace Hospital.Views.Pharmacist
{
    public partial class BillDetail : Form
    {
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();

        public BillDetail(int HD_ID, double tongtien, string thanhtoan)
        {
            InitializeComponent();
            LoadHoaDon(HD_ID);
            lb_tongtien.Text = Convert.ToString(tongtien);
            lb_thanhtoan.Text = thanhtoan;
        }
        private void LoadHoaDon(int HD_ID)
        {
            try
            {
                bindingSource.DataSource = ChiTietHoaDonDBContext.loadHoaDon(HD_ID);
                this.dtgv_billdetail.DataSource = bindingSource;
                this.dtgv_billdetail.AutoGenerateColumns = true;
                this.dtgv_billdetail.BorderStyle = BorderStyle.Fixed3D;


            }
            catch
            {

            }
        }

        private void bill_detail_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
