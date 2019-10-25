namespace BecodingDesktop.Views.General
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.imgUtec = new System.Windows.Forms.PictureBox();
            this.imgBannerLogin = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleSignIn = new System.Windows.Forms.Label();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chkRememberCredential = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnSignIn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPowered = new System.Windows.Forms.Label();
            this.lblOrganization = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUtec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBannerLogin)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.imgLogo);
            this.flowLayoutPanel1.Controls.Add(this.imgUtec);
            this.flowLayoutPanel1.Controls.Add(this.imgBannerLogin);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(150, 30);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(140, 20, 3, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(100, 100);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // imgUtec
            // 
            this.imgUtec.Image = ((System.Drawing.Image)(resources.GetObject("imgUtec.Image")));
            this.imgUtec.Location = new System.Drawing.Point(60, 153);
            this.imgUtec.Margin = new System.Windows.Forms.Padding(50, 20, 3, 3);
            this.imgUtec.Name = "imgUtec";
            this.imgUtec.Size = new System.Drawing.Size(301, 57);
            this.imgUtec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUtec.TabIndex = 2;
            this.imgUtec.TabStop = false;
            // 
            // imgBannerLogin
            // 
            this.imgBannerLogin.Image = ((System.Drawing.Image)(resources.GetObject("imgBannerLogin.Image")));
            this.imgBannerLogin.Location = new System.Drawing.Point(10, 333);
            this.imgBannerLogin.Margin = new System.Windows.Forms.Padding(0, 120, 3, 3);
            this.imgBannerLogin.Name = "imgBannerLogin";
            this.imgBannerLogin.Size = new System.Drawing.Size(380, 100);
            this.imgBannerLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBannerLogin.TabIndex = 1;
            this.imgBannerLogin.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.lblTitleSignIn);
            this.flowLayoutPanel2.Controls.Add(this.txtEmail);
            this.flowLayoutPanel2.Controls.Add(this.txtPassword);
            this.flowLayoutPanel2.Controls.Add(this.chkRememberCredential);
            this.flowLayoutPanel2.Controls.Add(this.btnSignIn);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(401, 1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(400, 450);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // lblTitleSignIn
            // 
            this.lblTitleSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitleSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSignIn.Location = new System.Drawing.Point(5, 55);
            this.lblTitleSignIn.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.lblTitleSignIn.Name = "lblTitleSignIn";
            this.lblTitleSignIn.Size = new System.Drawing.Size(389, 31);
            this.lblTitleSignIn.TabIndex = 12;
            this.lblTitleSignIn.Text = "INICIAR SESIÓN";
            this.lblTitleSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "Ingresa tu correo institucional";
            this.txtEmail.Location = new System.Drawing.Point(5, 106);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(372, 23);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "Ingresa tu contraseña";
            this.txtPassword.Location = new System.Drawing.Point(5, 149);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(372, 23);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TabStop = false;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkRememberCredential
            // 
            this.chkRememberCredential.AutoSize = true;
            this.chkRememberCredential.Depth = 0;
            this.chkRememberCredential.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkRememberCredential.Location = new System.Drawing.Point(5, 192);
            this.chkRememberCredential.Margin = new System.Windows.Forms.Padding(0);
            this.chkRememberCredential.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkRememberCredential.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkRememberCredential.Name = "chkRememberCredential";
            this.chkRememberCredential.Ripple = true;
            this.chkRememberCredential.Size = new System.Drawing.Size(169, 30);
            this.chkRememberCredential.TabIndex = 8;
            this.chkRememberCredential.Text = "Recordar Credenciales";
            this.chkRememberCredential.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.AutoSize = true;
            this.btnSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignIn.Depth = 0;
            this.btnSignIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignIn.Icon = null;
            this.btnSignIn.Location = new System.Drawing.Point(5, 242);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(0, 20, 20, 3);
            this.btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Primary = true;
            this.btnSignIn.Size = new System.Drawing.Size(369, 36);
            this.btnSignIn.TabIndex = 9;
            this.btnSignIn.Text = "INICIAR";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lblPowered);
            this.flowLayoutPanel3.Controls.Add(this.lblOrganization);
            this.flowLayoutPanel3.Controls.Add(this.lblCopyright);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(5, 401);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 120, 0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(389, 43);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // lblPowered
            // 
            this.lblPowered.AutoSize = true;
            this.lblPowered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowered.ForeColor = System.Drawing.Color.Silver;
            this.lblPowered.Location = new System.Drawing.Point(3, 15);
            this.lblPowered.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblPowered.Name = "lblPowered";
            this.lblPowered.Size = new System.Drawing.Size(97, 15);
            this.lblPowered.TabIndex = 0;
            this.lblPowered.Text = "POWERED BY";
            // 
            // lblOrganization
            // 
            this.lblOrganization.AutoSize = true;
            this.lblOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganization.Location = new System.Drawing.Point(106, 15);
            this.lblOrganization.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Size = new System.Drawing.Size(78, 15);
            this.lblOrganization.TabIndex = 1;
            this.lblOrganization.Text = "BECODING";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.Silver;
            this.lblCopyright.Location = new System.Drawing.Point(262, 15);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(75, 15, 3, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(121, 15);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "COPYRIGHT 2019";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "INICIO DE SESIÓN";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUtec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBannerLogin)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox imgLogo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialCheckBox chkRememberCredential;
        private MaterialSkin.Controls.MaterialRaisedButton btnSignIn;
        private System.Windows.Forms.Label lblTitleSignIn;
        private System.Windows.Forms.PictureBox imgBannerLogin;
        private System.Windows.Forms.PictureBox imgUtec;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblPowered;
        private System.Windows.Forms.Label lblOrganization;
        private System.Windows.Forms.Label lblCopyright;
    }
}