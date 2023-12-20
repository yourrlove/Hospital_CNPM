using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Hospital.Views.Admin
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }
        private void PopupNotification()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = (Image)Properties.Resources.ResourceManager.GetObject("warningblack");
            popup.BodyColor = Color.FromArgb(255, 193, 7);
            popup.TitleText = "Warning!";
            popup.TitleColor = Color.Red;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            popup.ContentText = "Your warning message";
            popup.ContentColor = Color.Black;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Popup();
        }
        private void uC_Button1_Click(object sender, EventArgs e)
        {
            PopupNotification();
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
