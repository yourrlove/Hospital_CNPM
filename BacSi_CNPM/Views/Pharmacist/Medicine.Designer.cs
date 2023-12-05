namespace Hospital.Views.Pharmacist
{
    partial class Medicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicine));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dtgv_medicine = new Guna.UI2.WinForms.Guna2DataGridView();
            idMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            medicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            search_medicine = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgv_medicine).BeginInit();
            SuspendLayout();
            // 
            // dtgv_medicine
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dtgv_medicine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_medicine.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_medicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_medicine.ColumnHeadersHeight = 22;
            dtgv_medicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_medicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idMedicine, medicineName });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_medicine.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_medicine.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_medicine.Location = new System.Drawing.Point(12, 77);
            dtgv_medicine.Name = "dtgv_medicine";
            dtgv_medicine.RowHeadersVisible = false;
            dtgv_medicine.RowHeadersWidth = 51;
            dtgv_medicine.RowTemplate.Height = 29;
            dtgv_medicine.Size = new System.Drawing.Size(1110, 751);
            dtgv_medicine.TabIndex = 0;
            dtgv_medicine.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_medicine.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_medicine.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_medicine.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_medicine.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_medicine.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_medicine.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_medicine.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_medicine.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_medicine.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_medicine.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_medicine.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_medicine.ThemeStyle.HeaderStyle.Height = 22;
            dtgv_medicine.ThemeStyle.ReadOnly = false;
            dtgv_medicine.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_medicine.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_medicine.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_medicine.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_medicine.ThemeStyle.RowsStyle.Height = 29;
            dtgv_medicine.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_medicine.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_medicine.CellContentClick += dtgv_medicine_CellContentClick;
            // 
            // idMedicine
            // 
            idMedicine.HeaderText = "ID";
            idMedicine.MinimumWidth = 6;
            idMedicine.Name = "idMedicine";
            // 
            // medicineName
            // 
            medicineName.HeaderText = "Name";
            medicineName.MinimumWidth = 6;
            medicineName.Name = "medicineName";
            // 
            // search_medicine
            // 
            search_medicine.CustomizableEdges = customizableEdges1;
            search_medicine.DefaultText = "Search Medicines";
            search_medicine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            search_medicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            search_medicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            search_medicine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            search_medicine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            search_medicine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            search_medicine.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            search_medicine.IconLeft = (System.Drawing.Image)resources.GetObject("search_medicine.IconLeft");
            search_medicine.IconLeftSize = new System.Drawing.Size(32, 32);
            search_medicine.Location = new System.Drawing.Point(12, 13);
            search_medicine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            search_medicine.Name = "search_medicine";
            search_medicine.PasswordChar = '\0';
            search_medicine.PlaceholderText = "";
            search_medicine.SelectedText = "";
            search_medicine.ShadowDecoration.CustomizableEdges = customizableEdges2;
            search_medicine.Size = new System.Drawing.Size(306, 41);
            search_medicine.TabIndex = 2;
            // 
            // Medicine
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1134, 840);
            Controls.Add(search_medicine);
            Controls.Add(dtgv_medicine);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Medicine";
            Text = "Medicine";
            Load += Medicine_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_medicine).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dtgv_medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineName;
        private Guna.UI2.WinForms.Guna2TextBox search_medicine;
    }
}