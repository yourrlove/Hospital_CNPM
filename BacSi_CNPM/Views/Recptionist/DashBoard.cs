using DataAccessTier;
using Guna.UI2.WinForms;
using Hospital.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Views.Receptionist
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();

            Dictionary<string, int> roomsInfor = new Dictionary<string, int>();
            roomsInfor = PhongBenhDBContext.GetRooms();
            int x = 50;
            int y = 80;
            int flag = 1;
            foreach (var infor in roomsInfor)
            {
                UC_DashBoardRoom room = new UC_DashBoardRoom(infor.Key, infor.Value);
                room.Location = new Point(x, y);
                this.dashboardpanel.Controls.Add(room);
                x += 250;
                if (flag == 3)
                {
                    x = 50;
                    y += 200;
                    flag = 1;
                }
                else
                {
                    flag++;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uC_DashBoardRoom1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
