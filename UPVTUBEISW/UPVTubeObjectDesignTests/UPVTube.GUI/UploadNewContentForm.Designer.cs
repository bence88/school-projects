namespace UPVTube.GUI
{
    partial class UploadNewContentForm
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
            this.linkBackToMain = new System.Windows.Forms.Label();
            this.labelUploadContent = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labelPublicStatus = new System.Windows.Forms.Label();
            this.labelURI = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.checkPublicStatus = new System.Windows.Forms.CheckBox();
            this.labelEplanationStatus = new System.Windows.Forms.Label();
            this.txtSubjectbox = new System.Windows.Forms.TextBox();
            this.txtCodeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkBackToMain
            // 
            this.linkBackToMain.AutoSize = true;
            this.linkBackToMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkBackToMain.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.linkBackToMain.ForeColor = System.Drawing.Color.DarkRed;
            this.linkBackToMain.Location = new System.Drawing.Point(243, 346);
            this.linkBackToMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkBackToMain.Name = "linkBackToMain";
            this.linkBackToMain.Size = new System.Drawing.Size(114, 11);
            this.linkBackToMain.TabIndex = 25;
            this.linkBackToMain.Text = "Back to HOME page";
            this.linkBackToMain.Click += new System.EventHandler(this.linkBackToMain_Click);
            // 
            // labelUploadContent
            // 
            this.labelUploadContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUploadContent.AutoSize = true;
            this.labelUploadContent.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUploadContent.ForeColor = System.Drawing.Color.DarkRed;
            this.labelUploadContent.Location = new System.Drawing.Point(219, 9);
            this.labelUploadContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUploadContent.Name = "labelUploadContent";
            this.labelUploadContent.Size = new System.Drawing.Size(168, 22);
            this.labelUploadContent.TabIndex = 23;
            this.labelUploadContent.Text = "Upload Content";
            this.labelUploadContent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelTitle.Location = new System.Drawing.Point(224, 40);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 11);
            this.labelTitle.TabIndex = 22;
            this.labelTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txtTitle.Location = new System.Drawing.Point(223, 53);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(157, 24);
            this.txtTitle.TabIndex = 21;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // labelPublicStatus
            // 
            this.labelPublicStatus.AutoSize = true;
            this.labelPublicStatus.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelPublicStatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelPublicStatus.Location = new System.Drawing.Point(224, 259);
            this.labelPublicStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPublicStatus.Name = "labelPublicStatus";
            this.labelPublicStatus.Size = new System.Drawing.Size(80, 11);
            this.labelPublicStatus.TabIndex = 20;
            this.labelPublicStatus.Text = "Public Status";
            // 
            // labelURI
            // 
            this.labelURI.AutoSize = true;
            this.labelURI.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelURI.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelURI.Location = new System.Drawing.Point(224, 220);
            this.labelURI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelURI.Name = "labelURI";
            this.labelURI.Size = new System.Drawing.Size(25, 11);
            this.labelURI.TabIndex = 19;
            this.labelURI.Text = "URI";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelDescription.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelDescription.Location = new System.Drawing.Point(224, 79);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(69, 11);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "Description";
            // 
            // txtURI
            // 
            this.txtURI.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txtURI.Location = new System.Drawing.Point(223, 233);
            this.txtURI.Margin = new System.Windows.Forms.Padding(2);
            this.txtURI.Multiline = true;
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(157, 24);
            this.txtURI.TabIndex = 16;
            this.txtURI.TextChanged += new System.EventHandler(this.txtNick_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txtDescription.Location = new System.Drawing.Point(221, 93);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(157, 77);
            this.txtDescription.TabIndex = 15;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.DarkRed;
            this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpload.Location = new System.Drawing.Point(222, 304);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(156, 32);
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // checkPublicStatus
            // 
            this.checkPublicStatus.AutoSize = true;
            this.checkPublicStatus.Location = new System.Drawing.Point(223, 285);
            this.checkPublicStatus.Margin = new System.Windows.Forms.Padding(2);
            this.checkPublicStatus.Name = "checkPublicStatus";
            this.checkPublicStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkPublicStatus.Size = new System.Drawing.Size(55, 17);
            this.checkPublicStatus.TabIndex = 26;
            this.checkPublicStatus.Text = "Public";
            this.checkPublicStatus.UseVisualStyleBackColor = true;
            // 
            // labelEplanationStatus
            // 
            this.labelEplanationStatus.AutoSize = true;
            this.labelEplanationStatus.Location = new System.Drawing.Point(223, 270);
            this.labelEplanationStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEplanationStatus.Name = "labelEplanationStatus";
            this.labelEplanationStatus.Size = new System.Drawing.Size(159, 13);
            this.labelEplanationStatus.TabIndex = 27;
            this.labelEplanationStatus.Text = "Videos are automatically private.";
            // 
            // txtSubjectbox
            // 
            this.txtSubjectbox.Location = new System.Drawing.Point(223, 197);
            this.txtSubjectbox.Name = "txtSubjectbox";
            this.txtSubjectbox.Size = new System.Drawing.Size(81, 20);
            this.txtSubjectbox.TabIndex = 28;
            this.txtSubjectbox.TextChanged += new System.EventHandler(this.txtSubjectsbox_TextChanged);
            // 
            // txtCodeBox
            // 
            this.txtCodeBox.Location = new System.Drawing.Point(311, 196);
            this.txtCodeBox.Name = "txtCodeBox";
            this.txtCodeBox.Size = new System.Drawing.Size(69, 20);
            this.txtCodeBox.TabIndex = 31;
            this.txtCodeBox.TextChanged += new System.EventHandler(this.txtCodeBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(309, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 11);
            this.label1.TabIndex = 32;
            this.label1.Text = "Subject Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(221, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 11);
            this.label3.TabIndex = 33;
            this.label3.Text = "Subject Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UploadNewContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodeBox);
            this.Controls.Add(this.txtSubjectbox);
            this.Controls.Add(this.labelEplanationStatus);
            this.Controls.Add(this.checkPublicStatus);
            this.Controls.Add(this.linkBackToMain);
            this.Controls.Add(this.labelUploadContent);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.labelPublicStatus);
            this.Controls.Add(this.labelURI);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnUpload);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UploadNewContentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UploadNewContentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label linkBackToMain;
        private System.Windows.Forms.Label labelUploadContent;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label labelPublicStatus;
        private System.Windows.Forms.Label labelURI;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label labelEplanationStatus;
        public System.Windows.Forms.CheckBox checkPublicStatus;
        private System.Windows.Forms.TextBox txtSubjectbox;
        private System.Windows.Forms.TextBox txtCodeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}