using BusinessLogicTier;
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
    public partial class EditAdminInfo : Form
    {
        private AdminBUS admin;
        private string userName;
        private string password;
        public EditAdminInfo()
        {
            admin = AdminBUS.GetInstance();
            InitializeComponent();
            InitializeUserInfor();
        }

        private void InitializeUserInfor()
        {
            Account accountInfor = admin.GetAccount(admin.User_ID);
            UserName.Text = userName = accountInfor.username;
            Password.Text = password = accountInfor.password;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            admin.UpdateAccount(admin.User_ID, UserName.Text ?? "", Password.Text ?? "");
            InitializeUserInfor();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            UserName.Text = userName;
            Password.Text = password;
        }
    }
}
