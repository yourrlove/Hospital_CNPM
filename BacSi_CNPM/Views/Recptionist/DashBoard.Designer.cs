namespace Hospital.Views.Receptionist
{
    partial class DashBoard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dashboardpanel = new Guna.UI2.WinForms.Guna2Panel();
            uC_Button2 = new User_Controls.UC_Button();
            uC_Button1 = new User_Controls.UC_Button();
            monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            SuspendLayout();
            // 
            // dashboardpanel
            // 
            dashboardpanel.CustomizableEdges = customizableEdges1;
            dashboardpanel.Dock = System.Windows.Forms.DockStyle.Left;
            dashboardpanel.Location = new System.Drawing.Point(0, 0);
            dashboardpanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dashboardpanel.Name = "dashboardpanel";
            dashboardpanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dashboardpanel.Size = new System.Drawing.Size(848, 951);
            dashboardpanel.TabIndex = 0;
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
            uC_Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uC_Button2.FontSize = 9;
            uC_Button2.ForeColor = System.Drawing.Color.White;
            uC_Button2.Location = new System.Drawing.Point(893, 374);
            uC_Button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uC_Button2.Name = "uC_Button2";
            uC_Button2.Size = new System.Drawing.Size(150, 50);
            uC_Button2.TabIndex = 2;
            uC_Button2.Text = "UPDATE";
            uC_Button2.TextColor = System.Drawing.Color.White;
            uC_Button2.UseVisualStyleBackColor = false;
            // 
            // uC_Button1
            // 
            uC_Button1.BackColor = System.Drawing.Color.Blue;
            uC_Button1.BackgroundColor = System.Drawing.Color.Blue;
            uC_Button1.BorderColor = System.Drawing.Color.Blue;
            uC_Button1.BorderRadius = 0;
            uC_Button1.BorderSize = 0;
            uC_Button1.FlatAppearance.BorderSize = 0;
            uC_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            uC_Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uC_Button1.FontSize = 9;
            uC_Button1.ForeColor = System.Drawing.Color.White;
            uC_Button1.Location = new System.Drawing.Point(893, 287);
            uC_Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uC_Button1.Name = "uC_Button1";
            uC_Button1.Size = new System.Drawing.Size(150, 50);
            uC_Button1.TabIndex = 1;
            uC_Button1.Text = "ADD";
            uC_Button1.TextColor = System.Drawing.Color.White;
            uC_Button1.UseVisualStyleBackColor = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new System.Drawing.Point(872, 10);
            monthCalendar1.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1152, 951);
            Controls.Add(monthCalendar1);
            Controls.Add(uC_Button2);
            Controls.Add(dashboardpanel);
            Controls.Add(uC_Button1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "DashBoard";
            Text = "DashBoard";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel dashboardpanel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private User_Controls.UC_Button uC_Button2;
        private User_Controls.UC_Button uC_Button1;
    }
}