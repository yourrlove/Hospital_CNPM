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
    public partial class ExamineDetail : Form
    {
        public ExamineDetail(int HD_ID, double tongtien, string thanhtoan)
        {
            InitializeComponent();
            label4.Text = Convert.ToString(tongtien) + " (dong)";
            thanhtoanlb.Text = Convert.ToString(thanhtoan);

        }
    }
}
