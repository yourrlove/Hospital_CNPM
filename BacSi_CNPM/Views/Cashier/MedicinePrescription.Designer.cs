namespace Hospital.Views.Cashier
{
    partial class MedicinePrescription
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            dtgv_medicinePrescription = new Guna.UI2.WinForms.Guna2DataGridView();
            dTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ngayKeDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenDonThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            donThuocBindingSource1 = new System.Windows.Forms.BindingSource(components);
            donThuocBindingSource = new System.Windows.Forms.BindingSource(components);
            label1 = new System.Windows.Forms.Label();
            sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            lb_pre_bill = new System.Windows.Forms.Label();
            dtgv_patientBill = new Guna.UI2.WinForms.Guna2DataGridView();
            bNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            giakhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            donKhamBenhBindingSource = new System.Windows.Forms.BindingSource(components);
            hoaDonBenhNhanBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dtgv_medicinePrescription).BeginInit();
            ((System.ComponentModel.ISupportInitialize)donThuocBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)donThuocBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_patientBill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)donKhamBenhBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonBenhNhanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtgv_medicinePrescription
            // 
            dtgv_medicinePrescription.AllowUserToAddRows = false;
            dtgv_medicinePrescription.AllowUserToDeleteRows = false;
            dtgv_medicinePrescription.AllowUserToResizeColumns = false;
            dtgv_medicinePrescription.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dtgv_medicinePrescription.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_medicinePrescription.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_medicinePrescription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_medicinePrescription.ColumnHeadersHeight = 50;
            dtgv_medicinePrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dTIDDataGridViewTextBoxColumn, ngayKeDonDataGridViewTextBoxColumn, bSIDDataGridViewTextBoxColumn, tenDonThuocDataGridViewTextBoxColumn });
            dtgv_medicinePrescription.DataSource = donThuocBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_medicinePrescription.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_medicinePrescription.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_medicinePrescription.Location = new System.Drawing.Point(28, 72);
            dtgv_medicinePrescription.Name = "dtgv_medicinePrescription";
            dtgv_medicinePrescription.ReadOnly = true;
            dtgv_medicinePrescription.RowHeadersVisible = false;
            dtgv_medicinePrescription.RowHeadersWidth = 51;
            dtgv_medicinePrescription.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgv_medicinePrescription.RowTemplate.Height = 50;
            dtgv_medicinePrescription.Size = new System.Drawing.Size(417, 293);
            dtgv_medicinePrescription.TabIndex = 0;
            dtgv_medicinePrescription.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_medicinePrescription.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_medicinePrescription.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_medicinePrescription.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_medicinePrescription.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_medicinePrescription.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_medicinePrescription.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_medicinePrescription.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_medicinePrescription.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_medicinePrescription.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dtgv_medicinePrescription.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_medicinePrescription.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_medicinePrescription.ThemeStyle.HeaderStyle.Height = 50;
            dtgv_medicinePrescription.ThemeStyle.ReadOnly = true;
            dtgv_medicinePrescription.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_medicinePrescription.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_medicinePrescription.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtgv_medicinePrescription.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_medicinePrescription.ThemeStyle.RowsStyle.Height = 50;
            dtgv_medicinePrescription.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_medicinePrescription.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_medicinePrescription.CellClick += dtgv_medicinePrescription_CellClick;
            dtgv_medicinePrescription.CellContentClick += dtgv_medicinePrescription_CellContentClick;
            // 
            // dTIDDataGridViewTextBoxColumn
            // 
            dTIDDataGridViewTextBoxColumn.DataPropertyName = "DT_ID";
            dTIDDataGridViewTextBoxColumn.HeaderText = "DT_ID";
            dTIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            dTIDDataGridViewTextBoxColumn.Name = "dTIDDataGridViewTextBoxColumn";
            dTIDDataGridViewTextBoxColumn.ReadOnly = true;
            dTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ngayKeDonDataGridViewTextBoxColumn
            // 
            ngayKeDonDataGridViewTextBoxColumn.DataPropertyName = "NgayKeDon";
            ngayKeDonDataGridViewTextBoxColumn.HeaderText = "Prescription Date";
            ngayKeDonDataGridViewTextBoxColumn.MinimumWidth = 8;
            ngayKeDonDataGridViewTextBoxColumn.Name = "ngayKeDonDataGridViewTextBoxColumn";
            ngayKeDonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bSIDDataGridViewTextBoxColumn
            // 
            bSIDDataGridViewTextBoxColumn.DataPropertyName = "BS_ID";
            bSIDDataGridViewTextBoxColumn.HeaderText = "BS_ID";
            bSIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            bSIDDataGridViewTextBoxColumn.Name = "bSIDDataGridViewTextBoxColumn";
            bSIDDataGridViewTextBoxColumn.ReadOnly = true;
            bSIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenDonThuocDataGridViewTextBoxColumn
            // 
            tenDonThuocDataGridViewTextBoxColumn.DataPropertyName = "TenDonThuoc";
            tenDonThuocDataGridViewTextBoxColumn.HeaderText = "Prescription Name";
            tenDonThuocDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenDonThuocDataGridViewTextBoxColumn.Name = "tenDonThuocDataGridViewTextBoxColumn";
            tenDonThuocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donThuocBindingSource1
            // 
            donThuocBindingSource1.DataSource = typeof(DTO.DonThuoc);
            // 
            // donThuocBindingSource
            // 
            donThuocBindingSource.DataSource = typeof(DTO.DonThuoc);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(28, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(154, 31);
            label1.TabIndex = 1;
            label1.Text = "Prescriptions";
            // 
            // sqlConnection1
            // 
            sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // lb_pre_bill
            // 
            lb_pre_bill.AutoSize = true;
            lb_pre_bill.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
            lb_pre_bill.Location = new System.Drawing.Point(28, 410);
            lb_pre_bill.Name = "lb_pre_bill";
            lb_pre_bill.Size = new System.Drawing.Size(184, 31);
            lb_pre_bill.TabIndex = 2;
            lb_pre_bill.Text = "Medical records";
            // 
            // dtgv_patientBill
            // 
            dtgv_patientBill.AllowUserToAddRows = false;
            dtgv_patientBill.AllowUserToDeleteRows = false;
            dtgv_patientBill.AllowUserToResizeColumns = false;
            dtgv_patientBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dtgv_patientBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_patientBill.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_patientBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgv_patientBill.ColumnHeadersHeight = 40;
            dtgv_patientBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { bNIDDataGridViewTextBoxColumn, tenKhoaDataGridViewTextBoxColumn, tenPhongDataGridViewTextBoxColumn, giakhamDataGridViewTextBoxColumn, pHIDDataGridViewTextBoxColumn });
            dtgv_patientBill.DataSource = donKhamBenhBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_patientBill.DefaultCellStyle = dataGridViewCellStyle6;
            dtgv_patientBill.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_patientBill.Location = new System.Drawing.Point(28, 462);
            dtgv_patientBill.Name = "dtgv_patientBill";
            dtgv_patientBill.ReadOnly = true;
            dtgv_patientBill.RowHeadersVisible = false;
            dtgv_patientBill.RowHeadersWidth = 51;
            dtgv_patientBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgv_patientBill.RowTemplate.Height = 50;
            dtgv_patientBill.Size = new System.Drawing.Size(417, 307);
            dtgv_patientBill.TabIndex = 3;
            dtgv_patientBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_patientBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_patientBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_patientBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_patientBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_patientBill.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_patientBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_patientBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_patientBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_patientBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_patientBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_patientBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_patientBill.ThemeStyle.HeaderStyle.Height = 40;
            dtgv_patientBill.ThemeStyle.ReadOnly = true;
            dtgv_patientBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_patientBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_patientBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_patientBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_patientBill.ThemeStyle.RowsStyle.Height = 50;
            dtgv_patientBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_patientBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_patientBill.CellClick += dtgv_patientBill_CellClick;
            dtgv_patientBill.CellContentClick += dtgv_patientBill_CellContentClick;
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
            // tenKhoaDataGridViewTextBoxColumn
            // 
            tenKhoaDataGridViewTextBoxColumn.DataPropertyName = "tenKhoa";
            tenKhoaDataGridViewTextBoxColumn.HeaderText = "tenKhoa";
            tenKhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenKhoaDataGridViewTextBoxColumn.Name = "tenKhoaDataGridViewTextBoxColumn";
            tenKhoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenPhongDataGridViewTextBoxColumn
            // 
            tenPhongDataGridViewTextBoxColumn.DataPropertyName = "tenPhong";
            tenPhongDataGridViewTextBoxColumn.HeaderText = "tenPhong";
            tenPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenPhongDataGridViewTextBoxColumn.Name = "tenPhongDataGridViewTextBoxColumn";
            tenPhongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giakhamDataGridViewTextBoxColumn
            // 
            giakhamDataGridViewTextBoxColumn.DataPropertyName = "giakham";
            giakhamDataGridViewTextBoxColumn.HeaderText = "giakham";
            giakhamDataGridViewTextBoxColumn.MinimumWidth = 6;
            giakhamDataGridViewTextBoxColumn.Name = "giakhamDataGridViewTextBoxColumn";
            giakhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHIDDataGridViewTextBoxColumn
            // 
            pHIDDataGridViewTextBoxColumn.DataPropertyName = "PH_ID";
            pHIDDataGridViewTextBoxColumn.HeaderText = "PH_ID";
            pHIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            pHIDDataGridViewTextBoxColumn.Name = "pHIDDataGridViewTextBoxColumn";
            pHIDDataGridViewTextBoxColumn.ReadOnly = true;
            pHIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // donKhamBenhBindingSource
            // 
            donKhamBenhBindingSource.DataSource = typeof(DTO.DonKhamBenh);
            // 
            // hoaDonBenhNhanBindingSource
            // 
            hoaDonBenhNhanBindingSource.DataSource = typeof(DTO.HoaDonBenhNhan);
            // 
            // MedicinePrescription
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(462, 793);
            Controls.Add(dtgv_patientBill);
            Controls.Add(lb_pre_bill);
            Controls.Add(label1);
            Controls.Add(dtgv_medicinePrescription);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "MedicinePrescription";
            Text = "MedicinePrescription";
            Load += MedicinePrescription_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_medicinePrescription).EndInit();
            ((System.ComponentModel.ISupportInitialize)donThuocBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)donThuocBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_patientBill).EndInit();
            ((System.ComponentModel.ISupportInitialize)donKhamBenhBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonBenhNhanBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dtgv_medicinePrescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource donThuocBindingSource;
        private System.Windows.Forms.BindingSource donThuocBindingSource1;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label lb_pre_bill;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_patientBill;
        private System.Windows.Forms.BindingSource hoaDonBenhNhanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKeDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDonThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giakhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource donKhamBenhBindingSource;
    }
}