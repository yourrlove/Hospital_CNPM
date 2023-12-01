﻿using Hospital.Views.Doctor;
using Hospital.Views.Receptionist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Views.Login
{
    public partial class Loading : Form
    {

        private string positionForm;
        
        public Loading(string position)
        {
            InitializeComponent();
            positionForm = position;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();


                if(positionForm == "BS") 
                {
                    DoctorForm doctor_form = new DoctorForm();
                    doctor_form.Show();
                } else if (positionForm == "TT")
                {
                    ReceptionForm reception_form = new ReceptionForm();
                    reception_form.Show();
                }
                this.Hide();
            }
            else
            {
                guna2CircleProgressBar1.Value += 1;
                label_percent.Text = (Convert.ToInt32(label_percent.Text) + 1).ToString();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            //Set interval to 20 milliseconds
            timer1.Interval = 20;
            timer1.Start();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}