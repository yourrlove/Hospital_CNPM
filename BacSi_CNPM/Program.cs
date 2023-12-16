using System;
using System.Windows.Forms;
using Hospital.Views.Doctor;
using Hospital.Views.Login;
using Hospital.Views.Receptionist;

namespace Hospital
{
    public static class Program
    {
        //public static int changeLanguage = 1;
        public static Form ReturnForm { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>  
        [STAThread]

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        static void Main()
        {
            if(Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login fLogin = new Login();
            Application.Run(new Reception());
            //Application.Run(new Reception());
            //if (fLogin.UserSuccessfullyAuthenticated)
            //{
            //    // MainForm is defined elsewhere
            //    Application.Run(ReturnForm);
            //}
        }
    }
}
