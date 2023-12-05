namespace Hospital.Views.Pharmacist
{
    partial class Prescription
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescription));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1_searchPatients = new Guna.UI2.WinForms.Guna2Panel();
            dtgv_searchPatients = new Guna.UI2.WinForms.Guna2DataGridView();
            patient_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patient_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patient_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            search_patient = new Guna.UI2.WinForms.Guna2TextBox();
            containerPrescription = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1_searchPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_searchPatients).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1_searchPatients
            // 
            guna2Panel1_searchPatients.Controls.Add(dtgv_searchPatients);
            guna2Panel1_searchPatients.Controls.Add(search_patient);
            guna2Panel1_searchPatients.CustomizableEdges = customizableEdges3;
            guna2Panel1_searchPatients.Dock = System.Windows.Forms.DockStyle.Left;
            guna2Panel1_searchPatients.Location = new System.Drawing.Point(0, 0);
            guna2Panel1_searchPatients.Name = "guna2Panel1_searchPatients";
            guna2Panel1_searchPatients.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1_searchPatients.Size = new System.Drawing.Size(617, 793);
            guna2Panel1_searchPatients.TabIndex = 0;
            guna2Panel1_searchPatients.Paint += guna2Panel1_searchPatients_Paint;
            // 
            // dtgv_searchPatients
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dtgv_searchPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_searchPatients.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_searchPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_searchPatients.ColumnHeadersHeight = 22;
            dtgv_searchPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_searchPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { patient_ID, patient_name, patient_age });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_searchPatients.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_searchPatients.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_searchPatients.Location = new System.Drawing.Point(24, 110);
            dtgv_searchPatients.Name = "dtgv_searchPatients";
            dtgv_searchPatients.RowHeadersVisible = false;
            dtgv_searchPatients.RowHeadersWidth = 51;
            dtgv_searchPatients.RowTemplate.Height = 29;
            dtgv_searchPatients.Size = new System.Drawing.Size(569, 671);
            dtgv_searchPatients.TabIndex = 4;
            dtgv_searchPatients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_searchPatients.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_searchPatients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_searchPatients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_searchPatients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_searchPatients.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_searchPatients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_searchPatients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_searchPatients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_searchPatients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_searchPatients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dtgv_searchPatients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_searchPatients.ThemeStyle.HeaderStyle.Height = 22;
            dtgv_searchPatients.ThemeStyle.ReadOnly = false;
            dtgv_searchPatients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_searchPatients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_searchPatients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtgv_searchPatients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_searchPatients.ThemeStyle.RowsStyle.Height = 29;
            dtgv_searchPatients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_searchPatients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dtgv_searchPatients.CellContentClick += dtgv_seachPatients_CellContentClick;
            dtgv_searchPatients.CellDoubleClick += dtgv_searchPatients_CellDoubleClick;
            // 
            // patient_ID
            // 
            patient_ID.HeaderText = "ID";
            patient_ID.MinimumWidth = 6;
            patient_ID.Name = "patient_ID";
            // 
            // patient_name
            // 
            patient_name.HeaderText = "Name";
            patient_name.MinimumWidth = 6;
            patient_name.Name = "patient_name";
            // 
            // patient_age
            // 
            patient_age.HeaderText = "Age";
            patient_age.MinimumWidth = 6;
            patient_age.Name = "patient_age";
            // 
            // search_patient
            // 
            search_patient.CustomizableEdges = customizableEdges1;
            search_patient.DefaultText = "Search Patients";
            search_patient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            search_patient.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            search_patient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            search_patient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            search_patient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            search_patient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            search_patient.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            search_patient.IconLeft = (System.Drawing.Image)resources.GetObject("search_patient.IconLeft");
            search_patient.IconLeftSize = new System.Drawing.Size(32, 32);
            search_patient.Location = new System.Drawing.Point(24, 36);
            search_patient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            search_patient.Name = "search_patient";
            search_patient.PasswordChar = '\0';
            search_patient.PlaceholderText = "";
            search_patient.SelectedText = "";
            search_patient.ShadowDecoration.CustomizableEdges = customizableEdges2;
            search_patient.Size = new System.Drawing.Size(286, 41);
            search_patient.TabIndex = 3;
            // 
            // containerPrescription
            // 
            containerPrescription.CustomizableEdges = customizableEdges5;
            containerPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            containerPrescription.Location = new System.Drawing.Point(617, 0);
            containerPrescription.Name = "containerPrescription";
            containerPrescription.ShadowDecoration.CustomizableEdges = customizableEdges6;
            containerPrescription.Size = new System.Drawing.Size(499, 793);
            containerPrescription.TabIndex = 1;
            containerPrescription.Paint += containerPrescription_Paint;
            // 
            // Prescription
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1116, 793);
            Controls.Add(containerPrescription);
            Controls.Add(guna2Panel1_searchPatients);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Prescription";
            Text = "Prescription";
            Load += Prescription_Load;
            guna2Panel1_searchPatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_searchPatients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1_searchPatients;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_searchPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_age;
        private Guna.UI2.WinForms.Guna2TextBox search_patient;
        private Guna.UI2.WinForms.Guna2Panel containerPrescription;
    }
}