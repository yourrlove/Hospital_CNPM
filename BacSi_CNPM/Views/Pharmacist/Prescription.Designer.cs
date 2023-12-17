namespace Hospital.Views.Pharmacist
{
    partial class Prescription
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescription));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1_searchPatients = new Guna.UI2.WinForms.Guna2Panel();
            dtgv_searchPatients = new Guna.UI2.WinForms.Guna2DataGridView();
            bNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            benhNhanBindingSource1 = new System.Windows.Forms.BindingSource(components);
            search_patient = new Guna.UI2.WinForms.Guna2TextBox();
            benhNhanBindingSource = new System.Windows.Forms.BindingSource(components);
            containerPrescription = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1_searchPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_searchPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)benhNhanBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)benhNhanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1_searchPatients
            // 
            guna2Panel1_searchPatients.Controls.Add(dtgv_searchPatients);
            guna2Panel1_searchPatients.Controls.Add(search_patient);
            guna2Panel1_searchPatients.CustomizableEdges = customizableEdges3;
            guna2Panel1_searchPatients.Dock = System.Windows.Forms.DockStyle.Left;
            guna2Panel1_searchPatients.Location = new System.Drawing.Point(0, 0);
            guna2Panel1_searchPatients.Name = "guna2Panel1_searchPatients";
            guna2Panel1_searchPatients.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1_searchPatients.Size = new System.Drawing.Size(538, 793);
            guna2Panel1_searchPatients.TabIndex = 0;
            // 
            // dtgv_searchPatients
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dtgv_searchPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_searchPatients.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtgv_searchPatients.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_searchPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_searchPatients.ColumnHeadersHeight = 22;
            dtgv_searchPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_searchPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { bNIDDataGridViewTextBoxColumn, hoTenDataGridViewTextBoxColumn, gioiTinhDataGridViewTextBoxColumn, ngaySinhDataGridViewTextBoxColumn, diaChiDataGridViewTextBoxColumn, soDienThoaiDataGridViewTextBoxColumn });
            dtgv_searchPatients.DataSource = benhNhanBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_searchPatients.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_searchPatients.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_searchPatients.Location = new System.Drawing.Point(10, 102);
            dtgv_searchPatients.Name = "dtgv_searchPatients";
            dtgv_searchPatients.RowHeadersVisible = false;
            dtgv_searchPatients.RowHeadersWidth = 51;
            dtgv_searchPatients.RowTemplate.Height = 29;
            dtgv_searchPatients.Size = new System.Drawing.Size(522, 543);
            dtgv_searchPatients.TabIndex = 4;
            dtgv_searchPatients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_searchPatients.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_searchPatients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_searchPatients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_searchPatients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_searchPatients.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_searchPatients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_searchPatients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_searchPatients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_searchPatients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_searchPatients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_searchPatients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_searchPatients.ThemeStyle.HeaderStyle.Height = 22;
            dtgv_searchPatients.ThemeStyle.ReadOnly = false;
            dtgv_searchPatients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_searchPatients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_searchPatients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_searchPatients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_searchPatients.ThemeStyle.RowsStyle.Height = 29;
            dtgv_searchPatients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_searchPatients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_searchPatients.CellClick += dtgv_searchPatients_CellClick;
            dtgv_searchPatients.CellContentClick += dtgv_searchPatients_CellContentClick;
            dtgv_searchPatients.CellDoubleClick += dtgv_searchPatients_CellDoubleClick;
            // 
            // bNIDDataGridViewTextBoxColumn
            // 
            bNIDDataGridViewTextBoxColumn.DataPropertyName = "BN_ID";
            bNIDDataGridViewTextBoxColumn.HeaderText = "BN_ID";
            bNIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            bNIDDataGridViewTextBoxColumn.Name = "bNIDDataGridViewTextBoxColumn";
            bNIDDataGridViewTextBoxColumn.ReadOnly = true;
            bNIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            bNIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            hoTenDataGridViewTextBoxColumn.MinimumWidth = 8;
            hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            hoTenDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            gioiTinhDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            ngaySinhDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            diaChiDataGridViewTextBoxColumn.MinimumWidth = 8;
            diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            diaChiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            diaChiDataGridViewTextBoxColumn.Visible = false;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            soDienThoaiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // benhNhanBindingSource1
            // 
            benhNhanBindingSource1.DataSource = typeof(DTO.BenhNhan);
            // 
            // search_patient
            // 
            search_patient.CustomizableEdges = customizableEdges1;
            search_patient.DefaultText = "";
            search_patient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            search_patient.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            search_patient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            search_patient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            search_patient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            search_patient.Font = new System.Drawing.Font("Segoe UI", 9F);
            search_patient.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            search_patient.IconLeft = (System.Drawing.Image)resources.GetObject("search_patient.IconLeft");
            search_patient.IconLeftSize = new System.Drawing.Size(32, 32);
            search_patient.Location = new System.Drawing.Point(54, 38);
            search_patient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            search_patient.Name = "search_patient";
            search_patient.PasswordChar = '\0';
            search_patient.PlaceholderText = "Search patient";
            search_patient.SelectedText = "";
            search_patient.ShadowDecoration.CustomizableEdges = customizableEdges2;
            search_patient.Size = new System.Drawing.Size(286, 41);
            search_patient.TabIndex = 3;
            search_patient.TextChanged += search_patient_TextChanged;
            // 
            // benhNhanBindingSource
            // 
            benhNhanBindingSource.DataSource = typeof(DTO.BenhNhan);
            // 
            // containerPrescription
            // 
            containerPrescription.CustomizableEdges = customizableEdges5;
            containerPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            containerPrescription.Location = new System.Drawing.Point(538, 0);
            containerPrescription.Name = "containerPrescription";
            containerPrescription.ShadowDecoration.CustomizableEdges = customizableEdges6;
            containerPrescription.Size = new System.Drawing.Size(578, 793);
            containerPrescription.TabIndex = 1;
            // 
            // Prescription
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1116, 793);
            Controls.Add(containerPrescription);
            Controls.Add(guna2Panel1_searchPatients);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Prescription";
            Text = "Prescription";
            guna2Panel1_searchPatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_searchPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)benhNhanBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)benhNhanBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1_searchPatients;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_searchPatients;
        private Guna.UI2.WinForms.Guna2TextBox search_patient;
        private Guna.UI2.WinForms.Guna2Panel containerPrescription;
        private System.Windows.Forms.BindingSource benhNhanBindingSource;
        private System.Windows.Forms.BindingSource benhNhanBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
    }
}