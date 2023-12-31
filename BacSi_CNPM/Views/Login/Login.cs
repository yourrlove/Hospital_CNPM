﻿using BusinessLogicTier;
using DTO;
using Guna.UI2.WinForms;
using Hospital.Views.Cashier;
using Hospital.Views.Doctor;
using Hospital.Views.Pharmacist;
using Hospital.Views.Receptionist;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Views.Login
{

    public partial class LoginForm : Form
    {
        private LoginBUS login;
        private Account account;
 
        public bool UserSuccessfullyAuthenticated { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
            login = LoginBUS.GetInstance();
            account = new Account();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void doctor_login_img_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sign_In_Click(object sender, EventArgs e)
        {
            // Get input from form controls
            string usernameInput = username.Text;
            string passwordInput = password.Text;

            // Update the user instance with input values
            account.username = usernameInput;
            account.password = passwordInput;

            // Clear any existing error messages
            errorProvider1.Clear();

            // Validate the model using data annotations
            var results = new List<ValidationResult>();
            var context = new ValidationContext(account, serviceProvider: null, items: null);
            bool isValid = Validator.TryValidateObject(account, context, results, true);

            if (isValid)
            {
                string userID = login.Validate(usernameInput, passwordInput);
                if (userID != null)
                {
                    Form form = new Form();
                    string role = login.Validate(usernameInput, passwordInput).Substring(0, 3);
                    if (role.Contains("doc"))
                    {
                        form = new DoctorForm((int)login.GetID(userID, role), login.GetDisplayName(userID));
                        
                    }
                    else if (role.Contains("rec"))
                    {
                        form = new Reception((int)login.GetID(userID, role), login.GetDisplayName(userID));
                    } else if(role.Contains("cas"))
                    {
                        form = new CashierRoom((int)login.GetID(userID, role), login.GetDisplayName(userID));
                    } else if(role.Contains("pha"))
                    {
                        form = new PharmacistRoom(login.GetDisplayName(userID));
                    }
                    Program.ReturnLogInForm = form;
                    UserSuccessfullyAuthenticated = true;
                    this.Close();
                }
                else
                    {
                        Notification.ErrorNotification("The Username or Password is Incorrect!");
                    }
                }
                else
                {
                    // Display validation errors using ErrorProvider
                    foreach (var result in results)
                    {
                        string propertyName = result.MemberNames.FirstOrDefault();
                        propertyName = propertyName[0].ToString().ToUpper() + propertyName.Substring(1);
                        Guna2TextBox textBox = (Guna2TextBox)this.doctor_login_img.Controls.Find(propertyName, true).FirstOrDefault();
                        if (textBox != null)
                        {
                            // Clear any existing error for the control before setting a new one
                            errorProvider1.SetError(textBox, string.Empty);

                            // Set the new error message for the control
                            errorProvider1.SetError(textBox, result.ErrorMessage);
                        }
                    }
                }

            }
        }
    }
