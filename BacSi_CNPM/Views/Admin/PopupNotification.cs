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
    public partial class PopupNotification : Form
    {
        public PopupNotification()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            errorNotification();


        }

        private void errorNotification()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = (Image)Properties.Resources.ResourceManager.GetObject("warningblack");
            popup.BodyColor = Color.FromArgb(220, 53, 69);
            popup.TitleText = "Error!";
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            popup.ContentText = "Your error message";
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Popup();
        }

        private void PopupNotification_Load(object sender, EventArgs e)
        {

        }
    }
}
