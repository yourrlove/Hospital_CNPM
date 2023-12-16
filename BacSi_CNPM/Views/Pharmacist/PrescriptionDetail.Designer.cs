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
            dtgv_donthuoc = new Guna.UI2.WinForms.Guna2DataGridView();
            patient_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dtgv_donthuoc).BeginInit();
            SuspendLayout();
            // 
            // text_val
            // 
            text_val.AutoSize = true;
            text_val.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            text_val.Location = new System.Drawing.Point(75, 32);
            text_val.Name = "text_val";
            text_val.Size = new System.Drawing.Size(70, 28);
            text_val.TabIndex = 18;
            text_val.Text = "Patient:";
            // 
            // dtgv_donthuoc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dtgv_donthuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_donthuoc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtgv_donthuoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_donthuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_donthuoc.ColumnHeadersHeight = 50;
            dtgv_donthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_donthuoc.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_donthuoc.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_donthuoc.Location = new System.Drawing.Point(26, 81);
            dtgv_donthuoc.Name = "dtgv_donthuoc";
            dtgv_donthuoc.RowHeadersVisible = false;
            dtgv_donthuoc.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_donthuoc.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_donthuoc.RowTemplate.Height = 50;
            dtgv_donthuoc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dtgv_donthuoc.Size = new System.Drawing.Size(513, 617);
            dtgv_donthuoc.TabIndex = 19;
            dtgv_donthuoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_donthuoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_donthuoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_donthuoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_donthuoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_donthuoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_donthuoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_donthuoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_donthuoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_donthuoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_donthuoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_donthuoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_donthuoc.ThemeStyle.HeaderStyle.Height = 50;
            dtgv_donthuoc.ThemeStyle.ReadOnly = false;
            dtgv_donthuoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_donthuoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_donthuoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_donthuoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_donthuoc.ThemeStyle.RowsStyle.Height = 50;
            dtgv_donthuoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            dtgv_donthuoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dtgv_donthuoc.CellClick += dtgv_donthuoc_CellClick;
            // 
            // patient_name
            // 
            patient_name.AutoSize = true;
            patient_name.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            patient_name.Location = new System.Drawing.Point(150, 32);
            patient_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            patient_name.Name = "patient_name";
            patient_name.Size = new System.Drawing.Size(134, 28);
            patient_name.TabIndex = 21;
            patient_name.Text = "Patien Name";
            patient_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PrescriptionDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(568, 882);
            Controls.Add(patient_name);
            Controls.Add(dtgv_donthuoc);
            Controls.Add(text_val);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "PrescriptionDetail";
            Text = "PrescriptionDetail";
            ((System.ComponentModel.ISupportInitialize)dtgv_donthuoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label text_val;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_donthuoc;
        private System.Windows.Forms.Label patient_name;
    }
}