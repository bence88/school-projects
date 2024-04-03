namespace UPVTube.GUI
{
    partial class RegisterUserForm
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNick = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelCreateAccount = new System.Windows.Forms.Label();
            this.labelHaveAccount = new System.Windows.Forms.Label();
            this.linkBackToLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DarkRed;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.Location = new System.Drawing.Point(339, 400);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(234, 50);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txtEmail.Location = new System.Drawing.Point(339, 208);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 34);
            this.txtEmail.TabIndex = 1;
            // 
            // txtNick
            // 
            this.txtNick.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txtNick.Location = new System.Drawing.Point(339, 276);
            this.txtNick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNick.Multiline = true;
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(234, 34);
            this.txtNick.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txtPassword.Location = new System.Drawing.Point(339, 344);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(234, 34);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Tag = "";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelEmail.Location = new System.Drawing.Point(341, 188);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(114, 16);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email Address";
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelNick.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelNick.Location = new System.Drawing.Point(341, 256);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(79, 16);
            this.labelNick.TabIndex = 5;
            this.labelNick.Text = "Nickname";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelPassword.Location = new System.Drawing.Point(341, 324);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(79, 16);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txtFullName.Location = new System.Drawing.Point(339, 142);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(234, 34);
            this.txtFullName.TabIndex = 7;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelFullName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelFullName.Location = new System.Drawing.Point(341, 122);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(82, 16);
            this.labelFullName.TabIndex = 8;
            this.labelFullName.Text = "Full Name";
            // 
            // labelCreateAccount
            // 
            this.labelCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreateAccount.AutoSize = true;
            this.labelCreateAccount.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateAccount.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCreateAccount.Location = new System.Drawing.Point(336, 66);
            this.labelCreateAccount.Name = "labelCreateAccount";
            this.labelCreateAccount.Size = new System.Drawing.Size(240, 33);
            this.labelCreateAccount.TabIndex = 10;
            this.labelCreateAccount.Text = "Create Account";
            this.labelCreateAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHaveAccount
            // 
            this.labelHaveAccount.AutoSize = true;
            this.labelHaveAccount.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelHaveAccount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelHaveAccount.Location = new System.Drawing.Point(351, 464);
            this.labelHaveAccount.Name = "labelHaveAccount";
            this.labelHaveAccount.Size = new System.Drawing.Size(210, 16);
            this.labelHaveAccount.TabIndex = 12;
            this.labelHaveAccount.Text = "Already Have an Account?";
            // 
            // linkBackToLogin
            // 
            this.linkBackToLogin.AutoSize = true;
            this.linkBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkBackToLogin.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.linkBackToLogin.ForeColor = System.Drawing.Color.DarkRed;
            this.linkBackToLogin.Location = new System.Drawing.Point(394, 495);
            this.linkBackToLogin.Name = "linkBackToLogin";
            this.linkBackToLogin.Size = new System.Drawing.Size(122, 16);
            this.linkBackToLogin.TabIndex = 13;
            this.linkBackToLogin.Text = "Back to LOGIN";
            this.linkBackToLogin.Click += new System.EventHandler(this.linkBackToLogin_Click);
            // 
            // RegisterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.linkBackToLogin);
            this.Controls.Add(this.labelHaveAccount);
            this.Controls.Add(this.labelCreateAccount);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelNick);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnRegister);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegisterUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterUserForm";
            this.Load += new System.EventHandler(this.RegisterUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelCreateAccount;
        private System.Windows.Forms.Label labelHaveAccount;
        private System.Windows.Forms.Label linkBackToLogin;
    }
}