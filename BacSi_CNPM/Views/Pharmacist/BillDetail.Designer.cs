namespace Hospital.Views.Pharmacist
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            bill_detail = new Guna.UI2.WinForms.Guna2Panel();
            label_tongtien = new System.Windows.Forms.Label();
            lb_tongtien = new System.Windows.Forms.Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            dtgv_billdetail = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new System.Windows.Forms.Label();
            lb_thanhtoan = new System.Windows.Forms.Label();
            bill_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_billdetail).BeginInit();
            SuspendLayout();
            // 
            // bill_detail
            // 
            bill_detail.BackColor = System.Drawing.SystemColors.ScrollBar;
            bill_detail.Controls.Add(lb_thanhtoan);
            bill_detail.Controls.Add(label1);
            bill_detail.Controls.Add(guna2Button1);
            bill_detail.Controls.Add(label_tongtien);
            bill_detail.Controls.Add(lb_tongtien);
            bill_detail.Controls.Add(guna2ControlBox1);
            bill_detail.Controls.Add(dtgv_billdetail);
            bill_detail.CustomizableEdges = customizableEdges11;
            bill_detail.Location = new System.Drawing.Point(2, 5);
            bill_detail.Name = "bill_detail";
            bill_detail.ShadowDecoration.CustomizableEdges = customizableEdges12;
            bill_detail.Size = new System.Drawing.Size(778, 616);
            bill_detail.TabIndex = 0;
            bill_detail.Paint += bill_detail_Paint;
            // 
            // label_tongtien
            // 
            label_tongtien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
            label_tongtien.Location = new System.Drawing.Point(186, 442);
            label_tongtien.Name = "label_tongtien";
            label_tongtien.Size = new System.Drawing.Size(131, 32);
            label_tongtien.TabIndex = 5;
            label_tongtien.Text = "Tong Tien";
            label_tongtien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_tongtien
            // 
            lb_tongtien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
            lb_tongtien.Location = new System.Drawing.Point(343, 442);
            lb_tongtien.Name = "lb_tongtien";
            lb_tongtien.Size = new System.Drawing.Size(95, 32);
            lb_tongtien.TabIndex = 4;
            lb_tongtien.Text = "Tongtien";
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges9;
            guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = System.Drawing.Color.White;
            guna2ControlBox1.Location = new System.Drawing.Point(730, 3);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            guna2ControlBox1.TabIndex = 1;
            // 
            // dtgv_billdetail
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dtgv_billdetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_billdetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgv_billdetail.ColumnHeadersHeight = 40;
            dtgv_billdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_billdetail.DefaultCellStyle = dataGridViewCellStyle6;
            dtgv_billdetail.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_billdetail.Location = new System.Drawing.Point(62, 38);
            dtgv_billdetail.Name = "dtgv_billdetail";
            dtgv_billdetail.RowHeadersVisible = false;
            dtgv_billdetail.RowHeadersWidth = 51;
            dtgv_billdetail.RowTemplate.Height = 29;
            dtgv_billdetail.Size = new System.Drawing.Size(408, 462);
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
            dtgv_billdetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_billdetail.ThemeStyle.HeaderStyle.Height = 40;
            dtgv_billdetail.ThemeStyle.ReadOnly = false;
            dtgv_billdetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_billdetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_billdetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_billdetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_billdetail.ThemeStyle.RowsStyle.Height = 29;
            dtgv_billdetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_billdetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            guna2Button1.ForeColor = System.Drawing.Color.White;
            guna2Button1.Location = new System.Drawing.Point(62, 407);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new System.Drawing.Size(408, 10);
            guna2Button1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(166, 366);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(169, 26);
            label1.TabIndex = 7;
            label1.Text = "Hinh thuc thanh toan";
            // 
            // lb_thanhtoan
            // 
            lb_thanhtoan.Location = new System.Drawing.Point(343, 366);
            lb_thanhtoan.Name = "lb_thanhtoan";
            lb_thanhtoan.Size = new System.Drawing.Size(111, 26);
            lb_thanhtoan.TabIndex = 8;
            lb_thanhtoan.Text = "label2";
            lb_thanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BillDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(531, 527);
            Controls.Add(bill_detail);
            Name = "BillDetail";
            Text = "BillDetail";
            bill_detail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_billdetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel bill_detail;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_billdetail;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.Label label_tongtien;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label lb_thanhtoan;
    }
}