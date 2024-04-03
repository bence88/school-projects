namespace UPVTube.GUI
{
    partial class MainForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUploadContent = new System.Windows.Forms.Button();
            this.btnSearchContent = new System.Windows.Forms.Button();
            this.PendingContent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(535, 8);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(57, 24);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUploadContent
            // 
            this.btnUploadContent.BackColor = System.Drawing.Color.DarkRed;
            this.btnUploadContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadContent.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.btnUploadContent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUploadContent.Location = new System.Drawing.Point(9, 8);
            this.btnUploadContent.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadContent.Name = "btnUploadContent";
            this.btnUploadContent.Size = new System.Drawing.Size(171, 24);
            this.btnUploadContent.TabIndex = 2;
            this.btnUploadContent.Text = "Upload New Content";
            this.btnUploadContent.UseVisualStyleBackColor = false;
            this.btnUploadContent.Click += new System.EventHandler(this.btnUploadContent_Click);
            // 
            // btnSearchContent
            // 
            this.btnSearchContent.BackColor = System.Drawing.Color.DarkRed;
            this.btnSearchContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchContent.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.btnSearchContent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchContent.Location = new System.Drawing.Point(9, 78);
            this.btnSearchContent.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchContent.Name = "btnSearchContent";
            this.btnSearchContent.Size = new System.Drawing.Size(171, 24);
            this.btnSearchContent.TabIndex = 3;
            this.btnSearchContent.Text = "Search Content";
            this.btnSearchContent.UseVisualStyleBackColor = false;
            this.btnSearchContent.Click += new System.EventHandler(this.btnSearchContent_Click);
            // 
            // PendingContent
            // 
            this.PendingContent.BackColor = System.Drawing.Color.DarkRed;
            this.PendingContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PendingContent.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.PendingContent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PendingContent.Location = new System.Drawing.Point(9, 150);
            this.PendingContent.Margin = new System.Windows.Forms.Padding(2);
            this.PendingContent.Name = "PendingContent";
            this.PendingContent.Size = new System.Drawing.Size(171, 24);
            this.PendingContent.TabIndex = 5;
            this.PendingContent.Text = "Pending Content";
            this.PendingContent.UseMnemonic = false;
            this.PendingContent.UseVisualStyleBackColor = false;
            this.PendingContent.Click += new System.EventHandler(this.btnPendingContent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.PendingContent);
            this.Controls.Add(this.btnSearchContent);
            this.Controls.Add(this.btnUploadContent);
            this.Controls.Add(this.btnLogout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUploadContent;
        private System.Windows.Forms.Button btnSearchContent;
        private System.Windows.Forms.Button PendingContent;
    }
}