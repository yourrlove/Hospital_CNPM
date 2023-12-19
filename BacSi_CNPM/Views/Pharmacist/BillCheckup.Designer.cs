namespace Hospital.Views.Pharmacist
{
    partial class BillCheckup
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            dtgv_patient = new Guna.UI2.WinForms.Guna2DataGridView();
            bNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nhomMauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            canNangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            chieuCaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            benhNhanBindingSource = new System.Windows.Forms.BindingSource(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            dtgv_patientbills = new Guna.UI2.WinForms.Guna2DataGridView();
            hdidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenhoadonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ngayxuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tongtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            thanhtoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hoaDonBenhNhanBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dtgv_patient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)benhNhanBindingSource).BeginInit();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_patientbills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonBenhNhanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtgv_patient
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dtgv_patient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_patient.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_patient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_patient.ColumnHeadersHeight = 22;
            dtgv_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_patient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { bNIDDataGridViewTextBoxColumn, hoTenDataGridViewTextBoxColumn, gioiTinhDataGridViewTextBoxColumn, ngaySinhDataGridViewTextBoxColumn, diaChiDataGridViewTextBoxColumn, soDienThoaiDataGridViewTextBoxColumn, nhomMauDataGridViewTextBoxColumn, canNangDataGridViewTextBoxColumn, chieuCaoDataGridViewTextBoxColumn });
            dtgv_patient.DataSource = benhNhanBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_patient.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_patient.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_patient.Location = new System.Drawing.Point(30, 79);
            dtgv_patient.Name = "dtgv_patient";
            dtgv_patient.RowHeadersVisible = false;
            dtgv_patient.RowHeadersWidth = 51;
            dtgv_patient.RowTemplate.Height = 29;
            dtgv_patient.Size = new System.Drawing.Size(492, 607);
            dtgv_patient.TabIndex = 0;
            dtgv_patient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_patient.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_patient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_patient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_patient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_patient.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_patient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_patient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_patient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_patient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_patient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_patient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_patient.ThemeStyle.HeaderStyle.Height = 22;
            dtgv_patient.ThemeStyle.ReadOnly = false;
            dtgv_patient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_patient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_patient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_patient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_patient.ThemeStyle.RowsStyle.Height = 29;
            dtgv_patient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_patient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_patient.CellClick += dtgv_patient_CellClick;
            // 
            // bNIDDataGridViewTextBoxColumn
            // 
            bNIDDataGridViewTextBoxColumn.DataPropertyName = "BN_ID";
            bNIDDataGridViewTextBoxColumn.HeaderText = "BN_ID";
            bNIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            bNIDDataGridViewTextBoxColumn.Name = "bNIDDataGridViewTextBoxColumn";
            bNIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            diaChiDataGridViewTextBoxColumn.Visible = false;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            // 
            // nhomMauDataGridViewTextBoxColumn
            // 
            nhomMauDataGridViewTextBoxColumn.DataPropertyName = "NhomMau";
            nhomMauDataGridViewTextBoxColumn.HeaderText = "NhomMau";
            nhomMauDataGridViewTextBoxColumn.MinimumWidth = 6;
            nhomMauDataGridViewTextBoxColumn.Name = "nhomMauDataGridViewTextBoxColumn";
            nhomMauDataGridViewTextBoxColumn.Visible = false;
            // 
            // canNangDataGridViewTextBoxColumn
            // 
            canNangDataGridViewTextBoxColumn.DataPropertyName = "CanNang";
            canNangDataGridViewTextBoxColumn.HeaderText = "CanNang";
            canNangDataGridViewTextBoxColumn.MinimumWidth = 6;
            canNangDataGridViewTextBoxColumn.Name = "canNangDataGridViewTextBoxColumn";
            canNangDataGridViewTextBoxColumn.Visible = false;
            // 
            // chieuCaoDataGridViewTextBoxColumn
            // 
            chieuCaoDataGridViewTextBoxColumn.DataPropertyName = "ChieuCao";
            chieuCaoDataGridViewTextBoxColumn.HeaderText = "ChieuCao";
            chieuCaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            chieuCaoDataGridViewTextBoxColumn.Name = "chieuCaoDataGridViewTextBoxColumn";
            chieuCaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // benhNhanBindingSource
            // 
            benhNhanBindingSource.DataSource = typeof(DTO.BenhNhan);
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(dtgv_patientbills);
            guna2Panel1.Controls.Add(dtgv_patient);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new System.Drawing.Point(12, 12);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new System.Drawing.Size(1134, 840);
            guna2Panel1.TabIndex = 1;
            // 
            // dtgv_patientbills
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dtgv_patientbills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_patientbills.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_patientbills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgv_patientbills.ColumnHeadersHeight = 22;
            dtgv_patientbills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_patientbills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { hdidDataGridViewTextBoxColumn, tenhoadonDataGridViewTextBoxColumn, ngayxuatDataGridViewTextBoxColumn, tongtienDataGridViewTextBoxColumn, thanhtoanDataGridViewTextBoxColumn });
            dtgv_patientbills.DataSource = hoaDonBenhNhanBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_patientbills.DefaultCellStyle = dataGridViewCellStyle6;
            dtgv_patientbills.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_patientbills.Location = new System.Drawing.Point(656, 79);
            dtgv_patientbills.Name = "dtgv_patientbills";
            dtgv_patientbills.RowHeadersVisible = false;
            dtgv_patientbills.RowHeadersWidth = 51;
            dtgv_patientbills.RowTemplate.Height = 29;
            dtgv_patientbills.Size = new System.Drawing.Size(425, 383);
            dtgv_patientbills.TabIndex = 1;
            dtgv_patientbills.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_patientbills.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_patientbills.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_patientbills.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_patientbills.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_patientbills.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_patientbills.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_patientbills.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_patientbills.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_patientbills.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_patientbills.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_patientbills.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_patientbills.ThemeStyle.HeaderStyle.Height = 22;
            dtgv_patientbills.ThemeStyle.ReadOnly = false;
            dtgv_patientbills.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_patientbills.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_patientbills.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_patientbills.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_patientbills.ThemeStyle.RowsStyle.Height = 29;
            dtgv_patientbills.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_patientbills.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_patientbills.CellContentClick += dtgv_patientbills_CellContentClick;
            // 
            // hdidDataGridViewTextBoxColumn
            // 
            hdidDataGridViewTextBoxColumn.DataPropertyName = "hd_id";
            hdidDataGridViewTextBoxColumn.HeaderText = "hd_id";
            hdidDataGridViewTextBoxColumn.MinimumWidth = 6;
            hdidDataGridViewTextBoxColumn.Name = "hdidDataGridViewTextBoxColumn";
            hdidDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenhoadonDataGridViewTextBoxColumn
            // 
            tenhoadonDataGridViewTextBoxColumn.DataPropertyName = "tenhoadon";
            tenhoadonDataGridViewTextBoxColumn.HeaderText = "tenhoadon";
            tenhoadonDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenhoadonDataGridViewTextBoxColumn.Name = "tenhoadonDataGridViewTextBoxColumn";
            // 
            // ngayxuatDataGridViewTextBoxColumn
            // 
            ngayxuatDataGridViewTextBoxColumn.DataPropertyName = "ngayxuat";
            ngayxuatDataGridViewTextBoxColumn.HeaderText = "ngayxuat";
            ngayxuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            ngayxuatDataGridViewTextBoxColumn.Name = "ngayxuatDataGridViewTextBoxColumn";
            // 
            // tongtienDataGridViewTextBoxColumn
            // 
            tongtienDataGridViewTextBoxColumn.DataPropertyName = "tongtien";
            tongtienDataGridViewTextBoxColumn.HeaderText = "tongtien";
            tongtienDataGridViewTextBoxColumn.MinimumWidth = 6;
            tongtienDataGridViewTextBoxColumn.Name = "tongtienDataGridViewTextBoxColumn";
            // 
            // thanhtoanDataGridViewTextBoxColumn
            // 
            thanhtoanDataGridViewTextBoxColumn.DataPropertyName = "thanhtoan";
            thanhtoanDataGridViewTextBoxColumn.HeaderText = "thanhtoan";
            thanhtoanDataGridViewTextBoxColumn.MinimumWidth = 6;
            thanhtoanDataGridViewTextBoxColumn.Name = "thanhtoanDataGridViewTextBoxColumn";
            thanhtoanDataGridViewTextBoxColumn.Visible = false;
            // 
            // hoaDonBenhNhanBindingSource
            // 
            hoaDonBenhNhanBindingSource.DataSource = typeof(DTO.HoaDonBenhNhan);
            // 
            // BillCheckup
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1182, 903);
            Controls.Add(guna2Panel1);
            Name = "BillCheckup";
            Text = "BillCheckup";
            ((System.ComponentModel.ISupportInitialize)dtgv_patient).EndInit();
            ((System.ComponentModel.ISupportInitialize)benhNhanBindingSource).EndInit();
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_patientbills).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonBenhNhanBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dtgv_patient;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomMauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn canNangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chieuCaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource benhNhanBindingSource;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_patientbills;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhoadonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayxuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hoaDonBenhNhanBindingSource;
    }
}