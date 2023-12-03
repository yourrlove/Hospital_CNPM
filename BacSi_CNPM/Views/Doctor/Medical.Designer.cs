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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medical));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvRecords = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_Status = new System.Windows.Forms.DataGridViewImageColumn();
            col_requestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_requestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_requestAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_requestBloodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_requestDescript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_requestAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            cbAccept = new Guna.UI2.WinForms.Guna2ComboBox();
            sortRequest = new System.Windows.Forms.Label();
            btnPrint = new Guna.UI2.WinForms.Guna2Button();
            numOfRecords = new System.Windows.Forms.Label();
            recordCount = new System.Windows.Forms.Label();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dgvRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, col_Status, col_requestID, col_requestName, col_requestAge, col_requestBloodType, col_requestDescript, col_requestAdd });
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
            // Column1
            // 
            Column1.FillWeight = 37.099514F;
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
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
            // col_requestID
            // 
            col_requestID.FillWeight = 107.106087F;
            col_requestID.HeaderText = "ID";
            col_requestID.MinimumWidth = 6;
            col_requestID.Name = "col_requestID";
            // 
            // col_requestName
            // 
            col_requestName.FillWeight = 142.8081F;
            col_requestName.HeaderText = "Name";
            col_requestName.MinimumWidth = 6;
            col_requestName.Name = "col_requestName";
            // 
            // col_requestAge
            // 
            col_requestAge.FillWeight = 63.41318F;
            col_requestAge.HeaderText = "Age";
            col_requestAge.MinimumWidth = 6;
            col_requestAge.Name = "col_requestAge";
            // 
            // col_requestBloodType
            // 
            col_requestBloodType.FillWeight = 62.6724129F;
            col_requestBloodType.HeaderText = "Blood Type";
            col_requestBloodType.MinimumWidth = 6;
            col_requestBloodType.Name = "col_requestBloodType";
            // 
            // col_requestDescript
            // 
            col_requestDescript.FillWeight = 149.954422F;
            col_requestDescript.HeaderText = "Description";
            col_requestDescript.MinimumWidth = 6;
            col_requestDescript.Name = "col_requestDescript";
            // 
            // col_requestAdd
            // 
            col_requestAdd.FillWeight = 106.732437F;
            col_requestAdd.HeaderText = "";
            col_requestAdd.MinimumWidth = 6;
            col_requestAdd.Name = "col_requestAdd";
            col_requestAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            col_requestAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            col_requestAdd.Text = "Add";
            col_requestAdd.UseColumnTextForButtonValue = true;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(guna2TextBox1);
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
            // guna2TextBox1
            // 
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "Search";
            guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconLeft = (System.Drawing.Image)resources.GetObject("guna2TextBox1.IconLeft");
            guna2TextBox1.IconLeftSize = new System.Drawing.Size(32, 32);
            guna2TextBox1.Location = new System.Drawing.Point(244, 37);
            guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new System.Drawing.Size(286, 60);
            guna2TextBox1.TabIndex = 8;
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
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn col_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_requestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_requestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_requestAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_requestBloodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_requestDescript;
        private System.Windows.Forms.DataGridViewButtonColumn col_requestAdd;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label numOfRecords;
        private System.Windows.Forms.Label recordCount;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2ComboBox cbAccept;
        private System.Windows.Forms.Label sortRequest;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}