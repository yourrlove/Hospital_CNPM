namespace Hospital.Views.Pharmacist
{
    partial class PharmacistPrescription
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            panel_container = new Guna.UI2.WinForms.Guna2Panel();
            text_val = new System.Windows.Forms.Label();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            default_panel = new Guna.UI2.WinForms.Guna2Panel();
            dtgv_SearchMedicine = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            default_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_SearchMedicine).BeginInit();
            SuspendLayout();
            // 
            // panel_container
            // 
            panel_container.BackColor = System.Drawing.Color.White;
            panel_container.CustomizableEdges = customizableEdges1;
            panel_container.Dock = System.Windows.Forms.DockStyle.Left;
            panel_container.Location = new System.Drawing.Point(0, 0);
            panel_container.Name = "panel_container";
            panel_container.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panel_container.Size = new System.Drawing.Size(844, 887);
            panel_container.TabIndex = 0;
            panel_container.Paint += guna2Panel1_Paint;
            // 
            // text_val
            // 
            text_val.AutoSize = true;
            text_val.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            text_val.Location = new System.Drawing.Point(25, 28);
            text_val.Name = "text_val";
            text_val.Size = new System.Drawing.Size(66, 28);
            text_val.TabIndex = 17;
            text_val.Text = "Patient";
            text_val.Click += text_val_Click;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 50;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new System.Drawing.Point(25, 79);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 50;
            guna2DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            guna2DataGridView1.Size = new System.Drawing.Size(259, 722);
            guna2DataGridView1.TabIndex = 6;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 50;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 50;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            guna2DataGridView1.CellDoubleClick += guna2DataGridView1_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // default_panel
            // 
            default_panel.BackColor = System.Drawing.Color.White;
            default_panel.Controls.Add(text_val);
            default_panel.Controls.Add(dtgv_SearchMedicine);
            default_panel.Controls.Add(guna2DataGridView1);
            default_panel.CustomizableEdges = customizableEdges3;
            default_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            default_panel.Location = new System.Drawing.Point(844, 0);
            default_panel.Name = "default_panel";
            default_panel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            default_panel.Size = new System.Drawing.Size(308, 887);
            default_panel.TabIndex = 1;
            // 
            // dtgv_SearchMedicine
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dtgv_SearchMedicine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_SearchMedicine.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtgv_SearchMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgv_SearchMedicine.ColumnHeadersHeight = 50;
            dtgv_SearchMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtgv_SearchMedicine.DefaultCellStyle = dataGridViewCellStyle6;
            dtgv_SearchMedicine.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_SearchMedicine.Location = new System.Drawing.Point(-425, 87);
            dtgv_SearchMedicine.Name = "dtgv_SearchMedicine";
            dtgv_SearchMedicine.RowHeadersVisible = false;
            dtgv_SearchMedicine.RowHeadersWidth = 51;
            dtgv_SearchMedicine.RowTemplate.Height = 50;
            dtgv_SearchMedicine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dtgv_SearchMedicine.Size = new System.Drawing.Size(0, 621);
            dtgv_SearchMedicine.TabIndex = 6;
            dtgv_SearchMedicine.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dtgv_SearchMedicine.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_SearchMedicine.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dtgv_SearchMedicine.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dtgv_SearchMedicine.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dtgv_SearchMedicine.ThemeStyle.BackColor = System.Drawing.Color.White;
            dtgv_SearchMedicine.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dtgv_SearchMedicine.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dtgv_SearchMedicine.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dtgv_SearchMedicine.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            // PharmacistPrescription
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            ClientSize = new System.Drawing.Size(1152, 887);
            Controls.Add(default_panel);
            Controls.Add(panel_container);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "PharmacistPrescription";
            Text = "Prescription";
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            default_panel.ResumeLayout(false);
            default_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_SearchMedicine).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_container;
        private Guna.UI2.WinForms.Guna2Panel default_panel;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_SearchMedicine;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label text_val;
    }
}