﻿using BusinessLogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Views.Cashier
{

    public partial class Dashboard : Form
    {
        private CashierBUS cashier;
        
        public Dashboard()
        {
            InitializeComponent();
            cashier = CashierBUS.GetInstance();
            userName.Text = cashier.displayName;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

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
        private void btnEditPharmacist_Click(object sender, EventArgs e)
        {
            showMiddleForm(new EditCashierInformation());
        }
    }
}
