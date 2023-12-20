using BusinessLogicTier;
using Guna.UI2.WinForms;
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
    public partial class DatabaseRecord : Form
    {
        private AdminBUS admin;
        private int selectedRowIndex_1;
        private int selectedRowIndex_2;
        private int selectedRowIndex_3;
        private int selectedRowIndex_4;
        private int selectedRowIndex_5;
        List<Guna2DataGridView> DGViews;

        public DatabaseRecord()
        {
            admin = AdminBUS.GetInstance();
            selectedRowIndex_1 = 0;
            selectedRowIndex_2 = 0;
            selectedRowIndex_3 = 0;
            selectedRowIndex_4 = 0;
            selectedRowIndex_5 = 0;
            DGViews = new List<Guna2DataGridView>();
            InitializeComponent();
            InitializeDatabase();
        }

        private void DatabaseRecord_Load(object sender, EventArgs e)
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            DGViews = tabControl1.TabPages
                                 .Cast<TabPage>()
                                 .SelectMany((TabPage tab) => tab.Controls.OfType<Guna2DataGridView>())
                                 .ToList();

            DGViews[0].DataSource = admin.GetListBacSi();
            DGViews[1].DataSource = admin.GetListDuocSi();
            DGViews[2].DataSource = admin.GetListThuNgan();
            DGViews[3].DataSource = admin.GetListTiepTan();
            DGViews[4].DataSource = admin.GetListMedicines();
        }

        private void btnAdminDbDelete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex_1 > 0 && DGViews[0].Rows[selectedRowIndex_1].Cells[3].Value != null)
            {
                int BS_ID = (int)DGViews[0].Rows[selectedRowIndex_1].Cells[0].Value;
                string User_ID = DGViews[0].Rows[selectedRowIndex_1].Cells[3].Value.ToString();
                admin.DeletedDOCAccount(User_ID, BS_ID);
                selectedRowIndex_1 = 0;
                DGViews[0].DataSource = admin.GetListBacSi();
            }

            if (selectedRowIndex_2 > 0 && DGViews[1].Rows[selectedRowIndex_2].Cells[3].Value != null)
            {
                int DS_ID = (int)DGViews[1].Rows[selectedRowIndex_2].Cells[0].Value;
                string User_ID = DGViews[1].Rows[selectedRowIndex_2].Cells[3].Value.ToString();
                admin.DeletedDSAccount(User_ID, DS_ID);
                selectedRowIndex_2 = 0;
                DGViews[1].DataSource = admin.GetListDuocSi();
            }

            if (selectedRowIndex_3 > 0 && DGViews[2].Rows[selectedRowIndex_3].Cells[3].Value != null)
            {
                int TN_ID = (int)DGViews[2].Rows[selectedRowIndex_3].Cells[0].Value;
                string User_ID = DGViews[2].Rows[selectedRowIndex_3].Cells[3].Value.ToString();
                admin.DeletedTNAccount(User_ID, TN_ID);
                selectedRowIndex_3 = 0;
                DGViews[2].DataSource = admin.GetListThuNgan();
            }

            if (selectedRowIndex_4 > 0 && DGViews[3].Rows[selectedRowIndex_4].Cells[3].Value != null)
            {
                int TT_ID = (int)DGViews[3].Rows[selectedRowIndex_4].Cells[0].Value;
                string User_ID = DGViews[3].Rows[selectedRowIndex_4].Cells[3].Value.ToString();
                admin.DeletedTTAccount(User_ID, TT_ID);
                selectedRowIndex_4 = 0;
                DGViews[3].DataSource = admin.GetListTiepTan();
            }

            if (selectedRowIndex_5 > 0 && DGViews[3].Rows[selectedRowIndex_4].Cells[3].Value != null)
            {
                int TT_ID = (int)DGViews[3].Rows[selectedRowIndex_4].Cells[0].Value;
                string User_ID = DGViews[3].Rows[selectedRowIndex_4].Cells[3].Value.ToString();
                admin.DeletedTTAccount(User_ID, TT_ID);
                selectedRowIndex_4 = 0;
                DGViews[3].DataSource = admin.GetListTiepTan();
            }

        }

        private void DtgvDoctorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                selectedRowIndex_1 = e.RowIndex;
            }
        }

        private void dtgvPharmaList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                selectedRowIndex_2 = e.RowIndex;
            }
        }

        private void dtgvCashierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                selectedRowIndex_3 = e.RowIndex;
            }
        }

        private void dtgvRecepList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                selectedRowIndex_4 = e.RowIndex;
            }
        }

        private void dtgvMedicineList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                selectedRowIndex_5 = e.RowIndex;
            }
        }
    }
}
