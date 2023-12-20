using BussinessLogicTier;
using DataAccessTier;
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

namespace Hospital.Views.Pharmacist
{
    public partial class PrescriptionDetail : Form
    {
        private System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        private PharmacistBUS pharmacist;
        public PrescriptionDetail(int HD_ID, int BN_ID)
        {
            pharmacist = PharmacistBUS.GetInstance();
            InitializeComponent();
            LoadHoaDon(HD_ID);
            curr.HD_ID = HD_ID;
            curr.BN_ID = BN_ID;
            displayName(BN_ID);
        }

        Current1 curr = new Current1();
        /// <summary>
        /// display the patient name in the label 
        /// </summary>
        /// <param name="BN_ID"></param>
        private void displayName(int BN_ID)
        {
            patient_name.Text = pharmacist.getName(BN_ID);
        }

        /// <summary>
        /// Using binding list to display the list in the datagrid view
        /// </summary>
        /// <param name="HD_ID"></param>
        private void LoadHoaDon(int HD_ID)
        {
            try
            {
                bindingSource.DataSource = pharmacist.getHoaDon(HD_ID);
                this.dtgv_donthuoc.DataSource = bindingSource;
                //this.dtgv_donthuoc.AutoGenerateColumns = true;
                //this.dtgv_donthuoc.Columns[0].Visible = false;
                //this.dtgv_donthuoc.BorderStyle = BorderStyle.Fixed3D;
                this.dtgv_donthuoc.AllowUserToAddRows = false;
            }
            catch (Exception ex) { }
        }


        /// <summary>
        /// delete cai nay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgv_donthuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_donthuoc.Rows.Count)
            {

                var cellValue = dtgv_donthuoc.Rows[e.RowIndex].Cells[0].Value;


                if (cellValue != null)
                {
                    int HD_ID = Convert.ToInt32(cellValue.ToString());
                    // container(new PrescriptionDetail(HD_ID));
                }
            }
        }
    }
}
