using System;
using System.Drawing;
using System.Windows.Forms;
using Hospital.Views.Doctor;
using Hospital.Views.Login;
using Hospital.Views.Receptionist;
using Tulpep.NotificationWindow;

namespace Hospital
{
    public static class Program
    {
        public static Form ReturnForm { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>  


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        [STAThread]
        static void Main()
        {
            if(Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login fLogin = new Login();
            //Application.Run(new Reception(1));
            Application.Run(new DoctorForm());
            //Application.Run(fLogin);
            //if (fLogin.UserSuccessfullyAuthenticated)
            //{
            //    // MainForm is defined elsewhere
            //    Notification.SucccessNotification("Login Successfully!");
            //    Application.Run(ReturnForm);
            //}
        }

    }


}
