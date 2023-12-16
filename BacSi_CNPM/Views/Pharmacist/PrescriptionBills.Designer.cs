namespace Hospital.Views.Pharmacist
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionBills));
            tendt = new System.Windows.Forms.Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            bill_name = new System.Windows.Forms.Label();
            dtgv_bill = new Guna.UI2.WinForms.Guna2DataGridView();
            currentBindingSource = new System.Windows.Forms.BindingSource(components);
            save = new User_Controls.UC_Button();
            dtgv_Presciption = new Guna.UI2.WinForms.Guna2DataGridView();
            TongTien_text = new System.Windows.Forms.Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label_TongTien = new System.Windows.Forms.Label();
            print_btn = new User_Controls.UC_Button();
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dtgv_bill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_Presciption).BeginInit();
            SuspendLayout();
            // 
            // tendt
            // 
            tendt.AutoSize = true;
            tendt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tendt.Location = new System.Drawing.Point(174, 57);
            tendt.Name = "tendt";
            tendt.Size = new System.Drawing.Size(0, 28);
            tendt.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges5;
            guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = System.Drawing.Color.White;
            guna2ControlBox1.Location = new System.Drawing.Point(933, -1);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox1.Size = new System.Drawing.Size(56, 36);
            guna2ControlBox1.TabIndex = 1;
            // 
            // bill_name
            // 
            bill_name.AutoSize = true;
            bill_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bill_name.Location = new System.Drawing.Point(635, 57);
            bill_name.Name = "bill_name";
            bill_name.Size = new System.Drawing.Size(48, 28);
            bill_name.TabIndex = 3;
            bill_name.Text = "Bills";
            // 
            // dtgv_bill
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dtgv_bill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dtgv_bill.ColumnHeadersHeight = 40;
            dtgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_bill.DefaultCellStyle = dataGridViewCellStyle9;
            dtgv_bill.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_bill.Location = new System.Drawing.Point(544, 108);
            dtgv_bill.Name = "dtgv_bill";
            dtgv_bill.RowHeadersVisible = false;
            dtgv_bill.RowHeadersWidth = 51;
            dtgv_bill.RowTemplate.Height = 29;
            dtgv_bill.Size = new System.Drawing.Size(393, 402);
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
            dtgv_bill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_bill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_bill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_bill.ThemeStyle.HeaderStyle.Height = 40;
            dtgv_bill.ThemeStyle.ReadOnly = false;
            dtgv_bill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_bill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_bill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_bill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_bill.ThemeStyle.RowsStyle.Height = 29;
            dtgv_bill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_bill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            // 
            // currentBindingSource
            // 
            currentBindingSource.DataSource = typeof(DTO.Current);
            // 
            // save
            // 
            save.BackColor = System.Drawing.Color.Blue;
            save.BackgroundColor = System.Drawing.Color.Blue;
            save.BorderColor = System.Drawing.Color.Blue;
            save.BorderRadius = 0;
            save.BorderSize = 0;
            save.FlatAppearance.BorderSize = 0;
            save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            save.FontSize = 9;
            save.ForeColor = System.Drawing.Color.White;
            save.Location = new System.Drawing.Point(748, 531);
            save.Name = "save";
            save.Size = new System.Drawing.Size(88, 34);
            save.TabIndex = 5;
            save.Text = "Save";
            save.TextColor = System.Drawing.Color.White;
            save.UseVisualStyleBackColor = false;
            save.Click += print_btn_Click;
            // 
            // dtgv_Presciption
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dtgv_Presciption.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_Presciption.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dtgv_Presciption.ColumnHeadersHeight = 40;
            dtgv_Presciption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_Presciption.DefaultCellStyle = dataGridViewCellStyle12;
            dtgv_Presciption.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_Presciption.Location = new System.Drawing.Point(53, 108);
            dtgv_Presciption.Margin = new System.Windows.Forms.Padding(2);
            dtgv_Presciption.Name = "dtgv_Presciption";
            dtgv_Presciption.ReadOnly = true;
            dtgv_Presciption.RowHeadersVisible = false;
            dtgv_Presciption.RowHeadersWidth = 62;
            dtgv_Presciption.RowTemplate.Height = 33;
            dtgv_Presciption.Size = new System.Drawing.Size(396, 402);
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
            dtgv_Presciption.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_Presciption.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_Presciption.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_Presciption.ThemeStyle.HeaderStyle.Height = 40;
            dtgv_Presciption.ThemeStyle.ReadOnly = true;
            dtgv_Presciption.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_Presciption.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_Presciption.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_Presciption.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_Presciption.ThemeStyle.RowsStyle.Height = 33;
            dtgv_Presciption.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_Presciption.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            // 
            // TongTien_text
            // 
            TongTien_text.Location = new System.Drawing.Point(758, 465);
            TongTien_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            TongTien_text.Name = "TongTien_text";
            TongTien_text.Size = new System.Drawing.Size(168, 33);
            TongTien_text.TabIndex = 9;
            TongTien_text.Text = "Tong Tien";
            TongTien_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            guna2Button1.ForeColor = System.Drawing.Color.White;
            guna2Button1.Location = new System.Drawing.Point(544, 438);
            guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new System.Drawing.Size(393, 8);
            guna2Button1.TabIndex = 10;
            // 
            // label_TongTien
            // 
            label_TongTien.Location = new System.Drawing.Point(674, 465);
            label_TongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label_TongTien.Name = "label_TongTien";
            label_TongTien.Size = new System.Drawing.Size(79, 33);
            label_TongTien.TabIndex = 11;
            label_TongTien.Text = "Tong Tien: ";
            label_TongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // print_btn
            // 
            print_btn.BackColor = System.Drawing.Color.DeepPink;
            print_btn.BackgroundColor = System.Drawing.Color.DeepPink;
            print_btn.BorderColor = System.Drawing.Color.Blue;
            print_btn.BorderRadius = 0;
            print_btn.BorderSize = 0;
            print_btn.FlatAppearance.BorderSize = 0;
            print_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            print_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            print_btn.FontSize = 9;
            print_btn.ForeColor = System.Drawing.Color.White;
            print_btn.Location = new System.Drawing.Point(850, 530);
            print_btn.Margin = new System.Windows.Forms.Padding(2);
            print_btn.Name = "print_btn";
            print_btn.Size = new System.Drawing.Size(86, 34);
            print_btn.TabIndex = 12;
            print_btn.Text = "Print";
            print_btn.TextColor = System.Drawing.Color.White;
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
            // PrescriptionBills
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(989, 635);
            Controls.Add(print_btn);
            Controls.Add(label_TongTien);
            Controls.Add(guna2Button1);
            Controls.Add(TongTien_text);
            Controls.Add(dtgv_Presciption);
            Controls.Add(save);
            Controls.Add(dtgv_bill);
            Controls.Add(bill_name);
            Controls.Add(guna2ControlBox1);
            Controls.Add(tendt);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "PrescriptionBills";
            Text = "PrescriptionBill";
            ((System.ComponentModel.ISupportInitialize)dtgv_bill).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_Presciption).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label tendt;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
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
    }
}