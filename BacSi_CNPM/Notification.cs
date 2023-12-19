using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace Hospital
{
    public class Notification
    {
        public static void SucccessNotification(string message)
        {
            PopupNotifier success = new PopupNotifier();
            success.Image = (Image)Properties.Resources.ResourceManager.GetObject("successcolor");
            success.BodyColor = Color.FromArgb(40, 167, 69);
            success.TitleText = "Successed!";
            success.TitleColor = Color.Black;
            success.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            success.ContentText = message;
            success.ContentColor = Color.White;
            success.ContentFont = new Font("Century Gothic", 12);
            success.Popup();
        }

        public static void WarningNotification(string message)
        {
            PopupNotifier warning = new PopupNotifier();
            warning.Image = (Image)Properties.Resources.ResourceManager.GetObject("errorcolor");
            warning.BodyColor = Color.FromArgb(220, 53, 69);
            warning.TitleText = "Warning!";
            warning.TitleColor = Color.Black;
            warning.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            warning.ContentText = "Failed!";
            warning.ContentColor = Color.White;
            warning.ContentFont = new Font("Century Gothic", 12);
            warning.Popup();
        }

        public static void ErrorNotification(string error)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = (Image)Properties.Resources.ResourceManager.GetObject("errorcolor");
            popup.BodyColor = Color.FromArgb(220, 53, 69);
            popup.TitleText = "Error!";
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            popup.ContentText = error;
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.AnimationDuration = 200;
            popup.Popup();
        }
    }
}
