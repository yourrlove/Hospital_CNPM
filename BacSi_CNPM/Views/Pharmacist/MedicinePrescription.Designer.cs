namespace Hospital.Views.Pharmacist
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
            dtgv_medicinePrescription = new Guna.UI2.WinForms.Guna2DataGridView();
            dTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ngayKeDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tenDonThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            donThuocBindingSource1 = new System.Windows.Forms.BindingSource(components);
            donThuocBindingSource = new System.Windows.Forms.BindingSource(components);
            label1 = new System.Windows.Forms.Label();
            sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)dtgv_medicinePrescription).BeginInit();
            ((System.ComponentModel.ISupportInitialize)donThuocBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)donThuocBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtgv_medicinePrescription
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dtgv_medicinePrescription.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_medicinePrescription.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_medicinePrescription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_medicinePrescription.ColumnHeadersHeight = 40;
            dtgv_medicinePrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_medicinePrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dTIDDataGridViewTextBoxColumn, ngayKeDonDataGridViewTextBoxColumn, bSIDDataGridViewTextBoxColumn, tenDonThuocDataGridViewTextBoxColumn });
            dtgv_medicinePrescription.DataSource = donThuocBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_medicinePrescription.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_medicinePrescription.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_medicinePrescription.Location = new System.Drawing.Point(28, 104);
            dtgv_medicinePrescription.Name = "dtgv_medicinePrescription";
            dtgv_medicinePrescription.RowHeadersVisible = false;
            dtgv_medicinePrescription.RowHeadersWidth = 51;
            dtgv_medicinePrescription.RowTemplate.Height = 29;
            dtgv_medicinePrescription.Size = new System.Drawing.Size(417, 546);
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
            dtgv_medicinePrescription.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_medicinePrescription.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_medicinePrescription.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_medicinePrescription.ThemeStyle.HeaderStyle.Height = 40;
            dtgv_medicinePrescription.ThemeStyle.ReadOnly = false;
            dtgv_medicinePrescription.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_medicinePrescription.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_medicinePrescription.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_medicinePrescription.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_medicinePrescription.ThemeStyle.RowsStyle.Height = 29;
            dtgv_medicinePrescription.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_medicinePrescription.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_medicinePrescription.CellClick += dtgv_medicinePrescription_CellClick;
            // 
            // dTIDDataGridViewTextBoxColumn
            // 
            dTIDDataGridViewTextBoxColumn.DataPropertyName = "DT_ID";
            dTIDDataGridViewTextBoxColumn.HeaderText = "DT_ID";
            dTIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            dTIDDataGridViewTextBoxColumn.Name = "dTIDDataGridViewTextBoxColumn";
            dTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ngayKeDonDataGridViewTextBoxColumn
            // 
            ngayKeDonDataGridViewTextBoxColumn.DataPropertyName = "NgayKeDon";
            ngayKeDonDataGridViewTextBoxColumn.HeaderText = "NgayKeDon";
            ngayKeDonDataGridViewTextBoxColumn.MinimumWidth = 8;
            ngayKeDonDataGridViewTextBoxColumn.Name = "ngayKeDonDataGridViewTextBoxColumn";
            // 
            // bSIDDataGridViewTextBoxColumn
            // 
            bSIDDataGridViewTextBoxColumn.DataPropertyName = "BS_ID";
            bSIDDataGridViewTextBoxColumn.HeaderText = "BS_ID";
            bSIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            bSIDDataGridViewTextBoxColumn.Name = "bSIDDataGridViewTextBoxColumn";
            bSIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenDonThuocDataGridViewTextBoxColumn
            // 
            tenDonThuocDataGridViewTextBoxColumn.DataPropertyName = "TenDonThuoc";
            tenDonThuocDataGridViewTextBoxColumn.HeaderText = "TenDonThuoc";
            tenDonThuocDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenDonThuocDataGridViewTextBoxColumn.Name = "tenDonThuocDataGridViewTextBoxColumn";
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
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(163, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(144, 31);
            label1.TabIndex = 1;
            label1.Text = "Prescription";
            // 
            // sqlConnection1
            // 
            sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // MedicinePrescription
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(481, 782);
            Controls.Add(label1);
            Controls.Add(dtgv_medicinePrescription);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "MedicinePrescription";
            Text = "MedicinePrescription";
            ((System.ComponentModel.ISupportInitialize)dtgv_medicinePrescription).EndInit();
            ((System.ComponentModel.ISupportInitialize)donThuocBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)donThuocBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dtgv_medicinePrescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource donThuocBindingSource;
        private System.Windows.Forms.BindingSource donThuocBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKeDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDonThuocDataGridViewTextBoxColumn;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
    }
}