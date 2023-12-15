namespace Hospital.Views.Login
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShapesTool1 = new Guna.UI2.WinForms.Guna2ShapesTool(components);
            bluelayout = new Guna.UI2.WinForms.Guna2Panel();
            doctor_login_img = new Guna.UI2.WinForms.Guna2Panel();
            password = new Guna.UI2.WinForms.Guna2TextBox();
            username = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            ForgotPassword = new System.Windows.Forms.LinkLabel();
            Doctor_Login = new System.Windows.Forms.Label();
            rememberme = new System.Windows.Forms.Label();
            Sign_In = new Guna.UI2.WinForms.Guna2Button();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            bluelayout.SuspendLayout();
            doctor_login_img.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // guna2ShapesTool1
            // 
            guna2ShapesTool1.Location = new System.Drawing.Point(0, 0);
            guna2ShapesTool1.PolygonSkip = 1;
            guna2ShapesTool1.Rotate = 0F;
            guna2ShapesTool1.RoundedEdges = customizableEdges14;
            guna2ShapesTool1.Size = new System.Drawing.Size(200, 200);
            guna2ShapesTool1.TargetControl = null;
            // 
            // bluelayout
            // 
            bluelayout.BackColor = System.Drawing.Color.Azure;
            bluelayout.Controls.Add(doctor_login_img);
            bluelayout.CustomizableEdges = customizableEdges24;
            bluelayout.Dock = System.Windows.Forms.DockStyle.Fill;
            bluelayout.Location = new System.Drawing.Point(0, 0);
            bluelayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            bluelayout.Name = "bluelayout";
            bluelayout.ShadowDecoration.CustomizableEdges = customizableEdges25;
            bluelayout.Size = new System.Drawing.Size(1099, 881);
            bluelayout.TabIndex = 0;
            // 
            // doctor_login_img
            // 
            doctor_login_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            doctor_login_img.BackgroundImage = (System.Drawing.Image)resources.GetObject("doctor_login_img.BackgroundImage");
            doctor_login_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            doctor_login_img.Controls.Add(password);
            doctor_login_img.Controls.Add(username);
            doctor_login_img.Controls.Add(guna2ToggleSwitch1);
            doctor_login_img.Controls.Add(ForgotPassword);
            doctor_login_img.Controls.Add(Doctor_Login);
            doctor_login_img.Controls.Add(rememberme);
            doctor_login_img.Controls.Add(Sign_In);
            doctor_login_img.CustomizableEdges = customizableEdges22;
            doctor_login_img.Location = new System.Drawing.Point(22, 0);
            doctor_login_img.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            doctor_login_img.Name = "doctor_login_img";
            doctor_login_img.ShadowDecoration.CustomizableEdges = customizableEdges23;
            doctor_login_img.Size = new System.Drawing.Size(1041, 836);
            doctor_login_img.TabIndex = 0;
            doctor_login_img.Paint += doctor_login_img_Paint;
            // 
            // password
            // 
            password.BorderColor = System.Drawing.Color.Red;
            password.Cursor = System.Windows.Forms.Cursors.IBeam;
            password.CustomizableEdges = customizableEdges1;
            password.DefaultText = "";
            password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            password.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            password.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            password.Location = new System.Drawing.Point(442, 548);
            password.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            password.Name = "password";
            password.PasswordChar = '●';
            password.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            password.PlaceholderText = "Enter password";
            password.SelectedText = "";
            password.ShadowDecoration.CustomizableEdges = customizableEdges15;
            password.Size = new System.Drawing.Size(307, 60);
            password.TabIndex = 9;
            password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            username.BorderColor = System.Drawing.Color.Red;
            username.Cursor = System.Windows.Forms.Cursors.IBeam;
            username.CustomizableEdges = customizableEdges16;
            username.DefaultText = "";
            username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            username.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            username.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            username.Location = new System.Drawing.Point(442, 462);
            username.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            username.Name = "username";
            username.PasswordChar = '\0';
            username.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            username.PlaceholderText = "Enter username";
            username.SelectedText = "";
            username.ShadowDecoration.CustomizableEdges = customizableEdges17;
            username.Size = new System.Drawing.Size(307, 60);
            username.TabIndex = 8;
            // 
            // guna2ToggleSwitch1
            // 
            guna2ToggleSwitch1.BackColor = System.Drawing.Color.Transparent;
            guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
            guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            guna2ToggleSwitch1.CustomizableEdges = customizableEdges18;
            guna2ToggleSwitch1.Location = new System.Drawing.Point(442, 636);
            guna2ToggleSwitch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            guna2ToggleSwitch1.ShadowDecoration.CustomizableEdges = customizableEdges19;
            guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 25);
            guna2ToggleSwitch1.TabIndex = 7;
            guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(125, 137, 149);
            guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(125, 137, 149);
            guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // ForgotPassword
            // 
            ForgotPassword.ActiveLinkColor = System.Drawing.Color.White;
            ForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            ForgotPassword.AutoSize = true;
            ForgotPassword.BackColor = System.Drawing.Color.Transparent;
            ForgotPassword.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ForgotPassword.LinkColor = System.Drawing.Color.Black;
            ForgotPassword.Location = new System.Drawing.Point(612, 636);
            ForgotPassword.Name = "ForgotPassword";
            ForgotPassword.Size = new System.Drawing.Size(137, 27);
            ForgotPassword.TabIndex = 6;
            ForgotPassword.TabStop = true;
            ForgotPassword.Text = "Forgot Password?";
            // 
            // Doctor_Login
            // 
            Doctor_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            Doctor_Login.AutoSize = true;
            Doctor_Login.BackColor = System.Drawing.Color.Transparent;
            Doctor_Login.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Doctor_Login.Location = new System.Drawing.Point(469, 388);
            Doctor_Login.Name = "Doctor_Login";
            Doctor_Login.Size = new System.Drawing.Size(242, 41);
            Doctor_Login.TabIndex = 5;
            Doctor_Login.Text = "DOCTOR LOGIN";
            // 
            // rememberme
            // 
            rememberme.Anchor = System.Windows.Forms.AnchorStyles.None;
            rememberme.AutoSize = true;
            rememberme.BackColor = System.Drawing.Color.Transparent;
            rememberme.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rememberme.Location = new System.Drawing.Point(483, 636);
            rememberme.Name = "rememberme";
            rememberme.Size = new System.Drawing.Size(115, 27);
            rememberme.TabIndex = 4;
            rememberme.Text = "Remember me";
            // 
            // Sign_In
            // 
            Sign_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            Sign_In.CustomizableEdges = customizableEdges20;
            Sign_In.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            Sign_In.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            Sign_In.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            Sign_In.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            Sign_In.FillColor = System.Drawing.Color.FromArgb(0, 0, 192);
            Sign_In.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Sign_In.ForeColor = System.Drawing.Color.White;
            Sign_In.Location = new System.Drawing.Point(501, 698);
            Sign_In.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Sign_In.Name = "Sign_In";
            Sign_In.ShadowDecoration.CustomizableEdges = customizableEdges21;
            Sign_In.Size = new System.Drawing.Size(180, 56);
            Sign_In.TabIndex = 2;
            Sign_In.Text = "Sign In";
            Sign_In.Click += Sign_In_Click;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkRate = 0;
            errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 881);
            Controls.Add(bluelayout);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            bluelayout.ResumeLayout(false);
            doctor_login_img.ResumeLayout(false);
            doctor_login_img.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShapesTool guna2ShapesTool1;
        private Guna.UI2.WinForms.Guna2Panel bluelayout;
        private Guna.UI2.WinForms.Guna2Panel doctor_login_img;
        private Guna.UI2.WinForms.Guna2Button Sign_In;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.Label rememberme;
        private System.Windows.Forms.Label Doctor_Login;
        private System.Windows.Forms.LinkLabel ForgotPassword;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

