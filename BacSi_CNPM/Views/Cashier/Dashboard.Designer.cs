namespace Hospital.Views.Cashier
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            info_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnEditCashier = new Guna.UI2.WinForms.Guna2Button();
            label1 = new System.Windows.Forms.Label();
            cashierName = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            calendar_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label2 = new System.Windows.Forms.Label();
            monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            info_panel.SuspendLayout();
            calendar_panel.SuspendLayout();
            SuspendLayout();
            // 
            // info_panel
            // 
            info_panel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            info_panel.BackColor = System.Drawing.Color.Transparent;
            info_panel.Controls.Add(btnEditCashier);
            info_panel.Controls.Add(label1);
            info_panel.Controls.Add(cashierName);
            info_panel.Controls.Add(label11);
            info_panel.FillColor = System.Drawing.Color.White;
            info_panel.Location = new System.Drawing.Point(792, 12);
            info_panel.Name = "info_panel";
            info_panel.Radius = 10;
            info_panel.ShadowColor = System.Drawing.Color.Black;
            info_panel.ShadowDepth = 50;
            info_panel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            info_panel.Size = new System.Drawing.Size(348, 492);
            info_panel.TabIndex = 137;
            // 
            // btnEditCashier
            // 
            btnEditCashier.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnEditCashier.BorderColor = System.Drawing.Color.Gray;
            btnEditCashier.BorderRadius = 4;
            btnEditCashier.BorderThickness = 1;
            btnEditCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditCashier.CustomizableEdges = customizableEdges1;
            btnEditCashier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnEditCashier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnEditCashier.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            btnEditCashier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            btnEditCashier.FillColor = System.Drawing.Color.Transparent;
            btnEditCashier.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnEditCashier.ForeColor = System.Drawing.Color.Black;
            btnEditCashier.Image = (System.Drawing.Image)resources.GetObject("btnEditCashier.Image");
            btnEditCashier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            btnEditCashier.ImageOffset = new System.Drawing.Point(3, 0);
            btnEditCashier.ImageSize = new System.Drawing.Size(38, 38);
            btnEditCashier.Location = new System.Drawing.Point(70, 406);
            btnEditCashier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEditCashier.Name = "btnEditCashier";
            btnEditCashier.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEditCashier.Size = new System.Drawing.Size(224, 56);
            btnEditCashier.TabIndex = 11;
            btnEditCashier.Text = "Edit Information";
            btnEditCashier.TextOffset = new System.Drawing.Point(10, 0);
            btnEditCashier.Click += btnEditPharmacist_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(143, 343);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 28);
            label1.TabIndex = 10;
            label1.Text = "Cashier";
            // 
            // cashierName
            // 
            cashierName.AutoSize = true;
            cashierName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            cashierName.Location = new System.Drawing.Point(70, 289);
            cashierName.Name = "cashierName";
            cashierName.Size = new System.Drawing.Size(229, 31);
            cashierName.TabIndex = 9;
            cashierName.Text = "Mr. Dang Thanh Dat";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            label11.ForeColor = System.Drawing.Color.RoyalBlue;
            label11.Location = new System.Drawing.Point(63, 16);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(231, 38);
            label11.TabIndex = 10;
            label11.Text = "Have a nice day!";
            // 
            // calendar_panel
            // 
            calendar_panel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            calendar_panel.BackColor = System.Drawing.Color.Transparent;
            calendar_panel.Controls.Add(label2);
            calendar_panel.Controls.Add(monthCalendar1);
            calendar_panel.FillColor = System.Drawing.Color.White;
            calendar_panel.Location = new System.Drawing.Point(792, 525);
            calendar_panel.Name = "calendar_panel";
            calendar_panel.Radius = 10;
            calendar_panel.ShadowColor = System.Drawing.Color.Black;
            calendar_panel.ShadowDepth = 50;
            calendar_panel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            calendar_panel.Size = new System.Drawing.Size(348, 296);
            calendar_panel.TabIndex = 138;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.Navy;
            label2.Location = new System.Drawing.Point(18, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(108, 31);
            label2.TabIndex = 10;
            label2.Text = "Calendar";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            monthCalendar1.Location = new System.Drawing.Point(33, 59);
            monthCalendar1.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowWeekNumbers = true;
            monthCalendar1.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1152, 919);
            Controls.Add(calendar_panel);
            Controls.Add(info_panel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            info_panel.ResumeLayout(false);
            info_panel.PerformLayout();
            calendar_panel.ResumeLayout(false);
            calendar_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel info_panel;
        private Guna.UI2.WinForms.Guna2Button btnEditCashier;
        private User_Controls.UC_PictureBox uC_PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cashierName;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ShadowPanel calendar_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}