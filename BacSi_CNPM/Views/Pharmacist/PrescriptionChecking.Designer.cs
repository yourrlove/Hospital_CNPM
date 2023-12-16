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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            Prescription_Checking = new Guna.UI2.WinForms.Guna2Panel();
            btn_reciept = new Guna.UI2.WinForms.Guna2Button();
            lb_donthuoc = new System.Windows.Forms.Label();
            dtgv_Updated = new Guna.UI2.WinForms.Guna2DataGridView();
            hDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            chiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(components);
            dtgv_notRecieved = new Guna.UI2.WinForms.Guna2DataGridView();
            Prescription_Checking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_Updated).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chiTietHoaDonBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_notRecieved).BeginInit();
            SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges7;
            guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = System.Drawing.Color.White;
            guna2ControlBox1.Location = new System.Drawing.Point(1093, 3);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2ControlBox1.Size = new System.Drawing.Size(56, 36);
            guna2ControlBox1.TabIndex = 0;
            // 
            // Prescription_Checking
            // 
            Prescription_Checking.Controls.Add(btn_reciept);
            Prescription_Checking.Controls.Add(lb_donthuoc);
            Prescription_Checking.Controls.Add(dtgv_Updated);
            Prescription_Checking.Controls.Add(dtgv_notRecieved);
            Prescription_Checking.Controls.Add(guna2ControlBox1);
            Prescription_Checking.CustomizableEdges = customizableEdges11;
            Prescription_Checking.Location = new System.Drawing.Point(12, 12);
            Prescription_Checking.Name = "Prescription_Checking";
            Prescription_Checking.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Prescription_Checking.Size = new System.Drawing.Size(1152, 745);
            Prescription_Checking.TabIndex = 1;
            Prescription_Checking.Paint += guna2Panel1_Paint;
            // 
            // btn_reciept
            // 
            btn_reciept.CustomizableEdges = customizableEdges9;
            btn_reciept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btn_reciept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btn_reciept.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            btn_reciept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            btn_reciept.Font = new System.Drawing.Font("Segoe UI", 9F);
            btn_reciept.ForeColor = System.Drawing.Color.White;
            btn_reciept.Location = new System.Drawing.Point(271, 615);
            btn_reciept.Name = "btn_reciept";
            btn_reciept.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btn_reciept.Size = new System.Drawing.Size(138, 47);
            btn_reciept.TabIndex = 4;
            btn_reciept.Text = "Reciept";
            btn_reciept.Click += btn_reciept_Click;
            // 
            // lb_donthuoc
            // 
            lb_donthuoc.AutoSize = true;
            lb_donthuoc.Location = new System.Drawing.Point(667, 56);
            lb_donthuoc.Name = "lb_donthuoc";
            lb_donthuoc.Size = new System.Drawing.Size(108, 20);
            lb_donthuoc.TabIndex = 3;
            lb_donthuoc.Text = "Ten Don Thuoc";
            // 
            // dtgv_Updated
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dtgv_Updated.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dtgv_Updated.AutoGenerateColumns = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_Updated.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dtgv_Updated.ColumnHeadersHeight = 4;
            dtgv_Updated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_Updated.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { hDIDDataGridViewTextBoxColumn, tHIDDataGridViewTextBoxColumn, soLuongDataGridViewTextBoxColumn, donGiaDataGridViewTextBoxColumn });
            dtgv_Updated.DataSource = chiTietHoaDonBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_Updated.DefaultCellStyle = dataGridViewCellStyle9;
            dtgv_Updated.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_Updated.Location = new System.Drawing.Point(546, 94);
            dtgv_Updated.Name = "dtgv_Updated";
            dtgv_Updated.RowHeadersVisible = false;
            dtgv_Updated.RowHeadersWidth = 51;
            dtgv_Updated.RowTemplate.Height = 29;
            dtgv_Updated.Size = new System.Drawing.Size(468, 384);
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
            dtgv_Updated.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_Updated.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_Updated.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_Updated.ThemeStyle.HeaderStyle.Height = 4;
            dtgv_Updated.ThemeStyle.ReadOnly = false;
            dtgv_Updated.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_Updated.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_Updated.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_Updated.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_Updated.ThemeStyle.RowsStyle.Height = 29;
            dtgv_Updated.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_Updated.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            // 
            // hDIDDataGridViewTextBoxColumn
            // 
            hDIDDataGridViewTextBoxColumn.DataPropertyName = "HD_ID";
            hDIDDataGridViewTextBoxColumn.HeaderText = "HD_ID";
            hDIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            hDIDDataGridViewTextBoxColumn.Name = "hDIDDataGridViewTextBoxColumn";
            // 
            // tHIDDataGridViewTextBoxColumn
            // 
            tHIDDataGridViewTextBoxColumn.DataPropertyName = "TH_ID";
            tHIDDataGridViewTextBoxColumn.HeaderText = "TH_ID";
            tHIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            tHIDDataGridViewTextBoxColumn.Name = "tHIDDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // chiTietHoaDonBindingSource
            // 
            chiTietHoaDonBindingSource.DataSource = typeof(DTO.ChiTietHoaDon);
            // 
            // dtgv_notRecieved
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dtgv_notRecieved.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_notRecieved.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dtgv_notRecieved.ColumnHeadersHeight = 4;
            dtgv_notRecieved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_notRecieved.DefaultCellStyle = dataGridViewCellStyle12;
            dtgv_notRecieved.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_notRecieved.Location = new System.Drawing.Point(52, 56);
            dtgv_notRecieved.Name = "dtgv_notRecieved";
            dtgv_notRecieved.RowHeadersVisible = false;
            dtgv_notRecieved.RowHeadersWidth = 51;
            dtgv_notRecieved.RowTemplate.Height = 29;
            dtgv_notRecieved.Size = new System.Drawing.Size(357, 531);
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
            dtgv_notRecieved.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_notRecieved.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_notRecieved.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_notRecieved.ThemeStyle.HeaderStyle.Height = 4;
            dtgv_notRecieved.ThemeStyle.ReadOnly = false;
            dtgv_notRecieved.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_notRecieved.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_notRecieved.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtgv_notRecieved.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_notRecieved.ThemeStyle.RowsStyle.Height = 29;
            dtgv_notRecieved.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_notRecieved.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_notRecieved.CellClick += dtgv_notRecieved_CellClick;
            dtgv_notRecieved.CellContentClick += dtgv_notRecieved_CellContentClick;
            // 
            // PrescriptionChecking
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1190, 779);
            ControlBox = false;
            Controls.Add(Prescription_Checking);
            Name = "PrescriptionChecking";
            Text = "PrescriptionChecking";
            Prescription_Checking.ResumeLayout(false);
            Prescription_Checking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_Updated).EndInit();
            ((System.ComponentModel.ISupportInitialize)chiTietHoaDonBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_notRecieved).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel Prescription_Checking;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_notRecieved;
        private System.Windows.Forms.Label lb_donthuoc;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_Updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
        private Guna.UI2.WinForms.Guna2Button btn_reciept;
    }
}