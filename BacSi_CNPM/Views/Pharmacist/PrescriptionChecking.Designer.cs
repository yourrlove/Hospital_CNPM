namespace Hospital.Views.Pharmacist
{
    partial class PrescriptionChecking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionChecking));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Prescription_Checking = new Guna.UI2.WinForms.Guna2Panel();
            btn_reciept = new Guna.UI2.WinForms.Guna2Button();
            dtgv_Updated = new Guna.UI2.WinForms.Guna2DataGridView();
            chiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(components);
            dtgv_notRecieved = new Guna.UI2.WinForms.Guna2DataGridView();
            listHTchoBindingSource = new System.Windows.Forms.BindingSource(components);
            listHTchoBindingSource1 = new System.Windows.Forms.BindingSource(components);
            hoaDonTonKhoBindingSource = new System.Windows.Forms.BindingSource(components);
            tonKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            thnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dongiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PaitentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Prescription_Checking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_Updated).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chiTietHoaDonBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_notRecieved).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listHTchoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listHTchoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonTonKhoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Prescription_Checking
            // 
            Prescription_Checking.Controls.Add(btn_reciept);
            Prescription_Checking.Controls.Add(dtgv_Updated);
            Prescription_Checking.Controls.Add(dtgv_notRecieved);
            Prescription_Checking.CustomizableEdges = customizableEdges3;
            Prescription_Checking.Dock = System.Windows.Forms.DockStyle.Fill;
            Prescription_Checking.Location = new System.Drawing.Point(0, 0);
            Prescription_Checking.Name = "Prescription_Checking";
            Prescription_Checking.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Prescription_Checking.Size = new System.Drawing.Size(1134, 872);
            Prescription_Checking.TabIndex = 1;
            // 
            // btn_reciept
            // 
            btn_reciept.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_reciept.BackColor = System.Drawing.Color.Transparent;
            btn_reciept.BorderColor = System.Drawing.Color.Transparent;
            btn_reciept.BorderThickness = 1;
            btn_reciept.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_reciept.CustomizableEdges = customizableEdges1;
            btn_reciept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btn_reciept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btn_reciept.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            btn_reciept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            btn_reciept.FillColor = System.Drawing.Color.Transparent;
            btn_reciept.Font = new System.Drawing.Font("Segoe UI", 9F);
            btn_reciept.ForeColor = System.Drawing.Color.Transparent;
            btn_reciept.HoverState.FillColor = System.Drawing.Color.Transparent;
            btn_reciept.HoverState.ForeColor = System.Drawing.Color.Transparent;
            btn_reciept.Image = (System.Drawing.Image)resources.GetObject("btn_reciept.Image");
            btn_reciept.ImageSize = new System.Drawing.Size(60, 60);
            btn_reciept.Location = new System.Drawing.Point(567, 235);
            btn_reciept.Name = "btn_reciept";
            btn_reciept.PressedColor = System.Drawing.Color.Transparent;
            btn_reciept.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_reciept.Size = new System.Drawing.Size(71, 58);
            btn_reciept.TabIndex = 4;
            btn_reciept.Click += btn_reciept_Click;
            // 
            // dtgv_Updated
            // 
            dtgv_Updated.AllowUserToAddRows = false;
            dtgv_Updated.AllowUserToDeleteRows = false;
            dtgv_Updated.AllowUserToResizeColumns = false;
            dtgv_Updated.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dtgv_Updated.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_Updated.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            dtgv_Updated.AutoGenerateColumns = false;
            dtgv_Updated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_Updated.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_Updated.ColumnHeadersHeight = 50;
            dtgv_Updated.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { tonKhoDataGridViewTextBoxColumn, thnameDataGridViewTextBoxColumn, soluongDataGridViewTextBoxColumn, dongiaDataGridViewTextBoxColumn });
            dtgv_Updated.DataSource = hoaDonTonKhoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_Updated.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_Updated.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_Updated.Location = new System.Drawing.Point(658, 56);
            dtgv_Updated.Name = "dtgv_Updated";
            dtgv_Updated.ReadOnly = true;
            dtgv_Updated.RowHeadersVisible = false;
            dtgv_Updated.RowHeadersWidth = 51;
            dtgv_Updated.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgv_Updated.RowTemplate.Height = 50;
            dtgv_Updated.RowTemplate.ReadOnly = true;
            dtgv_Updated.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_Updated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dtgv_Updated.Size = new System.Drawing.Size(436, 531);
            dtgv_Updated.TabIndex = 2;
            dtgv_Updated.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_Updated.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_Updated.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_Updated.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_Updated.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_Updated.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_Updated.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_Updated.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_Updated.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_Updated.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtgv_Updated.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_Updated.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_Updated.ThemeStyle.HeaderStyle.Height = 50;
            dtgv_Updated.ThemeStyle.ReadOnly = true;
            dtgv_Updated.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_Updated.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_Updated.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtgv_Updated.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_Updated.ThemeStyle.RowsStyle.Height = 50;
            dtgv_Updated.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_Updated.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            // 
            // chiTietHoaDonBindingSource
            // 
            chiTietHoaDonBindingSource.DataSource = typeof(DTO.ChiTietHoaDon);
            // 
            // dtgv_notRecieved
            // 
            dtgv_notRecieved.AllowUserToAddRows = false;
            dtgv_notRecieved.AllowUserToDeleteRows = false;
            dtgv_notRecieved.AllowUserToResizeColumns = false;
            dtgv_notRecieved.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dtgv_notRecieved.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_notRecieved.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtgv_notRecieved.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_notRecieved.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgv_notRecieved.ColumnHeadersHeight = 50;
            dtgv_notRecieved.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { PhoneNumber, PaitentName });
            dtgv_notRecieved.DataSource = listHTchoBindingSource1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_notRecieved.DefaultCellStyle = dataGridViewCellStyle6;
            dtgv_notRecieved.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_notRecieved.Location = new System.Drawing.Point(35, 56);
            dtgv_notRecieved.Name = "dtgv_notRecieved";
            dtgv_notRecieved.ReadOnly = true;
            dtgv_notRecieved.RowHeadersVisible = false;
            dtgv_notRecieved.RowHeadersWidth = 51;
            dtgv_notRecieved.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgv_notRecieved.RowTemplate.Height = 50;
            dtgv_notRecieved.RowTemplate.ReadOnly = true;
            dtgv_notRecieved.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_notRecieved.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dtgv_notRecieved.Size = new System.Drawing.Size(503, 531);
            dtgv_notRecieved.TabIndex = 1;
            dtgv_notRecieved.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_notRecieved.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_notRecieved.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_notRecieved.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_notRecieved.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_notRecieved.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_notRecieved.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_notRecieved.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_notRecieved.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_notRecieved.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtgv_notRecieved.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_notRecieved.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_notRecieved.ThemeStyle.HeaderStyle.Height = 50;
            dtgv_notRecieved.ThemeStyle.ReadOnly = true;
            dtgv_notRecieved.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_notRecieved.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_notRecieved.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtgv_notRecieved.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_notRecieved.ThemeStyle.RowsStyle.Height = 50;
            dtgv_notRecieved.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_notRecieved.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_notRecieved.CellClick += dtgv_notRecieved_CellClick;
            // 
            // listHTchoBindingSource
            // 
            listHTchoBindingSource.DataSource = typeof(DTO.listHTcho);
            // 
            // listHTchoBindingSource1
            // 
            listHTchoBindingSource1.DataSource = typeof(DTO.listHTcho);
            // 
            // hoaDonTonKhoBindingSource
            // 
            hoaDonTonKhoBindingSource.DataSource = typeof(DTO.HoaDonTonKho);
            // 
            // tonKhoDataGridViewTextBoxColumn
            // 
            tonKhoDataGridViewTextBoxColumn.DataPropertyName = "TonKho";
            tonKhoDataGridViewTextBoxColumn.HeaderText = "Invetory";
            tonKhoDataGridViewTextBoxColumn.MinimumWidth = 6;
            tonKhoDataGridViewTextBoxColumn.Name = "tonKhoDataGridViewTextBoxColumn";
            tonKhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thnameDataGridViewTextBoxColumn
            // 
            thnameDataGridViewTextBoxColumn.DataPropertyName = "th_name";
            thnameDataGridViewTextBoxColumn.HeaderText = "Medicine";
            thnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            thnameDataGridViewTextBoxColumn.Name = "thnameDataGridViewTextBoxColumn";
            thnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            soluongDataGridViewTextBoxColumn.HeaderText = "Quantity";
            soluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            soluongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dongiaDataGridViewTextBoxColumn
            // 
            dongiaDataGridViewTextBoxColumn.DataPropertyName = "dongia";
            dongiaDataGridViewTextBoxColumn.HeaderText = "Price";
            dongiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            dongiaDataGridViewTextBoxColumn.Name = "dongiaDataGridViewTextBoxColumn";
            dongiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            PhoneNumber.DataPropertyName = "sodienthoai";
            PhoneNumber.HeaderText = "PhoneNumber";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            // 
            // PaitentName
            // 
            PaitentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            PaitentName.DataPropertyName = "tenbenhnhan";
            PaitentName.HeaderText = "PatientName";
            PaitentName.MinimumWidth = 6;
            PaitentName.Name = "PaitentName";
            PaitentName.ReadOnly = true;
            // 
            // PrescriptionChecking
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1134, 872);
            ControlBox = false;
            Controls.Add(Prescription_Checking);
            Name = "PrescriptionChecking";
            Text = "PrescriptionChecking";
            Prescription_Checking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_Updated).EndInit();
            ((System.ComponentModel.ISupportInitialize)chiTietHoaDonBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_notRecieved).EndInit();
            ((System.ComponentModel.ISupportInitialize)listHTchoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)listHTchoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonTonKhoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel Prescription_Checking;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_notRecieved;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_Updated;
        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
        private Guna.UI2.WinForms.Guna2Button btn_reciept;
        private System.Windows.Forms.BindingSource listHTchoBindingSource;
        private System.Windows.Forms.BindingSource listHTchoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hoaDonTonKhoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaitentName;
    }
}