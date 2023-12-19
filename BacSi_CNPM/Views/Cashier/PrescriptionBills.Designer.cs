namespace Hospital.Views.Cashier
{
    partial class PrescriptionBills
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionBills));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tendt = new System.Windows.Forms.Label();
            bill_name = new System.Windows.Forms.Label();
            dtgv_bill = new Guna.UI2.WinForms.Guna2DataGridView();
            dTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tHIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenThuocDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lieuDungDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            soLuongDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            donthuocLoadedBindingSource = new System.Windows.Forms.BindingSource(components);
            currentBindingSource = new System.Windows.Forms.BindingSource(components);
            save = new User_Controls.UC_Button();
            dtgv_Presciption = new Guna.UI2.WinForms.Guna2DataGridView();
            dTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lieuDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tonKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            donthuocHTBindingSource = new System.Windows.Forms.BindingSource(components);
            TongTien_text = new System.Windows.Forms.Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label_TongTien = new System.Windows.Forms.Label();
            print_btn = new User_Controls.UC_Button();
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            lb_thanhtoan = new System.Windows.Forms.Label();
            btn_cash = new Guna.UI2.WinForms.Guna2Button();
            btn_baking = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            lb_prescriptionName = new System.Windows.Forms.Label();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            ((System.ComponentModel.ISupportInitialize)dtgv_bill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)donthuocLoadedBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_Presciption).BeginInit();
            ((System.ComponentModel.ISupportInitialize)donthuocHTBindingSource).BeginInit();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tendt
            // 
            tendt.AutoSize = true;
            tendt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            tendt.Location = new System.Drawing.Point(174, 57);
            tendt.Name = "tendt";
            tendt.Size = new System.Drawing.Size(0, 28);
            tendt.TabIndex = 0;
            // 
            // bill_name
            // 
            bill_name.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            bill_name.AutoSize = true;
            bill_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            bill_name.Location = new System.Drawing.Point(511, 57);
            bill_name.Name = "bill_name";
            bill_name.Size = new System.Drawing.Size(52, 28);
            bill_name.TabIndex = 3;
            bill_name.Text = "Bills";
            // 
            // dtgv_bill
            // 
            dtgv_bill.AllowUserToAddRows = false;
            dtgv_bill.AllowUserToDeleteRows = false;
            dtgv_bill.AllowUserToResizeColumns = false;
            dtgv_bill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dtgv_bill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_bill.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            dtgv_bill.AutoGenerateColumns = false;
            dtgv_bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_bill.ColumnHeadersHeight = 50;
            dtgv_bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dTIDDataGridViewTextBoxColumn1, tHIDDataGridViewTextBoxColumn1, tenThuocDataGridViewTextBoxColumn1, lieuDungDataGridViewTextBoxColumn1, soLuongDataGridViewTextBoxColumn1, donGiaDataGridViewTextBoxColumn });
            dtgv_bill.DataSource = donthuocLoadedBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_bill.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_bill.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_bill.Location = new System.Drawing.Point(416, 108);
            dtgv_bill.Name = "dtgv_bill";
            dtgv_bill.RowHeadersVisible = false;
            dtgv_bill.RowHeadersWidth = 51;
            dtgv_bill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgv_bill.RowTemplate.Height = 40;
            dtgv_bill.RowTemplate.ReadOnly = true;
            dtgv_bill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_bill.Size = new System.Drawing.Size(370, 402);
            dtgv_bill.TabIndex = 4;
            dtgv_bill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_bill.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_bill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_bill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_bill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_bill.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_bill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_bill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_bill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_bill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_bill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_bill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_bill.ThemeStyle.HeaderStyle.Height = 50;
            dtgv_bill.ThemeStyle.ReadOnly = false;
            dtgv_bill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_bill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_bill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_bill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_bill.ThemeStyle.RowsStyle.Height = 40;
            dtgv_bill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_bill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_bill.CellContentClick += dtgv_bill_CellContentClick;
            // 
            // dTIDDataGridViewTextBoxColumn1
            // 
            dTIDDataGridViewTextBoxColumn1.DataPropertyName = "DT_ID";
            dTIDDataGridViewTextBoxColumn1.HeaderText = "DT_ID";
            dTIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dTIDDataGridViewTextBoxColumn1.Name = "dTIDDataGridViewTextBoxColumn1";
            dTIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tHIDDataGridViewTextBoxColumn1
            // 
            tHIDDataGridViewTextBoxColumn1.DataPropertyName = "TH_ID";
            tHIDDataGridViewTextBoxColumn1.HeaderText = "TH_ID";
            tHIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            tHIDDataGridViewTextBoxColumn1.Name = "tHIDDataGridViewTextBoxColumn1";
            tHIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tenThuocDataGridViewTextBoxColumn1
            // 
            tenThuocDataGridViewTextBoxColumn1.DataPropertyName = "TenThuoc";
            tenThuocDataGridViewTextBoxColumn1.HeaderText = "Medicine";
            tenThuocDataGridViewTextBoxColumn1.MinimumWidth = 6;
            tenThuocDataGridViewTextBoxColumn1.Name = "tenThuocDataGridViewTextBoxColumn1";
            // 
            // lieuDungDataGridViewTextBoxColumn1
            // 
            lieuDungDataGridViewTextBoxColumn1.DataPropertyName = "LieuDung";
            lieuDungDataGridViewTextBoxColumn1.HeaderText = "Dosage";
            lieuDungDataGridViewTextBoxColumn1.MinimumWidth = 6;
            lieuDungDataGridViewTextBoxColumn1.Name = "lieuDungDataGridViewTextBoxColumn1";
            // 
            // soLuongDataGridViewTextBoxColumn1
            // 
            soLuongDataGridViewTextBoxColumn1.DataPropertyName = "SoLuong";
            soLuongDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            soLuongDataGridViewTextBoxColumn1.MinimumWidth = 6;
            soLuongDataGridViewTextBoxColumn1.Name = "soLuongDataGridViewTextBoxColumn1";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            donGiaDataGridViewTextBoxColumn.HeaderText = "Price";
            donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // donthuocLoadedBindingSource
            // 
            donthuocLoadedBindingSource.DataSource = typeof(DTO.donthuocLoaded);
            // 
            // currentBindingSource
            // 
            currentBindingSource.DataSource = typeof(DTO.Current);
            // 
            // save
            // 
            save.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            save.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            save.BackgroundColor = System.Drawing.Color.FromArgb(242, 245, 250);
            save.BorderColor = System.Drawing.Color.FromArgb(0, 0, 192);
            save.BorderRadius = 0;
            save.BorderSize = 1;
            save.Cursor = System.Windows.Forms.Cursors.Hand;
            save.FlatAppearance.BorderSize = 0;
            save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            save.Font = new System.Drawing.Font("Segoe UI", 9F);
            save.FontSize = 9;
            save.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            save.Location = new System.Drawing.Point(754, 606);
            save.Name = "save";
            save.Size = new System.Drawing.Size(131, 51);
            save.TabIndex = 5;
            save.Text = "Save";
            save.TextColor = System.Drawing.Color.FromArgb(0, 0, 192);
            save.UseVisualStyleBackColor = false;
            save.Click += print_btn_Click;
            // 
            // dtgv_Presciption
            // 
            dtgv_Presciption.AllowUserToAddRows = false;
            dtgv_Presciption.AllowUserToDeleteRows = false;
            dtgv_Presciption.AllowUserToResizeColumns = false;
            dtgv_Presciption.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dtgv_Presciption.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_Presciption.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtgv_Presciption.AutoGenerateColumns = false;
            dtgv_Presciption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_Presciption.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgv_Presciption.ColumnHeadersHeight = 50;
            dtgv_Presciption.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dTIDDataGridViewTextBoxColumn, tHIDDataGridViewTextBoxColumn, tenThuocDataGridViewTextBoxColumn, lieuDungDataGridViewTextBoxColumn, soLuongDataGridViewTextBoxColumn, tonKhoDataGridViewTextBoxColumn });
            dtgv_Presciption.DataSource = donthuocHTBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_Presciption.DefaultCellStyle = dataGridViewCellStyle6;
            dtgv_Presciption.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_Presciption.Location = new System.Drawing.Point(11, 108);
            dtgv_Presciption.Margin = new System.Windows.Forms.Padding(2);
            dtgv_Presciption.Name = "dtgv_Presciption";
            dtgv_Presciption.ReadOnly = true;
            dtgv_Presciption.RowHeadersVisible = false;
            dtgv_Presciption.RowHeadersWidth = 50;
            dtgv_Presciption.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgv_Presciption.RowTemplate.Height = 40;
            dtgv_Presciption.RowTemplate.ReadOnly = true;
            dtgv_Presciption.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_Presciption.Size = new System.Drawing.Size(400, 402);
            dtgv_Presciption.TabIndex = 8;
            dtgv_Presciption.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_Presciption.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_Presciption.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_Presciption.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_Presciption.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_Presciption.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_Presciption.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_Presciption.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_Presciption.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_Presciption.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_Presciption.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_Presciption.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_Presciption.ThemeStyle.HeaderStyle.Height = 50;
            dtgv_Presciption.ThemeStyle.ReadOnly = true;
            dtgv_Presciption.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_Presciption.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_Presciption.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_Presciption.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_Presciption.ThemeStyle.RowsStyle.Height = 40;
            dtgv_Presciption.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_Presciption.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_Presciption.CellContentClick += dtgv_Presciption_CellContentClick;
            // 
            // dTIDDataGridViewTextBoxColumn
            // 
            dTIDDataGridViewTextBoxColumn.DataPropertyName = "DT_ID";
            dTIDDataGridViewTextBoxColumn.HeaderText = "DT_ID";
            dTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            dTIDDataGridViewTextBoxColumn.Name = "dTIDDataGridViewTextBoxColumn";
            dTIDDataGridViewTextBoxColumn.ReadOnly = true;
            dTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tHIDDataGridViewTextBoxColumn
            // 
            tHIDDataGridViewTextBoxColumn.DataPropertyName = "TH_ID";
            tHIDDataGridViewTextBoxColumn.HeaderText = "TH_ID";
            tHIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            tHIDDataGridViewTextBoxColumn.Name = "tHIDDataGridViewTextBoxColumn";
            tHIDDataGridViewTextBoxColumn.ReadOnly = true;
            tHIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenThuocDataGridViewTextBoxColumn
            // 
            tenThuocDataGridViewTextBoxColumn.DataPropertyName = "TenThuoc";
            tenThuocDataGridViewTextBoxColumn.HeaderText = "Medicine";
            tenThuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenThuocDataGridViewTextBoxColumn.Name = "tenThuocDataGridViewTextBoxColumn";
            tenThuocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lieuDungDataGridViewTextBoxColumn
            // 
            lieuDungDataGridViewTextBoxColumn.DataPropertyName = "LieuDung";
            lieuDungDataGridViewTextBoxColumn.HeaderText = "Dosage";
            lieuDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            lieuDungDataGridViewTextBoxColumn.Name = "lieuDungDataGridViewTextBoxColumn";
            lieuDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            soLuongDataGridViewTextBoxColumn.HeaderText = "Quantity";
            soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tonKhoDataGridViewTextBoxColumn
            // 
            tonKhoDataGridViewTextBoxColumn.DataPropertyName = "TonKho";
            tonKhoDataGridViewTextBoxColumn.HeaderText = "Inventory";
            tonKhoDataGridViewTextBoxColumn.MinimumWidth = 6;
            tonKhoDataGridViewTextBoxColumn.Name = "tonKhoDataGridViewTextBoxColumn";
            tonKhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donthuocHTBindingSource
            // 
            donthuocHTBindingSource.DataSource = typeof(DTO.donthuocHT);
            // 
            // TongTien_text
            // 
            TongTien_text.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            TongTien_text.BackColor = System.Drawing.Color.WhiteSmoke;
            TongTien_text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TongTien_text.Location = new System.Drawing.Point(811, 538);
            TongTien_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            TongTien_text.Name = "TongTien_text";
            TongTien_text.Size = new System.Drawing.Size(227, 40);
            TongTien_text.TabIndex = 9;
            TongTien_text.Text = "Tong Tien";
            TongTien_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            TongTien_text.Click += TongTien_text_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            guna2Button1.ForeColor = System.Drawing.Color.White;
            guna2Button1.Location = new System.Drawing.Point(11, 514);
            guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new System.Drawing.Size(1028, 10);
            guna2Button1.TabIndex = 10;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // label_TongTien
            // 
            label_TongTien.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label_TongTien.BackColor = System.Drawing.Color.FromArgb(94, 148, 255);
            label_TongTien.ForeColor = System.Drawing.Color.White;
            label_TongTien.Location = new System.Drawing.Point(703, 539);
            label_TongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label_TongTien.Name = "label_TongTien";
            label_TongTien.Size = new System.Drawing.Size(93, 40);
            label_TongTien.TabIndex = 11;
            label_TongTien.Text = "Total: ";
            label_TongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // print_btn
            // 
            print_btn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            print_btn.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            print_btn.BackgroundColor = System.Drawing.Color.FromArgb(242, 245, 250);
            print_btn.BorderColor = System.Drawing.Color.FromArgb(0, 0, 192);
            print_btn.BorderRadius = 0;
            print_btn.BorderSize = 1;
            print_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            print_btn.FlatAppearance.BorderSize = 0;
            print_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            print_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            print_btn.FontSize = 9;
            print_btn.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            print_btn.Location = new System.Drawing.Point(910, 606);
            print_btn.Margin = new System.Windows.Forms.Padding(2);
            print_btn.Name = "print_btn";
            print_btn.Size = new System.Drawing.Size(128, 52);
            print_btn.TabIndex = 12;
            print_btn.Text = "Print";
            print_btn.TextColor = System.Drawing.Color.FromArgb(0, 0, 192);
            print_btn.UseVisualStyleBackColor = false;
            print_btn.Click += uC_Button1_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // lb_thanhtoan
            // 
            lb_thanhtoan.BackColor = System.Drawing.Color.Transparent;
            lb_thanhtoan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
            lb_thanhtoan.Location = new System.Drawing.Point(0, 10);
            lb_thanhtoan.Name = "lb_thanhtoan";
            lb_thanhtoan.Size = new System.Drawing.Size(246, 54);
            lb_thanhtoan.TabIndex = 13;
            lb_thanhtoan.Text = "Payment Method";
            lb_thanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_thanhtoan.Click += lb_thanhtoan_Click;
            // 
            // btn_cash
            // 
            btn_cash.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_cash.CustomizableEdges = customizableEdges3;
            btn_cash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btn_cash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btn_cash.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            btn_cash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            btn_cash.Font = new System.Drawing.Font("Segoe UI", 9F);
            btn_cash.ForeColor = System.Drawing.Color.White;
            btn_cash.HoverState.FillColor = System.Drawing.Color.Blue;
            btn_cash.HoverState.ForeColor = System.Drawing.Color.White;
            btn_cash.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            btn_cash.ImageSize = new System.Drawing.Size(32, 32);
            btn_cash.Location = new System.Drawing.Point(20, 124);
            btn_cash.Name = "btn_cash";
            btn_cash.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_cash.Size = new System.Drawing.Size(210, 47);
            btn_cash.TabIndex = 14;
            btn_cash.Text = "Cash";
            btn_cash.Click += btn_cash_Click;
            // 
            // btn_baking
            // 
            btn_baking.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_baking.CustomizableEdges = customizableEdges5;
            btn_baking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btn_baking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btn_baking.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            btn_baking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            btn_baking.Font = new System.Drawing.Font("Segoe UI", 9F);
            btn_baking.ForeColor = System.Drawing.Color.White;
            btn_baking.HoverState.FillColor = System.Drawing.Color.Blue;
            btn_baking.Location = new System.Drawing.Point(20, 236);
            btn_baking.Name = "btn_baking";
            btn_baking.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_baking.Size = new System.Drawing.Size(210, 47);
            btn_baking.TabIndex = 15;
            btn_baking.Text = "Internet banking";
            btn_baking.Click += btn_baking_Click;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            guna2ShadowPanel1.Controls.Add(lb_thanhtoan);
            guna2ShadowPanel1.Controls.Add(btn_baking);
            guna2ShadowPanel1.Controls.Add(btn_cash);
            guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            guna2ShadowPanel1.Location = new System.Drawing.Point(792, 108);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            guna2ShadowPanel1.Size = new System.Drawing.Size(246, 402);
            guna2ShadowPanel1.TabIndex = 16;
            // 
            // printPreviewDialog2
            // 
            printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            printPreviewDialog2.Enabled = true;
            printPreviewDialog2.Icon = (System.Drawing.Icon)resources.GetObject("printPreviewDialog2.Icon");
            printPreviewDialog2.Name = "printPreviewDialog2";
            printPreviewDialog2.Visible = false;
            // 
            // printDocument2
            // 
            printDocument2.PrintPage += printDocument2_PrintPage;
            // 
            // lb_prescriptionName
            // 
            lb_prescriptionName.AutoSize = true;
            lb_prescriptionName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lb_prescriptionName.Location = new System.Drawing.Point(112, 57);
            lb_prescriptionName.Name = "lb_prescriptionName";
            lb_prescriptionName.Size = new System.Drawing.Size(184, 28);
            lb_prescriptionName.TabIndex = 17;
            lb_prescriptionName.Text = "Prescription name";
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // PrescriptionBills
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1060, 669);
            Controls.Add(lb_prescriptionName);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(print_btn);
            Controls.Add(label_TongTien);
            Controls.Add(guna2Button1);
            Controls.Add(TongTien_text);
            Controls.Add(dtgv_Presciption);
            Controls.Add(save);
            Controls.Add(dtgv_bill);
            Controls.Add(bill_name);
            Controls.Add(tendt);
            Name = "PrescriptionBills";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PrescriptionBill";
            Load += PrescriptionBills_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_bill).EndInit();
            ((System.ComponentModel.ISupportInitialize)donthuocLoadedBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_Presciption).EndInit();
            ((System.ComponentModel.ISupportInitialize)donthuocHTBindingSource).EndInit();
            guna2ShadowPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label tendt;
        private System.Windows.Forms.Label bill_name;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_bill;
        private User_Controls.UC_Button save;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_Presciption;
        private System.Windows.Forms.Label TongTien_text;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label_TongTien;
        private System.Windows.Forms.BindingSource currentBindingSource;
        private User_Controls.UC_Button print_btn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lb_thanhtoan;
        private Guna.UI2.WinForms.Guna2Button btn_cash;
        private Guna.UI2.WinForms.Guna2Button btn_baking;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.Label lb_prescriptionName;
        private System.Windows.Forms.BindingSource donthuocHTBindingSource;
        private System.Windows.Forms.BindingSource donthuocLoadedBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuocDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieuDungDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieuDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonKhoDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}