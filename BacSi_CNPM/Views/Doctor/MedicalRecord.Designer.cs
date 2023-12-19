namespace Hospital.Views.Doctor
{
    partial class MedicalRecord
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Checkin = new System.Windows.Forms.Label();
            Telephone = new System.Windows.Forms.Label();
            PatientName = new System.Windows.Forms.Label();
            Height = new System.Windows.Forms.Label();
            Weight = new System.Windows.Forms.Label();
            DoB = new System.Windows.Forms.Label();
            Sex = new System.Windows.Forms.Label();
            BloodType = new System.Windows.Forms.Label();
            Address = new System.Windows.Forms.Label();
            Symtomp = new System.Windows.Forms.Label();
            Department = new System.Windows.Forms.Label();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            panel_registerForm = new Guna.UI2.WinForms.Guna2ShadowPanel();
            Prescription = new System.Windows.Forms.Label();
            Medicines = new System.Windows.Forms.DataGridView();
            Doctor = new System.Windows.Forms.Label();
            MedicalHis = new System.Windows.Forms.Label();
            RecordName = new System.Windows.Forms.Label();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            thuocDOCBindingSource = new System.Windows.Forms.BindingSource(components);
            tHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            buoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel_registerForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Medicines).BeginInit();
            guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)thuocDOCBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Checkin
            // 
            Checkin.AutoSize = true;
            Checkin.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            Checkin.Location = new System.Drawing.Point(450, 476);
            Checkin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Checkin.Name = "Checkin";
            Checkin.Size = new System.Drawing.Size(86, 23);
            Checkin.TabIndex = 4;
            Checkin.Text = "Check-in :";
            // 
            // Telephone
            // 
            Telephone.AutoSize = true;
            Telephone.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            Telephone.Location = new System.Drawing.Point(450, 216);
            Telephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Telephone.Name = "Telephone";
            Telephone.Size = new System.Drawing.Size(97, 23);
            Telephone.TabIndex = 1;
            Telephone.Text = "Telephone :";
            // 
            // PatientName
            // 
            PatientName.AutoSize = true;
            PatientName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            PatientName.Location = new System.Drawing.Point(55, 90);
            PatientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PatientName.Name = "PatientName";
            PatientName.Size = new System.Drawing.Size(65, 23);
            PatientName.TabIndex = 8;
            PatientName.Text = "Name :";
            // 
            // Height
            // 
            Height.AutoSize = true;
            Height.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            Height.Location = new System.Drawing.Point(55, 288);
            Height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Height.Name = "Height";
            Height.Size = new System.Drawing.Size(65, 23);
            Height.TabIndex = 13;
            Height.Text = "Height:";
            // 
            // Weight
            // 
            Weight.AutoSize = true;
            Weight.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            Weight.Location = new System.Drawing.Point(410, 288);
            Weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Weight.Name = "Weight";
            Weight.Size = new System.Drawing.Size(68, 23);
            Weight.TabIndex = 15;
            Weight.Text = "Weight:";
            // 
            // DoB
            // 
            DoB.AutoSize = true;
            DoB.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            DoB.Location = new System.Drawing.Point(55, 154);
            DoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DoB.Name = "DoB";
            DoB.Size = new System.Drawing.Size(116, 23);
            DoB.TabIndex = 17;
            DoB.Text = "Date of Birth :";
            // 
            // Sex
            // 
            Sex.AutoSize = true;
            Sex.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            Sex.Location = new System.Drawing.Point(450, 90);
            Sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Sex.Name = "Sex";
            Sex.Size = new System.Drawing.Size(45, 23);
            Sex.TabIndex = 19;
            Sex.Text = "Sex :";
            // 
            // BloodType
            // 
            BloodType.AutoSize = true;
            BloodType.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            BloodType.Location = new System.Drawing.Point(710, 288);
            BloodType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            BloodType.Name = "BloodType";
            BloodType.Size = new System.Drawing.Size(94, 23);
            BloodType.TabIndex = 21;
            BloodType.Text = "Blood Type";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            Address.Location = new System.Drawing.Point(55, 216);
            Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Address.Name = "Address";
            Address.Size = new System.Drawing.Size(79, 23);
            Address.TabIndex = 23;
            Address.Text = "Address: ";
            // 
            // Symtomp
            // 
            Symtomp.AutoSize = true;
            Symtomp.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            Symtomp.Location = new System.Drawing.Point(55, 560);
            Symtomp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Symtomp.Name = "Symtomp";
            Symtomp.Size = new System.Drawing.Size(92, 23);
            Symtomp.TabIndex = 28;
            Symtomp.Text = "Symtomp :";
            // 
            // Department
            // 
            Department.AutoSize = true;
            Department.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            Department.Location = new System.Drawing.Point(450, 394);
            Department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Department.Name = "Department";
            Department.Size = new System.Drawing.Size(111, 23);
            Department.TabIndex = 44;
            Department.Text = "Department :";
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // panel_registerForm
            // 
            panel_registerForm.BackColor = System.Drawing.Color.Transparent;
            panel_registerForm.Controls.Add(Prescription);
            panel_registerForm.Controls.Add(Medicines);
            panel_registerForm.Controls.Add(Doctor);
            panel_registerForm.Controls.Add(MedicalHis);
            panel_registerForm.Controls.Add(RecordName);
            panel_registerForm.Controls.Add(guna2ShadowPanel1);
            panel_registerForm.Controls.Add(label3);
            panel_registerForm.Controls.Add(Checkin);
            panel_registerForm.Controls.Add(label2);
            panel_registerForm.Controls.Add(PatientName);
            panel_registerForm.Controls.Add(Symtomp);
            panel_registerForm.Controls.Add(Department);
            panel_registerForm.Controls.Add(Telephone);
            panel_registerForm.Controls.Add(Sex);
            panel_registerForm.Controls.Add(DoB);
            panel_registerForm.Controls.Add(BloodType);
            panel_registerForm.Controls.Add(Address);
            panel_registerForm.Controls.Add(Height);
            panel_registerForm.Controls.Add(Weight);
            panel_registerForm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_registerForm.FillColor = System.Drawing.Color.White;
            panel_registerForm.Location = new System.Drawing.Point(0, 0);
            panel_registerForm.Margin = new System.Windows.Forms.Padding(4);
            panel_registerForm.Name = "panel_registerForm";
            panel_registerForm.Radius = 10;
            panel_registerForm.ShadowColor = System.Drawing.Color.Black;
            panel_registerForm.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            panel_registerForm.Size = new System.Drawing.Size(900, 1055);
            panel_registerForm.TabIndex = 50;
            // 
            // Prescription
            // 
            Prescription.AutoSize = true;
            Prescription.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            Prescription.Location = new System.Drawing.Point(55, 822);
            Prescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Prescription.Name = "Prescription";
            Prescription.Size = new System.Drawing.Size(109, 23);
            Prescription.TabIndex = 60;
            Prescription.Text = "Prescription :";
            // 
            // Medicines
            // 
            Medicines.AutoGenerateColumns = false;
            Medicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Medicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { tHIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, buoiDataGridViewTextBoxColumn });
            Medicines.DataSource = thuocDOCBindingSource;
            Medicines.Location = new System.Drawing.Point(55, 848);
            Medicines.Name = "Medicines";
            Medicines.RowHeadersWidth = 51;
            Medicines.RowTemplate.Height = 29;
            Medicines.Size = new System.Drawing.Size(793, 111);
            Medicines.TabIndex = 59;
            // 
            // Doctor
            // 
            Doctor.AutoSize = true;
            Doctor.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            Doctor.Location = new System.Drawing.Point(55, 476);
            Doctor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Doctor.Name = "Doctor";
            Doctor.Size = new System.Drawing.Size(71, 23);
            Doctor.TabIndex = 58;
            Doctor.Text = "Doctor :";
            // 
            // MedicalHis
            // 
            MedicalHis.AutoSize = true;
            MedicalHis.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            MedicalHis.Location = new System.Drawing.Point(55, 681);
            MedicalHis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MedicalHis.Name = "MedicalHis";
            MedicalHis.Size = new System.Drawing.Size(136, 23);
            MedicalHis.TabIndex = 56;
            MedicalHis.Text = "Medical History :";
            // 
            // RecordName
            // 
            RecordName.AutoSize = true;
            RecordName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            RecordName.Location = new System.Drawing.Point(55, 394);
            RecordName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            RecordName.Name = "RecordName";
            RecordName.Size = new System.Drawing.Size(123, 23);
            RecordName.TabIndex = 55;
            RecordName.Text = "Record Name :";
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            guna2ShadowPanel1.Controls.Add(guna2ControlBox2);
            guna2ShadowPanel1.Controls.Add(guna2ControlBox1);
            guna2ShadowPanel1.Controls.Add(label5);
            guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            guna2ShadowPanel1.ShadowShift = 2;
            guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            guna2ShadowPanel1.Size = new System.Drawing.Size(900, 62);
            guna2ShadowPanel1.TabIndex = 54;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox2.CustomizableEdges = customizableEdges5;
            guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(139, 152, 166);
            guna2ControlBox2.IconColor = System.Drawing.Color.White;
            guna2ControlBox2.Location = new System.Drawing.Point(792, 0);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox2.Size = new System.Drawing.Size(56, 36);
            guna2ControlBox2.TabIndex = 54;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges7;
            guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = System.Drawing.Color.White;
            guna2ControlBox1.Location = new System.Drawing.Point(844, 0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2ControlBox1.Size = new System.Drawing.Size(56, 36);
            guna2ControlBox1.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(13, 14);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(175, 31);
            label5.TabIndex = 52;
            label5.Text = "Medical Record";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(527, 288);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(28, 23);
            label3.TabIndex = 51;
            label3.Text = "kg";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(172, 288);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 23);
            label2.TabIndex = 50;
            label2.Text = "cm";
            // 
            // thuocDOCBindingSource
            // 
            thuocDOCBindingSource.DataSource = typeof(DTO.ThuocDOC);
            // 
            // tHIDDataGridViewTextBoxColumn
            // 
            tHIDDataGridViewTextBoxColumn.DataPropertyName = "TH_ID";
            tHIDDataGridViewTextBoxColumn.HeaderText = "TH_ID";
            tHIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            tHIDDataGridViewTextBoxColumn.Name = "tHIDDataGridViewTextBoxColumn";
            tHIDDataGridViewTextBoxColumn.ReadOnly = true;
            tHIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            tHIDDataGridViewTextBoxColumn.Visible = false;
            tHIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Ten Thuoc";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "So Luong";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buoiDataGridViewTextBoxColumn
            // 
            buoiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            buoiDataGridViewTextBoxColumn.DataPropertyName = "Buoi";
            buoiDataGridViewTextBoxColumn.HeaderText = "Buoi";
            buoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            buoiDataGridViewTextBoxColumn.Name = "buoiDataGridViewTextBoxColumn";
            buoiDataGridViewTextBoxColumn.ReadOnly = true;
            buoiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MedicalRecord
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 1055);
            Controls.Add(panel_registerForm);
            Font = new System.Drawing.Font("Segoe UI", 10.2F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "MedicalRecord";
            RightToLeftLayout = true;
            Text = "PatientDetail";
            Load += PatientDetail_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel_registerForm.ResumeLayout(false);
            panel_registerForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Medicines).EndInit();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)thuocDOCBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label Checkin;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label DoB;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label BloodType;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Symtomp;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_BloodType;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_Sex;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_registerForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label RecordName;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label MedicalHis;
        private System.Windows.Forms.Label Doctor;
        private System.Windows.Forms.DataGridView Medicines;
        private System.Windows.Forms.Label Prescription;
        private System.Windows.Forms.BindingSource thuocDOCBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buoiDataGridViewTextBoxColumn;
    }
}