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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medical));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvRecords = new Guna.UI2.WinForms.Guna2DataGridView();
            bAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patientSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patientDoBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            recordNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            checkInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patientRecordBindingSource3 = new System.Windows.Forms.BindingSource(components);
            patientRecordBindingSource = new System.Windows.Forms.BindingSource(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2TextBox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            numOfRecords = new System.Windows.Forms.Label();
            recordCount = new System.Windows.Forms.Label();
            patientRecordBindingSource1 = new System.Windows.Forms.BindingSource(components);
            patientRecordBindingSource2 = new System.Windows.Forms.BindingSource(components);
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
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.AllowUserToOrderColumns = true;
            dgvRecords.AllowUserToResizeColumns = false;
            dgvRecords.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dgvRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecords.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRecords.ColumnHeadersHeight = 47;
            dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { bAIDDataGridViewTextBoxColumn, bNIDDataGridViewTextBoxColumn, patientNameDataGridViewTextBoxColumn, patientSexDataGridViewTextBoxColumn, patientDoBDataGridViewTextBoxColumn, recordNameDataGridViewTextBoxColumn, checkInDataGridViewTextBoxColumn });
            dgvRecords.DataSource = patientRecordBindingSource3;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvRecords.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRecords.GridColor = System.Drawing.Color.FromArgb(245, 245, 250);
            dgvRecords.Location = new System.Drawing.Point(12, 120);
            dgvRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvRecords.MultiSelect = false;
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
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
            dgvRecords.Size = new System.Drawing.Size(1128, 736);
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
            dgvRecords.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dgvRecords.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            dgvRecords.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvRecords.ThemeStyle.HeaderStyle.Height = 47;
            dgvRecords.ThemeStyle.ReadOnly = true;
            dgvRecords.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dgvRecords.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecords.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dgvRecords.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dgvRecords.ThemeStyle.RowsStyle.Height = 50;
            dgvRecords.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            dgvRecords.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvRecords.CellClick += dgvRecords_CellClick;
            dgvRecords.CellDoubleClick += dgvRecords_CellDoubleClick;
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
            patientNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            patientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            patientNameDataGridViewTextBoxColumn.ReadOnly = true;
            patientNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // patientSexDataGridViewTextBoxColumn
            // 
            patientSexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            patientSexDataGridViewTextBoxColumn.DataPropertyName = "PatientSex";
            patientSexDataGridViewTextBoxColumn.HeaderText = "Sex";
            patientSexDataGridViewTextBoxColumn.MinimumWidth = 6;
            patientSexDataGridViewTextBoxColumn.Name = "patientSexDataGridViewTextBoxColumn";
            patientSexDataGridViewTextBoxColumn.ReadOnly = true;
            patientSexDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // patientDoBDataGridViewTextBoxColumn
            // 
            patientDoBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            patientDoBDataGridViewTextBoxColumn.DataPropertyName = "PatientDoB";
            patientDoBDataGridViewTextBoxColumn.HeaderText = "Date of birth";
            patientDoBDataGridViewTextBoxColumn.MinimumWidth = 6;
            patientDoBDataGridViewTextBoxColumn.Name = "patientDoBDataGridViewTextBoxColumn";
            patientDoBDataGridViewTextBoxColumn.ReadOnly = true;
            patientDoBDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // recordNameDataGridViewTextBoxColumn
            // 
            recordNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            recordNameDataGridViewTextBoxColumn.DataPropertyName = "RecordName";
            recordNameDataGridViewTextBoxColumn.HeaderText = "Record's Name";
            recordNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            recordNameDataGridViewTextBoxColumn.Name = "recordNameDataGridViewTextBoxColumn";
            recordNameDataGridViewTextBoxColumn.ReadOnly = true;
            recordNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // checkInDataGridViewTextBoxColumn
            // 
            checkInDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            checkInDataGridViewTextBoxColumn.DataPropertyName = "CheckIn";
            checkInDataGridViewTextBoxColumn.HeaderText = "Examine Date";
            checkInDataGridViewTextBoxColumn.MinimumWidth = 6;
            checkInDataGridViewTextBoxColumn.Name = "checkInDataGridViewTextBoxColumn";
            checkInDataGridViewTextBoxColumn.ReadOnly = true;
            checkInDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // patientRecordBindingSource3
            // 
            patientRecordBindingSource3.DataSource = typeof(DTO.PatientRecord);
            // 
            // patientRecordBindingSource
            // 
            patientRecordBindingSource.DataSource = typeof(DTO.PatientRecord);
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(guna2TextBox_Search);
            guna2Panel1.Controls.Add(numOfRecords);
            guna2Panel1.Controls.Add(recordCount);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            guna2Panel1.Location = new System.Drawing.Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new System.Drawing.Size(1152, 113);
            guna2Panel1.TabIndex = 4;
            // 
            // guna2TextBox_Search
            // 
            guna2TextBox_Search.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            guna2TextBox_Search.BorderRadius = 20;
            guna2TextBox_Search.CustomizableEdges = customizableEdges1;
            guna2TextBox_Search.DefaultText = "";
            guna2TextBox_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            guna2TextBox_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            guna2TextBox_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            guna2TextBox_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            guna2TextBox_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            guna2TextBox_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            guna2TextBox_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            guna2TextBox_Search.IconLeft = (System.Drawing.Image)resources.GetObject("guna2TextBox_Search.IconLeft");
            guna2TextBox_Search.IconLeftSize = new System.Drawing.Size(24, 24);
            guna2TextBox_Search.Location = new System.Drawing.Point(241, 41);
            guna2TextBox_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            guna2TextBox_Search.Name = "guna2TextBox_Search";
            guna2TextBox_Search.PasswordChar = '\0';
            guna2TextBox_Search.PlaceholderText = "Search...";
            guna2TextBox_Search.SelectedText = "";
            guna2TextBox_Search.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox_Search.Size = new System.Drawing.Size(515, 44);
            guna2TextBox_Search.TabIndex = 8;
            guna2TextBox_Search.TextOffset = new System.Drawing.Point(10, 0);
            guna2TextBox_Search.TextChanged += guna2TextBox_Search_TextChanged;
            // 
            // numOfRecords
            // 
            numOfRecords.AutoSize = true;
            numOfRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            numOfRecords.Location = new System.Drawing.Point(110, 48);
            numOfRecords.Name = "numOfRecords";
            numOfRecords.Size = new System.Drawing.Size(81, 28);
            numOfRecords.TabIndex = 3;
            numOfRecords.Text = "Records";
            // 
            // recordCount
            // 
            recordCount.AutoSize = true;
            recordCount.Font = new System.Drawing.Font("Segoe UI", 31.8000011F, System.Drawing.FontStyle.Bold);
            recordCount.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            recordCount.Location = new System.Drawing.Point(12, 20);
            recordCount.Name = "recordCount";
            recordCount.Size = new System.Drawing.Size(92, 72);
            recordCount.TabIndex = 2;
            recordCount.Text = "20";
            // 
            // patientRecordBindingSource1
            // 
            patientRecordBindingSource1.DataSource = typeof(DTO.PatientRecord);
            // 
            // patientRecordBindingSource2
            // 
            patientRecordBindingSource2.DataSource = typeof(DTO.PatientRecord);
            // 
            // Medical
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1152, 919);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientRecordBindingSource;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_Search;
        private System.Windows.Forms.BindingSource patientRecordBindingSource2;
        private System.Windows.Forms.BindingSource patientRecordBindingSource1;
        private System.Windows.Forms.BindingSource patientRecordBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDoBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
    }
}