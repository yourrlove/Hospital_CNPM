namespace Hospital.Views.Cashier
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillCheckup));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            tb_searchpatient = new Guna.UI2.WinForms.Guna2TextBox();
            dtgv_patientbills = new Guna.UI2.WinForms.Guna2DataGridView();
            hdidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenhoadonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ngayxuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tongtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            thanhtoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hoaDonBenhNhanBindingSource = new System.Windows.Forms.BindingSource(components);
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
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_patientbills).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonBenhNhanBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_patient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)benhNhanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(tb_searchpatient);
            guna2Panel1.Controls.Add(dtgv_patientbills);
            guna2Panel1.Controls.Add(dtgv_patient);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new System.Drawing.Point(12, 12);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new System.Drawing.Size(1166, 840);
            guna2Panel1.TabIndex = 0;
            // 
            // tb_searchpatient
            // 
            tb_searchpatient.BorderRadius = 24;
            tb_searchpatient.CustomizableEdges = customizableEdges1;
            tb_searchpatient.DefaultText = "";
            tb_searchpatient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            tb_searchpatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            tb_searchpatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            tb_searchpatient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            tb_searchpatient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            tb_searchpatient.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tb_searchpatient.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            tb_searchpatient.IconLeft = (System.Drawing.Image)resources.GetObject("tb_searchpatient.IconLeft");
            tb_searchpatient.IconLeftSize = new System.Drawing.Size(40, 40);
            tb_searchpatient.Location = new System.Drawing.Point(12, 23);
            tb_searchpatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tb_searchpatient.Name = "tb_searchpatient";
            tb_searchpatient.PasswordChar = '\0';
            tb_searchpatient.PlaceholderText = "Search patient ...";
            tb_searchpatient.SelectedText = "";
            tb_searchpatient.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tb_searchpatient.Size = new System.Drawing.Size(408, 54);
            tb_searchpatient.TabIndex = 2;
            tb_searchpatient.TextOffset = new System.Drawing.Point(10, 0);
            tb_searchpatient.TextChanged += tb_searchpatient_TextChanged;
            // 
            // dtgv_patientbills
            // 
            dtgv_patientbills.AllowUserToAddRows = false;
            dtgv_patientbills.AllowUserToDeleteRows = false;
            dtgv_patientbills.AllowUserToResizeColumns = false;
            dtgv_patientbills.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dtgv_patientbills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_patientbills.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            dtgv_patientbills.AutoGenerateColumns = false;
            dtgv_patientbills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_patientbills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_patientbills.ColumnHeadersHeight = 50;
            dtgv_patientbills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { hdidDataGridViewTextBoxColumn, tenhoadonDataGridViewTextBoxColumn, ngayxuatDataGridViewTextBoxColumn, tongtienDataGridViewTextBoxColumn, thanhtoanDataGridViewTextBoxColumn });
            dtgv_patientbills.DataSource = hoaDonBenhNhanBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_patientbills.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_patientbills.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_patientbills.Location = new System.Drawing.Point(685, 96);
            dtgv_patientbills.Name = "dtgv_patientbills";
            dtgv_patientbills.ReadOnly = true;
            dtgv_patientbills.RowHeadersVisible = false;
            dtgv_patientbills.RowHeadersWidth = 51;
            dtgv_patientbills.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgv_patientbills.RowTemplate.Height = 40;
            dtgv_patientbills.RowTemplate.ReadOnly = true;
            dtgv_patientbills.Size = new System.Drawing.Size(449, 570);
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
            dtgv_patientbills.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_patientbills.ThemeStyle.HeaderStyle.Height = 50;
            dtgv_patientbills.ThemeStyle.ReadOnly = true;
            dtgv_patientbills.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_patientbills.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_patientbills.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_patientbills.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_patientbills.ThemeStyle.RowsStyle.Height = 40;
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
            hdidDataGridViewTextBoxColumn.ReadOnly = true;
            hdidDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenhoadonDataGridViewTextBoxColumn
            // 
            tenhoadonDataGridViewTextBoxColumn.DataPropertyName = "tenhoadon";
            tenhoadonDataGridViewTextBoxColumn.HeaderText = "Invoice name";
            tenhoadonDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenhoadonDataGridViewTextBoxColumn.Name = "tenhoadonDataGridViewTextBoxColumn";
            tenhoadonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayxuatDataGridViewTextBoxColumn
            // 
            ngayxuatDataGridViewTextBoxColumn.DataPropertyName = "ngayxuat";
            ngayxuatDataGridViewTextBoxColumn.HeaderText = "Invoice Date";
            ngayxuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            ngayxuatDataGridViewTextBoxColumn.Name = "ngayxuatDataGridViewTextBoxColumn";
            ngayxuatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongtienDataGridViewTextBoxColumn
            // 
            tongtienDataGridViewTextBoxColumn.DataPropertyName = "tongtien";
            tongtienDataGridViewTextBoxColumn.HeaderText = "Total Cost";
            tongtienDataGridViewTextBoxColumn.MinimumWidth = 6;
            tongtienDataGridViewTextBoxColumn.Name = "tongtienDataGridViewTextBoxColumn";
            tongtienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thanhtoanDataGridViewTextBoxColumn
            // 
            thanhtoanDataGridViewTextBoxColumn.DataPropertyName = "thanhtoan";
            thanhtoanDataGridViewTextBoxColumn.HeaderText = "thanhtoan";
            thanhtoanDataGridViewTextBoxColumn.MinimumWidth = 6;
            thanhtoanDataGridViewTextBoxColumn.Name = "thanhtoanDataGridViewTextBoxColumn";
            thanhtoanDataGridViewTextBoxColumn.ReadOnly = true;
            thanhtoanDataGridViewTextBoxColumn.Visible = false;
            // 
            // hoaDonBenhNhanBindingSource
            // 
            hoaDonBenhNhanBindingSource.DataSource = typeof(DTO.HoaDonBenhNhan);
            // 
            // dtgv_patient
            // 
            dtgv_patient.AllowUserToAddRows = false;
            dtgv_patient.AllowUserToDeleteRows = false;
            dtgv_patient.AllowUserToResizeColumns = false;
            dtgv_patient.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dtgv_patient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_patient.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtgv_patient.AutoGenerateColumns = false;
            dtgv_patient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_patient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgv_patient.ColumnHeadersHeight = 50;
            dtgv_patient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { bNIDDataGridViewTextBoxColumn, hoTenDataGridViewTextBoxColumn, gioiTinhDataGridViewTextBoxColumn, ngaySinhDataGridViewTextBoxColumn, diaChiDataGridViewTextBoxColumn, soDienThoaiDataGridViewTextBoxColumn, nhomMauDataGridViewTextBoxColumn, canNangDataGridViewTextBoxColumn, chieuCaoDataGridViewTextBoxColumn });
            dtgv_patient.DataSource = benhNhanBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_patient.DefaultCellStyle = dataGridViewCellStyle6;
            dtgv_patient.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_patient.Location = new System.Drawing.Point(12, 96);
            dtgv_patient.Name = "dtgv_patient";
            dtgv_patient.ReadOnly = true;
            dtgv_patient.RowHeadersVisible = false;
            dtgv_patient.RowHeadersWidth = 51;
            dtgv_patient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgv_patient.RowTemplate.Height = 40;
            dtgv_patient.RowTemplate.ReadOnly = true;
            dtgv_patient.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_patient.Size = new System.Drawing.Size(628, 570);
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
            dtgv_patient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_patient.ThemeStyle.HeaderStyle.Height = 50;
            dtgv_patient.ThemeStyle.ReadOnly = true;
            dtgv_patient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_patient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_patient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_patient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_patient.ThemeStyle.RowsStyle.Height = 40;
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
            bNIDDataGridViewTextBoxColumn.ReadOnly = true;
            bNIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            hoTenDataGridViewTextBoxColumn.HeaderText = "Full Name";
            hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            gioiTinhDataGridViewTextBoxColumn.HeaderText = "Sex";
            gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            ngaySinhDataGridViewTextBoxColumn.HeaderText = "Date of birth";
            ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            diaChiDataGridViewTextBoxColumn.Visible = false;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nhomMauDataGridViewTextBoxColumn
            // 
            nhomMauDataGridViewTextBoxColumn.DataPropertyName = "NhomMau";
            nhomMauDataGridViewTextBoxColumn.HeaderText = "NhomMau";
            nhomMauDataGridViewTextBoxColumn.MinimumWidth = 6;
            nhomMauDataGridViewTextBoxColumn.Name = "nhomMauDataGridViewTextBoxColumn";
            nhomMauDataGridViewTextBoxColumn.ReadOnly = true;
            nhomMauDataGridViewTextBoxColumn.Visible = false;
            // 
            // canNangDataGridViewTextBoxColumn
            // 
            canNangDataGridViewTextBoxColumn.DataPropertyName = "CanNang";
            canNangDataGridViewTextBoxColumn.HeaderText = "CanNang";
            canNangDataGridViewTextBoxColumn.MinimumWidth = 6;
            canNangDataGridViewTextBoxColumn.Name = "canNangDataGridViewTextBoxColumn";
            canNangDataGridViewTextBoxColumn.ReadOnly = true;
            canNangDataGridViewTextBoxColumn.Visible = false;
            // 
            // chieuCaoDataGridViewTextBoxColumn
            // 
            chieuCaoDataGridViewTextBoxColumn.DataPropertyName = "ChieuCao";
            chieuCaoDataGridViewTextBoxColumn.HeaderText = "ChieuCao";
            chieuCaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            chieuCaoDataGridViewTextBoxColumn.Name = "chieuCaoDataGridViewTextBoxColumn";
            chieuCaoDataGridViewTextBoxColumn.ReadOnly = true;
            chieuCaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // benhNhanBindingSource
            // 
            benhNhanBindingSource.DataSource = typeof(DTO.BenhNhan);
            // 
            // BillCheckup
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1182, 903);
            Controls.Add(guna2Panel1);
            Name = "BillCheckup";
            Text = "BillCheckup";
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_patientbills).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonBenhNhanBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_patient).EndInit();
            ((System.ComponentModel.ISupportInitialize)benhNhanBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_patient;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_patientbills;
        private System.Windows.Forms.BindingSource benhNhanBindingSource;
        private System.Windows.Forms.BindingSource hoaDonBenhNhanBindingSource;
        private Guna.UI2.WinForms.Guna2TextBox tb_searchpatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomMauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn canNangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chieuCaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhoadonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayxuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtoanDataGridViewTextBoxColumn;
    }
}