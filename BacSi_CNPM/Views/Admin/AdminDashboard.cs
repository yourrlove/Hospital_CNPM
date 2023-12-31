﻿using BusinessLogicTier;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Views.Admin
{
    public partial class AdminDashboard : Form
    {
        private AdminBUS admin;

        public AdminDashboard()
        {
            admin = AdminBUS.GetInstance();
            InitializeComponent();
            InitializeTotalEmployees();
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
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            InitializeTotalEmployees();
        }

        private void btnEditAdmin_Click(object sender, EventArgs e)
        {
            showMiddleForm(new EditAdminInfo());
        }

        private void InitializeTotalEmployees()
        {
            TotalEmployees totalEmployees = admin.GetTotalEmployees();
            TotalCashiers.Text = totalEmployees.totalCashiers.ToString();
            TotalDoctors.Text = totalEmployees.totalDoctors.ToString();
            TotalReceptionists.Text = totalEmployees.totalReceptionists.ToString();
            TotalPharmacists.Text = totalEmployees.totalPharmacists.ToString();
        }
    }
}
