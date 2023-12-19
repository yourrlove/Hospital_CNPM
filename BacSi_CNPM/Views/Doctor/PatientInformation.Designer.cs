namespace Hospital.Views.Doctor
{
    partial class PatientInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PatientName = new System.Windows.Forms.Label();
            Height = new System.Windows.Forms.Label();
            Weight = new System.Windows.Forms.Label();
            DoB = new System.Windows.Forms.Label();
            Sex = new System.Windows.Forms.Label();
            BloodType = new System.Windows.Forms.Label();
            Symtomp = new System.Windows.Forms.Label();
            uC_Button_Resolve = new User_Controls.UC_Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            panel_registerForm = new Guna.UI2.WinForms.Guna2ShadowPanel();
            RecordName = new System.Windows.Forms.Label();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label5 = new System.Windows.Forms.Label();
            CheckIn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel_registerForm.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // PatientName
            // 
            PatientName.AutoSize = true;
            PatientName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            PatientName.Location = new System.Drawing.Point(23, 93);
            PatientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PatientName.Name = "PatientName";
            PatientName.Size = new System.Drawing.Size(65, 23);
            PatientName.TabIndex = 8;
            PatientName.Text = "Name :";
            // 
            // Height
            // 
            Height.AutoSize = true;
            Height.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            Height.Location = new System.Drawing.Point(23, 248);
            Height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Height.Name = "Height";
            Height.Size = new System.Drawing.Size(71, 23);
            Height.TabIndex = 13;
            Height.Text = "Height :";
            // 
            // Weight
            // 
            Weight.AutoSize = true;
            Weight.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            Weight.Location = new System.Drawing.Point(355, 248);
            Weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Weight.Name = "Weight";
            Weight.Size = new System.Drawing.Size(74, 23);
            Weight.TabIndex = 15;
            Weight.Text = "Weight :";
            // 
            // DoB
            // 
            DoB.AutoSize = true;
            DoB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            DoB.Location = new System.Drawing.Point(23, 191);
            DoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DoB.Name = "DoB";
            DoB.Size = new System.Drawing.Size(117, 23);
            DoB.TabIndex = 17;
            DoB.Text = "Date of Birth :";
            // 
            // Sex
            // 
            Sex.AutoSize = true;
            Sex.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            Sex.Location = new System.Drawing.Point(22, 141);
            Sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Sex.Name = "Sex";
            Sex.Size = new System.Drawing.Size(46, 23);
            Sex.TabIndex = 19;
            Sex.Text = "Sex :";
            // 
            // BloodType
            // 
            BloodType.AutoSize = true;
            BloodType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            BloodType.Location = new System.Drawing.Point(23, 299);
            BloodType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            BloodType.Name = "BloodType";
            BloodType.Size = new System.Drawing.Size(104, 23);
            BloodType.TabIndex = 21;
            BloodType.Text = "Blood Type :";
            // 
            // Symtomp
            // 
            Symtomp.AutoSize = true;
            Symtomp.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            Symtomp.Location = new System.Drawing.Point(22, 415);
            Symtomp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Symtomp.Name = "Symtomp";
            Symtomp.Size = new System.Drawing.Size(93, 23);
            Symtomp.TabIndex = 28;
            Symtomp.Text = "Symtomp :";
            // 
            // uC_Button_Resolve
            // 
            uC_Button_Resolve.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            uC_Button_Resolve.BackColor = System.Drawing.Color.Transparent;
            uC_Button_Resolve.BackgroundColor = System.Drawing.Color.Transparent;
            uC_Button_Resolve.BorderColor = System.Drawing.Color.FromArgb(0, 0, 192);
            uC_Button_Resolve.BorderRadius = 0;
            uC_Button_Resolve.BorderSize = 1;
            uC_Button_Resolve.FlatAppearance.BorderSize = 0;
            uC_Button_Resolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            uC_Button_Resolve.Font = new System.Drawing.Font("Segoe UI", 9F);
            uC_Button_Resolve.FontSize = 9;
            uC_Button_Resolve.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            uC_Button_Resolve.Location = new System.Drawing.Point(827, 609);
            uC_Button_Resolve.Margin = new System.Windows.Forms.Padding(4);
            uC_Button_Resolve.Name = "uC_Button_Resolve";
            uC_Button_Resolve.Size = new System.Drawing.Size(169, 58);
            uC_Button_Resolve.TabIndex = 33;
            uC_Button_Resolve.Text = "Resolve";
            uC_Button_Resolve.TextColor = System.Drawing.Color.FromArgb(0, 0, 192);
            uC_Button_Resolve.UseVisualStyleBackColor = false;
            uC_Button_Resolve.Click += uC_Button_Resolve_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // panel_registerForm
            // 
            panel_registerForm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel_registerForm.BackColor = System.Drawing.Color.Transparent;
            panel_registerForm.Controls.Add(RecordName);
            panel_registerForm.Controls.Add(guna2ShadowPanel1);
            panel_registerForm.Controls.Add(CheckIn);
            panel_registerForm.Controls.Add(PatientName);
            panel_registerForm.Controls.Add(Symtomp);
            panel_registerForm.Controls.Add(Sex);
            panel_registerForm.Controls.Add(DoB);
            panel_registerForm.Controls.Add(BloodType);
            panel_registerForm.Controls.Add(Height);
            panel_registerForm.Controls.Add(Weight);
            panel_registerForm.FillColor = System.Drawing.Color.White;
            panel_registerForm.Location = new System.Drawing.Point(146, 13);
            panel_registerForm.Margin = new System.Windows.Forms.Padding(4);
            panel_registerForm.Name = "panel_registerForm";
            panel_registerForm.Radius = 10;
            panel_registerForm.ShadowColor = System.Drawing.Color.Black;
            panel_registerForm.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            panel_registerForm.Size = new System.Drawing.Size(850, 536);
            panel_registerForm.TabIndex = 50;
            // 
            // RecordName
            // 
            RecordName.AutoSize = true;
            RecordName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            RecordName.Location = new System.Drawing.Point(22, 357);
            RecordName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            RecordName.Name = "RecordName";
            RecordName.Size = new System.Drawing.Size(124, 23);
            RecordName.TabIndex = 55;
            RecordName.Text = "Record Name :";
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            guna2ShadowPanel1.Controls.Add(label5);
            guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            guna2ShadowPanel1.ShadowShift = 2;
            guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            guna2ShadowPanel1.Size = new System.Drawing.Size(850, 62);
            guna2ShadowPanel1.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(13, 14);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(215, 31);
            label5.TabIndex = 52;
            label5.Text = "Patient Information";
            // 
            // CheckIn
            // 
            CheckIn.AutoSize = true;
            CheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            CheckIn.Location = new System.Drawing.Point(22, 474);
            CheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CheckIn.Name = "CheckIn";
            CheckIn.Size = new System.Drawing.Size(86, 23);
            CheckIn.TabIndex = 4;
            CheckIn.Text = "Check-in :";
            // 
            // PatientInformation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            ClientSize = new System.Drawing.Size(1113, 829);
            Controls.Add(panel_registerForm);
            Controls.Add(uC_Button_Resolve);
            Font = new System.Drawing.Font("Segoe UI", 10.2F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "PatientInformation";
            RightToLeftLayout = true;
            Text = "PatientDetail";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel_registerForm.ResumeLayout(false);
            panel_registerForm.PerformLayout();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label DoB;
        private System.Windows.Forms.Label BloodType;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label Symtomp;
        private User_Controls.UC_Button uC_Button_Resolve;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_registerForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker NgaySinh;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox TenBenhAn;
        private System.Windows.Forms.Label RecordName;
        private System.Windows.Forms.Label CheckIn;
    }
}