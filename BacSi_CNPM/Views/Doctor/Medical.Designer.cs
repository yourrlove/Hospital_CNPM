namespace Hospital.Views.Doctor
{
    partial class Medical
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medical));
            dgvRecords = new Guna.UI2.WinForms.Guna2DataGridView();
            patientRecordBindingSource3 = new System.Windows.Forms.BindingSource(components);
            patientRecordBindingSource = new System.Windows.Forms.BindingSource(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2TextBox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            cbAccept = new Guna.UI2.WinForms.Guna2ComboBox();
            sortRequest = new System.Windows.Forms.Label();
            btnPrint = new Guna.UI2.WinForms.Guna2Button();
            numOfRecords = new System.Windows.Forms.Label();
            recordCount = new System.Windows.Forms.Label();
            patientRecordBindingSource1 = new System.Windows.Forms.BindingSource(components);
            patientRecordBindingSource2 = new System.Windows.Forms.BindingSource(components);
            col_Status = new System.Windows.Forms.DataGridViewImageColumn();
            bAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patientSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patientDoBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            recordNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            checkInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientRecordBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientRecordBindingSource).BeginInit();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patientRecordBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientRecordBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dgvRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecords.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRecords.ColumnHeadersHeight = 47;
            dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { col_Status, bAIDDataGridViewTextBoxColumn, bNIDDataGridViewTextBoxColumn, patientNameDataGridViewTextBoxColumn, patientSexDataGridViewTextBoxColumn, patientDoBDataGridViewTextBoxColumn, recordNameDataGridViewTextBoxColumn, checkInDataGridViewTextBoxColumn });
            dgvRecords.DataSource = patientRecordBindingSource3;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvRecords.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRecords.GridColor = System.Drawing.Color.FromArgb(245, 245, 250);
            dgvRecords.Location = new System.Drawing.Point(12, 149);
            dgvRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvRecords.Name = "dgvRecords";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRecords.RowHeadersVisible = false;
            dgvRecords.RowHeadersWidth = 51;
            dgvRecords.RowTemplate.DividerHeight = 5;
            dgvRecords.RowTemplate.Height = 50;
            dgvRecords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dgvRecords.Size = new System.Drawing.Size(1128, 906);
            dgvRecords.TabIndex = 3;
            dgvRecords.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dgvRecords.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvRecords.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dgvRecords.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dgvRecords.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dgvRecords.ThemeStyle.BackColor = System.Drawing.Color.White;
            dgvRecords.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(245, 245, 250);
            dgvRecords.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightCyan;
            dgvRecords.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvRecords.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dgvRecords.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            dgvRecords.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvRecords.ThemeStyle.HeaderStyle.Height = 47;
            dgvRecords.ThemeStyle.ReadOnly = false;
            dgvRecords.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dgvRecords.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecords.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dgvRecords.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dgvRecords.ThemeStyle.RowsStyle.Height = 50;
            dgvRecords.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            dgvRecords.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvRecords.CellContentClick += dgvRecords_CellContentClick;
            // 
            // patientRecordBindingSource3
            // 
            patientRecordBindingSource3.DataSource = typeof(DataAccessTier.PatientRecord);
            // 
            // patientRecordBindingSource
            // 
            patientRecordBindingSource.DataSource = typeof(DataAccessTier.PatientRecord);
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(guna2TextBox_Search);
            guna2Panel1.Controls.Add(cbAccept);
            guna2Panel1.Controls.Add(sortRequest);
            guna2Panel1.Controls.Add(btnPrint);
            guna2Panel1.Controls.Add(numOfRecords);
            guna2Panel1.Controls.Add(recordCount);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            guna2Panel1.Location = new System.Drawing.Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new System.Drawing.Size(1152, 125);
            guna2Panel1.TabIndex = 4;
            // 
            // guna2TextBox_Search
            // 
            guna2TextBox_Search.CustomizableEdges = customizableEdges1;
            guna2TextBox_Search.DefaultText = "";
            guna2TextBox_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            guna2TextBox_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            guna2TextBox_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            guna2TextBox_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            guna2TextBox_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            guna2TextBox_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            guna2TextBox_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            guna2TextBox_Search.IconLeft = (System.Drawing.Image)resources.GetObject("guna2TextBox_Search.IconLeft");
            guna2TextBox_Search.Location = new System.Drawing.Point(226, 47);
            guna2TextBox_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            guna2TextBox_Search.Name = "guna2TextBox_Search";
            guna2TextBox_Search.PasswordChar = '\0';
            guna2TextBox_Search.PlaceholderText = "Search...";
            guna2TextBox_Search.SelectedText = "";
            guna2TextBox_Search.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox_Search.Size = new System.Drawing.Size(467, 44);
            guna2TextBox_Search.TabIndex = 8;
            guna2TextBox_Search.TextChanged += guna2TextBox_Search_TextChanged;
            // 
            // cbAccept
            // 
            cbAccept.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cbAccept.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            cbAccept.CustomizableEdges = customizableEdges3;
            cbAccept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAccept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAccept.FillColor = System.Drawing.Color.Blue;
            cbAccept.FocusedColor = System.Drawing.Color.FromArgb(94, 148, 255);
            cbAccept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            cbAccept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbAccept.ForeColor = System.Drawing.Color.White;
            cbAccept.ItemHeight = 30;
            cbAccept.Items.AddRange(new object[] { "Taken", "Untaken" });
            cbAccept.Location = new System.Drawing.Point(848, 47);
            cbAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbAccept.Name = "cbAccept";
            cbAccept.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbAccept.Size = new System.Drawing.Size(117, 36);
            cbAccept.StartIndex = 0;
            cbAccept.TabIndex = 6;
            cbAccept.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // sortRequest
            // 
            sortRequest.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            sortRequest.AutoSize = true;
            sortRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            sortRequest.Location = new System.Drawing.Point(763, 47);
            sortRequest.Name = "sortRequest";
            sortRequest.Size = new System.Drawing.Size(79, 28);
            sortRequest.TabIndex = 5;
            sortRequest.Text = "Sort By:";
            // 
            // btnPrint
            // 
            btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPrint.BorderColor = System.Drawing.Color.Gray;
            btnPrint.BorderThickness = 1;
            btnPrint.CustomizableEdges = customizableEdges5;
            btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            btnPrint.FillColor = System.Drawing.Color.Transparent;
            btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnPrint.ForeColor = System.Drawing.Color.Black;
            btnPrint.HoverState.FillColor = System.Drawing.Color.Azure;
            btnPrint.HoverState.ForeColor = System.Drawing.Color.White;
            btnPrint.HoverState.Image = (System.Drawing.Image)resources.GetObject("resource.Image");
            btnPrint.Image = (System.Drawing.Image)resources.GetObject("btnPrint.Image");
            btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            btnPrint.ImageSize = new System.Drawing.Size(32, 32);
            btnPrint.Location = new System.Drawing.Point(998, 41);
            btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnPrint.Size = new System.Drawing.Size(142, 56);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "Print";
            btnPrint.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // numOfRecords
            // 
            numOfRecords.AutoSize = true;
            numOfRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numOfRecords.Location = new System.Drawing.Point(124, 48);
            numOfRecords.Name = "numOfRecords";
            numOfRecords.Size = new System.Drawing.Size(81, 28);
            numOfRecords.TabIndex = 3;
            numOfRecords.Text = "Records";
            // 
            // recordCount
            // 
            recordCount.AutoSize = true;
            recordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            recordCount.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            recordCount.Location = new System.Drawing.Point(56, 41);
            recordCount.Name = "recordCount";
            recordCount.Size = new System.Drawing.Size(62, 42);
            recordCount.TabIndex = 2;
            recordCount.Text = "20";
            // 
            // patientRecordBindingSource1
            // 
            patientRecordBindingSource1.DataSource = typeof(DataAccessTier.PatientRecord);
            // 
            // patientRecordBindingSource2
            // 
            patientRecordBindingSource2.DataSource = typeof(DataAccessTier.PatientRecord);
            // 
            // col_Status
            // 
            col_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            col_Status.FillWeight = 80.2139053F;
            col_Status.HeaderText = "Status";
            col_Status.Image = (System.Drawing.Image)resources.GetObject("col_Status.Image");
            col_Status.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            col_Status.MinimumWidth = 6;
            col_Status.Name = "col_Status";
            col_Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            col_Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            col_Status.Width = 91;
            // 
            // bAIDDataGridViewTextBoxColumn
            // 
            bAIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            bAIDDataGridViewTextBoxColumn.DataPropertyName = "BA_ID";
            bAIDDataGridViewTextBoxColumn.HeaderText = "BA_ID";
            bAIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            bAIDDataGridViewTextBoxColumn.Name = "bAIDDataGridViewTextBoxColumn";
            bAIDDataGridViewTextBoxColumn.ReadOnly = true;
            bAIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            bAIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bNIDDataGridViewTextBoxColumn
            // 
            bNIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            bNIDDataGridViewTextBoxColumn.DataPropertyName = "BN_ID";
            bNIDDataGridViewTextBoxColumn.HeaderText = "BN_ID";
            bNIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            bNIDDataGridViewTextBoxColumn.Name = "bNIDDataGridViewTextBoxColumn";
            bNIDDataGridViewTextBoxColumn.ReadOnly = true;
            bNIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            bNIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            patientNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            patientNameDataGridViewTextBoxColumn.HeaderText = "Ho Ten";
            patientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            patientNameDataGridViewTextBoxColumn.ReadOnly = true;
            patientNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // patientSexDataGridViewTextBoxColumn
            // 
            patientSexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            patientSexDataGridViewTextBoxColumn.DataPropertyName = "PatientSex";
            patientSexDataGridViewTextBoxColumn.HeaderText = "Gioi Tinh";
            patientSexDataGridViewTextBoxColumn.MinimumWidth = 6;
            patientSexDataGridViewTextBoxColumn.Name = "patientSexDataGridViewTextBoxColumn";
            patientSexDataGridViewTextBoxColumn.ReadOnly = true;
            patientSexDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // patientDoBDataGridViewTextBoxColumn
            // 
            patientDoBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            patientDoBDataGridViewTextBoxColumn.DataPropertyName = "PatientDoB";
            patientDoBDataGridViewTextBoxColumn.HeaderText = "Ngay Sinh";
            patientDoBDataGridViewTextBoxColumn.MinimumWidth = 6;
            patientDoBDataGridViewTextBoxColumn.Name = "patientDoBDataGridViewTextBoxColumn";
            patientDoBDataGridViewTextBoxColumn.ReadOnly = true;
            patientDoBDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // recordNameDataGridViewTextBoxColumn
            // 
            recordNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            recordNameDataGridViewTextBoxColumn.DataPropertyName = "RecordName";
            recordNameDataGridViewTextBoxColumn.HeaderText = "Ten Benh An";
            recordNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            recordNameDataGridViewTextBoxColumn.Name = "recordNameDataGridViewTextBoxColumn";
            recordNameDataGridViewTextBoxColumn.ReadOnly = true;
            recordNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // checkInDataGridViewTextBoxColumn
            // 
            checkInDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            checkInDataGridViewTextBoxColumn.DataPropertyName = "CheckIn";
            checkInDataGridViewTextBoxColumn.HeaderText = "Ngay Kham";
            checkInDataGridViewTextBoxColumn.MinimumWidth = 6;
            checkInDataGridViewTextBoxColumn.Name = "checkInDataGridViewTextBoxColumn";
            checkInDataGridViewTextBoxColumn.ReadOnly = true;
            checkInDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Medical
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1152, 1102);
            Controls.Add(guna2Panel1);
            Controls.Add(dgvRecords);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Medical";
            Text = "Medical";
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientRecordBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientRecordBindingSource).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)patientRecordBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientRecordBindingSource2).EndInit();
            ResumeLayout(false);
        }

        private void UC_PlaceHolderTextBox_Search_TextChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvRecords;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label numOfRecords;
        private System.Windows.Forms.Label recordCount;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2ComboBox cbAccept;
        private System.Windows.Forms.Label sortRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientRecordBindingSource;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_Search;
        private System.Windows.Forms.BindingSource patientRecordBindingSource2;
        private System.Windows.Forms.BindingSource patientRecordBindingSource1;
        private System.Windows.Forms.BindingSource patientRecordBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn col_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDoBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
    }
}