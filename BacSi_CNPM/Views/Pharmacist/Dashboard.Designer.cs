namespace Hospital.Views.Pharmacist
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            guna2Panel3.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel3
            // 
            guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            guna2Panel3.Controls.Add(label8);
            guna2Panel3.Controls.Add(label7);
            guna2Panel3.Controls.Add(label6);
            guna2Panel3.CustomizableEdges = customizableEdges1;
            guna2Panel3.FillColor = System.Drawing.Color.FromArgb(30, 48, 88);
            guna2Panel3.Location = new System.Drawing.Point(42, 31);
            guna2Panel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel3.Size = new System.Drawing.Size(878, 156);
            guna2Panel3.TabIndex = 122;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(42, 94);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(165, 29);
            label8.TabIndex = 12;
            label8.Text = "Have a nice day!";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(215, 25);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(203, 43);
            label7.TabIndex = 11;
            label7.Text = "Pharmacist";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(40, 25);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(171, 43);
            label6.TabIndex = 10;
            label6.Text = "Welcome,";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1395, 991);
            Controls.Add(guna2Panel3);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}