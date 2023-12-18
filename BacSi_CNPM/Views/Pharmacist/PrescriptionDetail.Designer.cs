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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            text_val = new System.Windows.Forms.Label();
            dtgv_donthuoc = new Guna.UI2.WinForms.Guna2DataGridView();
            hdidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            thidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            thnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dongiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hoadonHTBindingSource = new System.Windows.Forms.BindingSource(components);
            patient_name = new System.Windows.Forms.Label();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            ((System.ComponentModel.ISupportInitialize)dtgv_donthuoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoadonHTBindingSource).BeginInit();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // text_val
            // 
            text_val.AutoSize = true;
            text_val.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            text_val.Location = new System.Drawing.Point(29, 17);
            text_val.Name = "text_val";
            text_val.Size = new System.Drawing.Size(96, 31);
            text_val.TabIndex = 18;
            text_val.Text = "Patient:";
            // 
            // dtgv_donthuoc
            // 
            dtgv_donthuoc.AllowUserToAddRows = false;
            dtgv_donthuoc.AllowUserToDeleteRows = false;
            dtgv_donthuoc.AllowUserToResizeColumns = false;
            dtgv_donthuoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dtgv_donthuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_donthuoc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtgv_donthuoc.AutoGenerateColumns = false;
            dtgv_donthuoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_donthuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_donthuoc.ColumnHeadersHeight = 50;
            dtgv_donthuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { hdidDataGridViewTextBoxColumn, thidDataGridViewTextBoxColumn, thnameDataGridViewTextBoxColumn, soluongDataGridViewTextBoxColumn, dongiaDataGridViewTextBoxColumn });
            dtgv_donthuoc.DataSource = hoadonHTBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_donthuoc.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_donthuoc.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_donthuoc.Location = new System.Drawing.Point(29, 60);
            dtgv_donthuoc.Name = "dtgv_donthuoc";
            dtgv_donthuoc.ReadOnly = true;
            dtgv_donthuoc.RowHeadersVisible = false;
            dtgv_donthuoc.RowHeadersWidth = 51;
            dtgv_donthuoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_donthuoc.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_donthuoc.RowTemplate.Height = 50;
            dtgv_donthuoc.RowTemplate.ReadOnly = true;
            dtgv_donthuoc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dtgv_donthuoc.Size = new System.Drawing.Size(1061, 227);
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
            dtgv_donthuoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_donthuoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_donthuoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_donthuoc.ThemeStyle.HeaderStyle.Height = 50;
            dtgv_donthuoc.ThemeStyle.ReadOnly = true;
            dtgv_donthuoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            dtgv_donthuoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dtgv_donthuoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtgv_donthuoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_donthuoc.ThemeStyle.RowsStyle.Height = 50;
            dtgv_donthuoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            dtgv_donthuoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dtgv_donthuoc.CellClick += dtgv_donthuoc_CellClick;
            // 
            // hdidDataGridViewTextBoxColumn
            // 
            hdidDataGridViewTextBoxColumn.DataPropertyName = "hd_id";
            hdidDataGridViewTextBoxColumn.HeaderText = "hd_id";
            hdidDataGridViewTextBoxColumn.MinimumWidth = 6;
            hdidDataGridViewTextBoxColumn.Name = "hdidDataGridViewTextBoxColumn";
            hdidDataGridViewTextBoxColumn.ReadOnly = true;
            hdidDataGridViewTextBoxColumn.Visible = false;
            // 
            // thidDataGridViewTextBoxColumn
            // 
            thidDataGridViewTextBoxColumn.DataPropertyName = "th_id";
            thidDataGridViewTextBoxColumn.HeaderText = "th_id";
            thidDataGridViewTextBoxColumn.MinimumWidth = 6;
            thidDataGridViewTextBoxColumn.Name = "thidDataGridViewTextBoxColumn";
            thidDataGridViewTextBoxColumn.ReadOnly = true;
            thidDataGridViewTextBoxColumn.Visible = false;
            // 
            // thnameDataGridViewTextBoxColumn
            // 
            thnameDataGridViewTextBoxColumn.DataPropertyName = "th_name";
            thnameDataGridViewTextBoxColumn.HeaderText = "Medicine's Name";
            thnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            thnameDataGridViewTextBoxColumn.Name = "thnameDataGridViewTextBoxColumn";
            thnameDataGridViewTextBoxColumn.ReadOnly = true;
            thnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            soluongDataGridViewTextBoxColumn.HeaderText = "Quantity";
            soluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            soluongDataGridViewTextBoxColumn.ReadOnly = true;
            soluongDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dongiaDataGridViewTextBoxColumn
            // 
            dongiaDataGridViewTextBoxColumn.DataPropertyName = "dongia";
            dongiaDataGridViewTextBoxColumn.HeaderText = "Price";
            dongiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            dongiaDataGridViewTextBoxColumn.Name = "dongiaDataGridViewTextBoxColumn";
            dongiaDataGridViewTextBoxColumn.ReadOnly = true;
            dongiaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // hoadonHTBindingSource
            // 
            hoadonHTBindingSource.DataSource = typeof(DTO.hoadonHT);
            // 
            // patient_name
            // 
            patient_name.AutoSize = true;
            patient_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            patient_name.Location = new System.Drawing.Point(130, 17);
            patient_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            patient_name.Name = "patient_name";
            patient_name.Size = new System.Drawing.Size(128, 28);
            patient_name.TabIndex = 21;
            patient_name.Text = "Patien Name";
            patient_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            guna2ShadowPanel1.Controls.Add(text_val);
            guna2ShadowPanel1.Controls.Add(dtgv_donthuoc);
            guna2ShadowPanel1.Controls.Add(patient_name);
            guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            guna2ShadowPanel1.Location = new System.Drawing.Point(12, 12);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 6;
            guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            guna2ShadowPanel1.ShadowShift = 8;
            guna2ShadowPanel1.Size = new System.Drawing.Size(1128, 305);
            guna2ShadowPanel1.TabIndex = 22;
            // 
            // PrescriptionDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1152, 322);
            Controls.Add(guna2ShadowPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "PrescriptionDetail";
            Text = "PrescriptionDetail";
            Load += PrescriptionDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_donthuoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoadonHTBindingSource).EndInit();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label text_val;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_donthuoc;
        private System.Windows.Forms.Label patient_name;
        private System.Windows.Forms.BindingSource hoadonHTBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    }
}