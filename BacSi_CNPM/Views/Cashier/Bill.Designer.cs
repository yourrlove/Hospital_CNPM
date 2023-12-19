namespace Hospital.Views.Cashier
{
    partial class Bill
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            bill_panel = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new System.Windows.Forms.Label();
            dtgv_bill = new Guna.UI2.WinForms.Guna2DataGridView();
            tHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            thuocBindingSource = new System.Windows.Forms.BindingSource(components);
            bill_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_bill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thuocBindingSource).BeginInit();
            SuspendLayout();
            // 
            // bill_panel
            // 
            bill_panel.Controls.Add(label1);
            bill_panel.Controls.Add(dtgv_bill);
            bill_panel.CustomizableEdges = customizableEdges1;
            bill_panel.Location = new System.Drawing.Point(12, 7);
            bill_panel.Name = "bill_panel";
            bill_panel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            bill_panel.Size = new System.Drawing.Size(453, 502);
            bill_panel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(190, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 25);
            label1.TabIndex = 1;
            label1.Text = "Bill";
            // 
            // dtgv_bill
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dtgv_bill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_bill.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_bill.ColumnHeadersHeight = 4;
            dtgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { tHIDDataGridViewTextBoxColumn, tenThuocDataGridViewTextBoxColumn, giaBanDataGridViewTextBoxColumn, soLuongDataGridViewTextBoxColumn });
            dtgv_bill.DataSource = thuocBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_bill.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_bill.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_bill.Location = new System.Drawing.Point(37, 69);
            dtgv_bill.Name = "dtgv_bill";
            dtgv_bill.RowHeadersVisible = false;
            dtgv_bill.RowHeadersWidth = 62;
            dtgv_bill.RowTemplate.Height = 33;
            dtgv_bill.Size = new System.Drawing.Size(350, 396);
            dtgv_bill.TabIndex = 0;
            dtgv_bill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_bill.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_bill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_bill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_bill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_bill.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_bill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_bill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_bill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_bill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_bill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_bill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_bill.ThemeStyle.HeaderStyle.Height = 4;
            dtgv_bill.ThemeStyle.ReadOnly = false;
            dtgv_bill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_bill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_bill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_bill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_bill.ThemeStyle.RowsStyle.Height = 33;
            dtgv_bill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_bill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_bill.CellContentClick += dtgv_bill_CellContentClick;
            // 
            // tHIDDataGridViewTextBoxColumn
            // 
            tHIDDataGridViewTextBoxColumn.DataPropertyName = "TH_ID";
            tHIDDataGridViewTextBoxColumn.HeaderText = "TH_ID";
            tHIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            tHIDDataGridViewTextBoxColumn.Name = "tHIDDataGridViewTextBoxColumn";
            // 
            // tenThuocDataGridViewTextBoxColumn
            // 
            tenThuocDataGridViewTextBoxColumn.DataPropertyName = "TenThuoc";
            tenThuocDataGridViewTextBoxColumn.HeaderText = "TenThuoc";
            tenThuocDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenThuocDataGridViewTextBoxColumn.Name = "tenThuocDataGridViewTextBoxColumn";
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            giaBanDataGridViewTextBoxColumn.HeaderText = "GiaBan";
            giaBanDataGridViewTextBoxColumn.MinimumWidth = 8;
            giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            soLuongDataGridViewTextBoxColumn.MinimumWidth = 8;
            soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // thuocBindingSource
            // 
            thuocBindingSource.DataSource = typeof(DTO.Thuoc);
            // 
            // Bill
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(927, 521);
            Controls.Add(bill_panel);
            Name = "Bill";
            Text = "Bill";
            bill_panel.ResumeLayout(false);
            bill_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_bill).EndInit();
            ((System.ComponentModel.ISupportInitialize)thuocBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel bill_panel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource thuocBindingSource;
    }
}