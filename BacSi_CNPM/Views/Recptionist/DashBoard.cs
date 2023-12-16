using BusinessLogicTier;
using DataAccessTier;
using Guna.UI2.WinForms;
using Hospital.User_Controls;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
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
        private ReceptionBUS reception;
        public DashBoard()
        {
            InitializeComponent();
            reception = new ReceptionBUS();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> khoaInfor = new Dictionary<int, string>();
            khoaInfor = KhoaDBContext.GetKhoa();
            int K_idx = 0;
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.Text = khoaInfor.ElementAt(K_idx).Value;
                List<Tuple<string, string, int>> list = new List<Tuple<string, string, int>>();
                list = reception.GetRoomState(khoaInfor.ElementAt(K_idx).Key);
                int count = 0;
                int x = 40;
                int y = 70;
                int flag = 1;
                for (int i = 0; i < list.Count; i++)
                {
                    var item = list.ElementAt(i);
                    UC_DashBoardRoom room = new UC_DashBoardRoom(item.Item1, item.Item2, item.Item3);
                    room.FillColor = Color.LightSteelBlue;
                    room.FillColor3 = Color.LightSteelBlue;
                    room.FillColor2 = Color.LightSteelBlue;
                    room.FillColor4 = Color.LightSteelBlue;
                    room.Location = new Point(x, y);
                    tab.Controls.Add(room);
                    x += 220;
                    if (flag == 3)
                    {
                        x = 130;
                        y += 250;
                        flag = 1;
                    }
                    else
                    {
                        flag++;
                    }
                }
                K_idx++;
            }

        }

        private void tabPage1_DoctorMajor1_Click(object sender, EventArgs e)
        {

        }
    }
}
