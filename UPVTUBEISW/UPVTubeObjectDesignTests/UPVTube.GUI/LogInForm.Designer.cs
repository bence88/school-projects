namespace UPVTube.GUI
{
    partial class LogInForm
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelNick = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkCreateAccount = new System.Windows.Forms.Label();
            this.labelDontHaveAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.DarkRed;
            this.labelWelcome.Location = new System.Drawing.Point(252, 43);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(98, 22);
            this.labelWelcome.TabIndex = 20;
            this.labelWelcome.Text = "Welcome";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelPassword.Location = new System.Drawing.Point(227, 122);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 11);
            this.labelPassword.TabIndex = 17;
            this.labelPassword.Text = "Password";
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelNick.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelNick.Location = new System.Drawing.Point(227, 79);
            this.labelNick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(58, 11);
            this.labelNick.TabIndex = 16;
            this.labelNick.Text = "Nickname";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txtPassword.Location = new System.Drawing.Point(226, 135);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(157, 24);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Tag = "";
            // 
            // txtNick
            // 
            this.txtNick.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txtNick.Location = new System.Drawing.Point(226, 92);
            this.txtNick.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNick.Multiline = true;
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(157, 24);
            this.txtNick.TabIndex = 13;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(226, 177);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 32);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkCreateAccount
            // 
            this.linkCreateAccount.AutoSize = true;
            this.linkCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkCreateAccount.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.linkCreateAccount.ForeColor = System.Drawing.Color.DarkRed;
            this.linkCreateAccount.Location = new System.Drawing.Point(263, 239);
            this.linkCreateAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkCreateAccount.Name = "linkCreateAccount";
            this.linkCreateAccount.Size = new System.Drawing.Size(95, 11);
            this.linkCreateAccount.TabIndex = 22;
            this.linkCreateAccount.Text = "Create Account";
            this.linkCreateAccount.Click += new System.EventHandler(this.linkCreateAccount_Click);
            // 
            // labelDontHaveAccount
            // 
            this.labelDontHaveAccount.AutoSize = true;
            this.labelDontHaveAccount.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelDontHaveAccount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelDontHaveAccount.Location = new System.Drawing.Point(245, 219);
            this.labelDontHaveAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDontHaveAccount.Name = "labelDontHaveAccount";
            this.labelDontHaveAccount.Size = new System.Drawing.Size(138, 11);
            this.labelDontHaveAccount.TabIndex = 21;
            this.labelDontHaveAccount.Text = "Dont Have an Account?";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.linkCreateAccount);
            this.Controls.Add(this.labelDontHaveAccount);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelNick);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label linkCreateAccount;
        private System.Windows.Forms.Label labelDontHaveAccount;
    }
}