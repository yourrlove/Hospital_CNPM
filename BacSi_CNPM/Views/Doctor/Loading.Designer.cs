namespace Hospital.Views.Doctor
{
    partial class Loading
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
            timer1 = new System.Windows.Forms.Timer(components);
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            label1 = new System.Windows.Forms.Label();
            label_percent = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            guna2CircleProgressBar1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(912, 1313);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 34);
            label1.TabIndex = 0;
            label1.Text = "Loading...";
            // 
            // label_percent
            // 
            label_percent.AutoSize = true;
            label_percent.BackColor = System.Drawing.Color.Transparent;
            label_percent.Font = new System.Drawing.Font("Bahnschrift Condensed", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label_percent.ForeColor = System.Drawing.Color.FromArgb(77, 186, 235);
            label_percent.Location = new System.Drawing.Point(283, 1194);
            label_percent.Name = "label_percent";
            label_percent.Size = new System.Drawing.Size(137, 180);
            label_percent.TabIndex = 1;
            label_percent.Text = "0";
            label_percent.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            label3.Location = new System.Drawing.Point(110, 682);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(300, 70);
            label3.TabIndex = 2;
            label3.Text = "IT'S TIME";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            label4.Location = new System.Drawing.Point(110, 990);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(557, 70);
            label4.TabIndex = 3;
            label4.Text = "OF YOUR HEALTH";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            label5.Location = new System.Drawing.Point(110, 829);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(471, 70);
            label5.TabIndex = 4;
            label5.Text = "TO TAKE CARE";
            label5.Click += label5_Click;
            // 
            // guna2CircleProgressBar1
            // 
            guna2CircleProgressBar1.Controls.Add(label5);
            guna2CircleProgressBar1.Controls.Add(label4);
            guna2CircleProgressBar1.Controls.Add(label3);
            guna2CircleProgressBar1.Controls.Add(label_percent);
            guna2CircleProgressBar1.Controls.Add(label1);
            guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(200, 213, 218, 223);
            guna2CircleProgressBar1.FillThickness = 800;
            guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            guna2CircleProgressBar1.Location = new System.Drawing.Point(12, -619);
            guna2CircleProgressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(18, 48, 100);
            guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(77, 186, 235);
            guna2CircleProgressBar1.ProgressThickness = 700;
            guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleProgressBar1.Size = new System.Drawing.Size(2250, 2250);
            guna2CircleProgressBar1.TabIndex = 0;
            guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.ValueChanged += guna2CircleProgressBar1_ValueChanged;
            // 
            // Loading
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1208, 942);
            Controls.Add(guna2CircleProgressBar1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "Loading";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Loading";
            Load += Loading_Load;
            guna2CircleProgressBar1.ResumeLayout(false);
            guna2CircleProgressBar1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_percent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
    }
}