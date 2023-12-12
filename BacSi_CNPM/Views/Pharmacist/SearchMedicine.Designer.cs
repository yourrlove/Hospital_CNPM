namespace Hospital.Views.Pharmacist
{
    partial class SearchMedicine
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMedicine));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            dtgv_SearchMedicine = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgv_SearchMedicine).BeginInit();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.BorderColor = System.Drawing.Color.Silver;
            searchBox.BorderRadius = 24;
            searchBox.CustomizableEdges = customizableEdges1;
            searchBox.DefaultText = "Search Medicines";
            searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            searchBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            searchBox.IconLeft = (System.Drawing.Image)resources.GetObject("searchBox.IconLeft");
            searchBox.IconLeftSize = new System.Drawing.Size(38, 38);
            searchBox.Location = new System.Drawing.Point(49, 41);
            searchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            searchBox.Name = "searchBox";
            searchBox.PasswordChar = '\0';
            searchBox.PlaceholderText = "";
            searchBox.SelectedText = "";
            searchBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            searchBox.Size = new System.Drawing.Size(320, 58);
            searchBox.TabIndex = 3;
            searchBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // dtgv_SearchMedicine
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dtgv_SearchMedicine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_SearchMedicine.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtgv_SearchMedicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_SearchMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_SearchMedicine.ColumnHeadersHeight = 50;
            dtgv_SearchMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_SearchMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_SearchMedicine.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_SearchMedicine.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_SearchMedicine.Location = new System.Drawing.Point(49, 150);
            dtgv_SearchMedicine.Name = "dtgv_SearchMedicine";
            dtgv_SearchMedicine.RowHeadersVisible = false;
            dtgv_SearchMedicine.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_SearchMedicine.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_SearchMedicine.RowTemplate.Height = 50;
            dtgv_SearchMedicine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dtgv_SearchMedicine.Size = new System.Drawing.Size(1045, 661);
            dtgv_SearchMedicine.TabIndex = 5;
            dtgv_SearchMedicine.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_SearchMedicine.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_SearchMedicine.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_SearchMedicine.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_SearchMedicine.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_SearchMedicine.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_SearchMedicine.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_SearchMedicine.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_SearchMedicine.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_SearchMedicine.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_SearchMedicine.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_SearchMedicine.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_SearchMedicine.ThemeStyle.HeaderStyle.Height = 50;
            dtgv_SearchMedicine.ThemeStyle.ReadOnly = false;
            dtgv_SearchMedicine.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_SearchMedicine.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_SearchMedicine.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_SearchMedicine.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_SearchMedicine.ThemeStyle.RowsStyle.Height = 50;
            dtgv_SearchMedicine.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            dtgv_SearchMedicine.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // SearchMedicine
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1134, 840);
            Controls.Add(dtgv_SearchMedicine);
            Controls.Add(searchBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "SearchMedicine";
            Text = "SearchMedicine";
            Load += SearchMedicine_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_SearchMedicine).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_SearchMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}