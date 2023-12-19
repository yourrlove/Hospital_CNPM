namespace Hospital.Views.Cashier
{
    partial class BillDetail
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
            dtgv_billdetail = new Guna.UI2.WinForms.Guna2DataGridView();
            thidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenthuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            giabanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dongiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            thuocHoaDonBindingSource = new System.Windows.Forms.BindingSource(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            lb_thanhtoan = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label_tongtien = new System.Windows.Forms.Label();
            lb_tongtien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dtgv_billdetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thuocHoaDonBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtgv_billdetail
            // 
            dtgv_billdetail.AllowUserToAddRows = false;
            dtgv_billdetail.AllowUserToDeleteRows = false;
            dtgv_billdetail.AllowUserToResizeColumns = false;
            dtgv_billdetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dtgv_billdetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_billdetail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtgv_billdetail.AutoGenerateColumns = false;
            dtgv_billdetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_billdetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_billdetail.ColumnHeadersHeight = 50;
            dtgv_billdetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { thidDataGridViewTextBoxColumn, tenthuocDataGridViewTextBoxColumn, soluongDataGridViewTextBoxColumn, giabanDataGridViewTextBoxColumn, dongiaDataGridViewTextBoxColumn });
            dtgv_billdetail.DataSource = thuocHoaDonBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_billdetail.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_billdetail.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_billdetail.Location = new System.Drawing.Point(25, 97);
            dtgv_billdetail.Name = "dtgv_billdetail";
            dtgv_billdetail.RowHeadersVisible = false;
            dtgv_billdetail.RowHeadersWidth = 51;
            dtgv_billdetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgv_billdetail.RowTemplate.Height = 40;
            dtgv_billdetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dtgv_billdetail.Size = new System.Drawing.Size(523, 398);
            dtgv_billdetail.TabIndex = 0;
            dtgv_billdetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_billdetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_billdetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_billdetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_billdetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_billdetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_billdetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_billdetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_billdetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_billdetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_billdetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_billdetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv_billdetail.ThemeStyle.HeaderStyle.Height = 50;
            dtgv_billdetail.ThemeStyle.ReadOnly = false;
            dtgv_billdetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_billdetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_billdetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_billdetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_billdetail.ThemeStyle.RowsStyle.Height = 40;
            dtgv_billdetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_billdetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_billdetail.CellContentClick += dtgv_billdetail_CellContentClick;
            // 
            // thidDataGridViewTextBoxColumn
            // 
            thidDataGridViewTextBoxColumn.DataPropertyName = "th_id";
            thidDataGridViewTextBoxColumn.HeaderText = "th_id";
            thidDataGridViewTextBoxColumn.MinimumWidth = 6;
            thidDataGridViewTextBoxColumn.Name = "thidDataGridViewTextBoxColumn";
            thidDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenthuocDataGridViewTextBoxColumn
            // 
            tenthuocDataGridViewTextBoxColumn.DataPropertyName = "tenthuoc";
            tenthuocDataGridViewTextBoxColumn.HeaderText = "Medicine";
            tenthuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenthuocDataGridViewTextBoxColumn.Name = "tenthuocDataGridViewTextBoxColumn";
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            soluongDataGridViewTextBoxColumn.HeaderText = "Quantity";
            soluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            // 
            // giabanDataGridViewTextBoxColumn
            // 
            giabanDataGridViewTextBoxColumn.DataPropertyName = "giaban";
            giabanDataGridViewTextBoxColumn.HeaderText = "Price";
            giabanDataGridViewTextBoxColumn.MinimumWidth = 6;
            giabanDataGridViewTextBoxColumn.Name = "giabanDataGridViewTextBoxColumn";
            // 
            // dongiaDataGridViewTextBoxColumn
            // 
            dongiaDataGridViewTextBoxColumn.DataPropertyName = "dongia";
            dongiaDataGridViewTextBoxColumn.HeaderText = "Total Cost";
            dongiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            dongiaDataGridViewTextBoxColumn.Name = "dongiaDataGridViewTextBoxColumn";
            // 
            // thuocHoaDonBindingSource
            // 
            thuocHoaDonBindingSource.DataSource = typeof(DTO.ThuocHoaDon);
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // lb_thanhtoan
            // 
            lb_thanhtoan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lb_thanhtoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lb_thanhtoan.Location = new System.Drawing.Point(414, 45);
            lb_thanhtoan.Name = "lb_thanhtoan";
            lb_thanhtoan.Size = new System.Drawing.Size(111, 26);
            lb_thanhtoan.TabIndex = 13;
            lb_thanhtoan.Text = "label2";
            lb_thanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.BackColor = System.Drawing.Color.FromArgb(94, 148, 255);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(208, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(169, 35);
            label1.TabIndex = 12;
            label1.Text = "Payment Method";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            guna2Button1.Location = new System.Drawing.Point(25, 505);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new System.Drawing.Size(523, 10);
            guna2Button1.TabIndex = 11;
            // 
            // label_tongtien
            // 
            label_tongtien.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label_tongtien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
            label_tongtien.Location = new System.Drawing.Point(111, 546);
            label_tongtien.Name = "label_tongtien";
            label_tongtien.Size = new System.Drawing.Size(234, 32);
            label_tongtien.TabIndex = 10;
            label_tongtien.Text = "Total Price Quotation:";
            label_tongtien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_tongtien
            // 
            lb_tongtien.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lb_tongtien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
            lb_tongtien.Location = new System.Drawing.Point(351, 546);
            lb_tongtien.Name = "lb_tongtien";
            lb_tongtien.Size = new System.Drawing.Size(197, 32);
            lb_tongtien.TabIndex = 9;
            lb_tongtien.Text = "Tongtien";
            lb_tongtien.Click += lb_tongtien_Click;
            // 
            // BillDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(574, 619);
            Controls.Add(lb_thanhtoan);
            Controls.Add(label1);
            Controls.Add(guna2Button1);
            Controls.Add(label_tongtien);
            Controls.Add(lb_tongtien);
            Controls.Add(dtgv_billdetail);
            Name = "BillDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "BillDetail";
            ((System.ComponentModel.ISupportInitialize)dtgv_billdetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)thuocHoaDonBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_billdetail;
        private System.Windows.Forms.BindingSource thuocHoaDonBindingSource;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label lb_thanhtoan;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label_tongtien;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn thidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giabanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
    }
}