namespace Hospital.Views.Pharmacist
{
    partial class PrescriptionDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            text_val = new System.Windows.Forms.Label();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            uC_Button1 = new User_Controls.UC_Button();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // text_val
            // 
            text_val.AutoSize = true;
            text_val.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            text_val.Location = new System.Drawing.Point(26, 32);
            text_val.Name = "text_val";
            text_val.Size = new System.Drawing.Size(66, 28);
            text_val.TabIndex = 18;
            text_val.Text = "Patient";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 50;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column2 });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new System.Drawing.Point(26, 81);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            guna2DataGridView1.RowTemplate.Height = 50;
            guna2DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            guna2DataGridView1.Size = new System.Drawing.Size(789, 699);
            guna2DataGridView1.TabIndex = 19;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 50;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 50;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Column2
            // 
            Column2.HeaderText = "ID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // uC_Button1
            // 
            uC_Button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            uC_Button1.BackColor = System.Drawing.Color.Blue;
            uC_Button1.BackgroundColor = System.Drawing.Color.Blue;
            uC_Button1.BorderColor = System.Drawing.Color.Blue;
            uC_Button1.BorderRadius = 0;
            uC_Button1.BorderSize = 0;
            uC_Button1.FlatAppearance.BorderSize = 0;
            uC_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            uC_Button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uC_Button1.FontSize = 11;
            uC_Button1.ForeColor = System.Drawing.Color.White;
            uC_Button1.Location = new System.Drawing.Point(627, 808);
            uC_Button1.Name = "uC_Button1";
            uC_Button1.Size = new System.Drawing.Size(188, 50);
            uC_Button1.TabIndex = 20;
            uC_Button1.Text = "End";
            uC_Button1.TextColor = System.Drawing.Color.White;
            uC_Button1.UseVisualStyleBackColor = false;
            // 
            // PrescriptionDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(844, 887);
            Controls.Add(uC_Button1);
            Controls.Add(guna2DataGridView1);
            Controls.Add(text_val);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "PrescriptionDetail";
            Text = "PrescriptionDetail";
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label text_val;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private User_Controls.UC_Button uC_Button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}