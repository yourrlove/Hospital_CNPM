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
        public UC_DashBoardRoom(string TenPhong, string TenBacsi, int nOfWaiting)
        {
            this.MaximumSize = new System.Drawing.Size(177, 200);
            this.MinimumSize = new System.Drawing.Size(177, 200);
            //
            Label unitlabel = new System.Windows.Forms.Label();
            Label roomlabel = new System.Windows.Forms.Label();
            Label doctorlabel = new System.Windows.Forms.Label();

            unitlabel.BackColor = System.Drawing.Color.LightSteelBlue;
            unitlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            unitlabel.Location = new System.Drawing.Point(11, 120);
            unitlabel.Name = "unitlabel";
            unitlabel.Size = new System.Drawing.Size(116, 45);
            unitlabel.TabIndex = 1;
            unitlabel.Text = (nOfWaiting > 0) ? $"UNIT: {nOfWaiting}" : "Full";
            unitlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            roomlabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            roomlabel.Location = new System.Drawing.Point(11, 21);
            roomlabel.Name = "roomlabel";
            roomlabel.Size = new System.Drawing.Size(160, 25);
            roomlabel.TabIndex = 0;
            roomlabel.Text = $"Room: {TenPhong}";
            roomlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            doctorlabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            doctorlabel.Location = new System.Drawing.Point(11, 71);
            doctorlabel.Name = "doctorlabel";
            doctorlabel.Size = new System.Drawing.Size(140, 25);
            doctorlabel.TabIndex = 0;
            doctorlabel.Text = $"Doctor: {TenBacsi}";
            doctorlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                
            this.Controls.Add(unitlabel);
            this.Controls.Add(roomlabel);
            this.Controls.Add(doctorlabel);

        }

        public UC_DashBoardRoom(IContainer container)
        {
            container.Add(this);

            
        }
    }
}
