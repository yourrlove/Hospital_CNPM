using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.User_Controls
{
    public partial class UC_DashBoardRoom : Guna2CustomGradientPanel
    {
        public UC_DashBoardRoom(string TenPhong, int Succhua)
        {
            this.MaximumSize = new System.Drawing.Size(177, 181);
            this.MinimumSize = new System.Drawing.Size(177, 181);
            //
            Label unitlabel = new System.Windows.Forms.Label();
            Label roomlabel = new System.Windows.Forms.Label();

            unitlabel.BackColor = System.Drawing.Color.LightSteelBlue;
            unitlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            unitlabel.Location = new System.Drawing.Point(31, 97);
            unitlabel.Name = "unitlabel";
            unitlabel.Size = new System.Drawing.Size(116, 45);
            unitlabel.TabIndex = 1;
            unitlabel.Text = $"UNIT: {Succhua}";
            unitlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            roomlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            roomlabel.Location = new System.Drawing.Point(31, 31);
            roomlabel.Name = "roomlabel";
            roomlabel.Size = new System.Drawing.Size(116, 45);
            roomlabel.TabIndex = 0;
            roomlabel.Text = TenPhong;
            roomlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            this.Controls.Add(unitlabel);
            this.Controls.Add(roomlabel);
        }

        public UC_DashBoardRoom(IContainer container)
        {
            container.Add(this);

            
        }
    }
}
