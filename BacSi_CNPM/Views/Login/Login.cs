using Hospital.Views.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessTier;


namespace Hospital.Views.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sign_In_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "")
            {
                MessageBox.Show("Invalid User Name!");
                usernameTextBox.Focus();
                return;
            }

            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Invalid Password");
                passwordTextBox.Focus();
                return;
            }

            if(AccountDBContext.Authenticate(usernameTextBox.Text, passwordTextBox.Text))
            {
                string position = AccountDBContext.GetUserID(usernameTextBox.Text)[..2];
                Loading _load = new Loading(position);
                _load.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Information Wrong or Account Does Not Exist!");
            }

        }
    }
}
