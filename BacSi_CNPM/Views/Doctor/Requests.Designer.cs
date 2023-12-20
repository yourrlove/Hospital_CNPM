namespace Hospital.Views.Doctor
{
    partial class Requests
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            benhNhanBindingSource = new System.Windows.Forms.BindingSource(components);
            uC_Button2 = new User_Controls.UC_Button();
            uC_Button3 = new User_Controls.UC_Button();
            timer1 = new System.Windows.Forms.Timer(components);
            numOfRequests = new System.Windows.Forms.Label();
            requestCount = new System.Windows.Forms.Label();
            uC_Button_Next = new User_Controls.UC_Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel_PatientDetails = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)benhNhanBindingSource).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // benhNhanBindingSource
            // 
            benhNhanBindingSource.DataSource = typeof(DTO.BenhNhan);
            // 
            // uC_Button2
            // 
            uC_Button2.BackColor = System.Drawing.Color.Blue;
            uC_Button2.BackgroundColor = System.Drawing.Color.Blue;
            uC_Button2.BorderColor = System.Drawing.Color.Blue;
            uC_Button2.BorderRadius = 0;
            uC_Button2.BorderSize = 0;
            uC_Button2.FlatAppearance.BorderSize = 0;
            uC_Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            uC_Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            uC_Button2.FontSize = 9;
            uC_Button2.ForeColor = System.Drawing.Color.White;
            uC_Button2.Location = new System.Drawing.Point(3, 3);
            uC_Button2.Name = "uC_Button2";
            uC_Button2.Size = new System.Drawing.Size(188, 50);
            uC_Button2.TabIndex = 0;
            uC_Button2.Text = "uC_Button2";
            uC_Button2.TextColor = System.Drawing.Color.White;
            uC_Button2.UseVisualStyleBackColor = false;
            // 
            // uC_Button3
            // 
            uC_Button3.BackColor = System.Drawing.Color.Blue;
            uC_Button3.BackgroundColor = System.Drawing.Color.Blue;
            uC_Button3.BorderColor = System.Drawing.Color.Blue;
            uC_Button3.BorderRadius = 0;
            uC_Button3.BorderSize = 0;
            uC_Button3.FlatAppearance.BorderSize = 0;
            uC_Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            uC_Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            uC_Button3.FontSize = 9;
            uC_Button3.ForeColor = System.Drawing.Color.White;
            uC_Button3.Location = new System.Drawing.Point(92, 29);
            uC_Button3.Name = "uC_Button3";
            uC_Button3.Size = new System.Drawing.Size(188, 50);
            uC_Button3.TabIndex = 1;
            uC_Button3.Text = "uC_Button3";
            uC_Button3.TextColor = System.Drawing.Color.White;
            uC_Button3.UseVisualStyleBackColor = false;
            // 
            // numOfRequests
            // 
            numOfRequests.AutoSize = true;
            numOfRequests.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            numOfRequests.Location = new System.Drawing.Point(110, 48);
            numOfRequests.Name = "numOfRequests";
            numOfRequests.Size = new System.Drawing.Size(90, 28);
            numOfRequests.TabIndex = 1;
            numOfRequests.Text = "Requests";
            numOfRequests.Click += label1_patientnum_Click;
            // 
            // requestCount
            // 
            requestCount.AutoSize = true;
            requestCount.Font = new System.Drawing.Font("Segoe UI", 31.8000011F, System.Drawing.FontStyle.Bold);
            requestCount.ForeColor = System.Drawing.Color.RoyalBlue;
            requestCount.Location = new System.Drawing.Point(12, 26);
            requestCount.Name = "requestCount";
            requestCount.Size = new System.Drawing.Size(92, 72);
            requestCount.TabIndex = 0;
            requestCount.Text = "20";
            // 
            // uC_Button_Next
            // 
            uC_Button_Next.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            uC_Button_Next.BackColor = System.Drawing.Color.Blue;
            uC_Button_Next.BackgroundColor = System.Drawing.Color.Blue;
            uC_Button_Next.BorderColor = System.Drawing.Color.Blue;
            uC_Button_Next.BorderRadius = 0;
            uC_Button_Next.BorderSize = 0;
            uC_Button_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            uC_Button_Next.FlatAppearance.BorderSize = 0;
            uC_Button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            uC_Button_Next.Font = new System.Drawing.Font("Segoe UI", 9F);
            uC_Button_Next.FontSize = 9;
            uC_Button_Next.ForeColor = System.Drawing.Color.White;
            uC_Button_Next.Location = new System.Drawing.Point(966, 26);
            uC_Button_Next.Name = "uC_Button_Next";
            uC_Button_Next.Size = new System.Drawing.Size(152, 50);
            uC_Button_Next.TabIndex = 4;
            uC_Button_Next.Text = "Next Patient";
            uC_Button_Next.TextColor = System.Drawing.Color.White;
            uC_Button_Next.UseVisualStyleBackColor = false;
            uC_Button_Next.Click += uC_Button_Next_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(numOfRequests);
            guna2Panel1.Controls.Add(uC_Button_Next);
            guna2Panel1.Controls.Add(requestCount);
            guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver;
            guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            guna2Panel1.Location = new System.Drawing.Point(0, 0);
            guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new System.Drawing.Size(1152, 109);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel_PatientDetails
            // 
            guna2Panel_PatientDetails.CustomizableEdges = customizableEdges3;
            guna2Panel_PatientDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            guna2Panel_PatientDetails.Location = new System.Drawing.Point(0, 109);
            guna2Panel_PatientDetails.Name = "guna2Panel_PatientDetails";
            guna2Panel_PatientDetails.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel_PatientDetails.Size = new System.Drawing.Size(1152, 810);
            guna2Panel_PatientDetails.TabIndex = 1;
            // 
            // Requests
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            ClientSize = new System.Drawing.Size(1152, 919);
            Controls.Add(guna2Panel_PatientDetails);
            Controls.Add(guna2Panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Requests";
            Text = "Patient";
            Load += Patient_Load;
            ((System.ComponentModel.ISupportInitialize)benhNhanBindingSource).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private User_Controls.UC_Button uC_Button3;
        private User_Controls.UC_Button uC_Button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource benhNhanBindingSource;
        private User_Controls.UC_Button uC_Button7;
        private System.Windows.Forms.Label numOfRequests;
        private System.Windows.Forms.Label requestCount;
        private User_Controls.UC_Button uC_Button_Next;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel_PatientDetails;
    }
}