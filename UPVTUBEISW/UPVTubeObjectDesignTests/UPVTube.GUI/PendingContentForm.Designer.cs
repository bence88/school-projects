namespace UPVTube.GUI
{
    partial class PendingContentForm
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
            this.components = new System.ComponentModel.Container();
            this.labelContentReview = new System.Windows.Forms.Label();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pendingContentSource = new System.Windows.Forms.BindingSource(this.components);
            this.contentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkBackToMain = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.p_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_UploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_Subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPublic = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingContentSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelContentReview
            // 
            this.labelContentReview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContentReview.AutoSize = true;
            this.labelContentReview.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContentReview.ForeColor = System.Drawing.Color.DarkRed;
            this.labelContentReview.Location = new System.Drawing.Point(159, 24);
            this.labelContentReview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContentReview.Name = "labelContentReview";
            this.labelContentReview.Size = new System.Drawing.Size(280, 22);
            this.labelContentReview.TabIndex = 35;
            this.labelContentReview.Text = "Content waiting for review";
            this.labelContentReview.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(UPVTube.Entities.Member);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_Title,
            this.p_UploadDate,
            this.p_Owner,
            this.p_Subjects,
            this.p_Description,
            this.IsPublic});
            this.dataGridView1.DataSource = this.pendingContentSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(574, 216);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contentBindingSource
            // 
            this.contentBindingSource.DataSource = typeof(UPVTube.Entities.Content);
            // 
            // linkBackToMain
            // 
            this.linkBackToMain.AutoSize = true;
            this.linkBackToMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkBackToMain.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.linkBackToMain.ForeColor = System.Drawing.Color.DarkRed;
            this.linkBackToMain.Location = new System.Drawing.Point(475, 346);
            this.linkBackToMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkBackToMain.Name = "linkBackToMain";
            this.linkBackToMain.Size = new System.Drawing.Size(114, 11);
            this.linkBackToMain.TabIndex = 38;
            this.linkBackToMain.Text = "Back to HOME page";
            this.linkBackToMain.Click += new System.EventHandler(this.linkBackToMain_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.DarkRed;
            this.btnApprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApprove.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnApprove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnApprove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnApprove.Location = new System.Drawing.Point(9, 287);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(0);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(156, 32);
            this.btnApprove.TabIndex = 39;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.DarkRed;
            this.btnReject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReject.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnReject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnReject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReject.Location = new System.Drawing.Point(433, 287);
            this.btnReject.Margin = new System.Windows.Forms.Padding(0);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(156, 32);
            this.btnReject.TabIndex = 40;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // p_Title
            // 
            this.p_Title.DataPropertyName = "ds_Title";
            this.p_Title.HeaderText = "Title";
            this.p_Title.Name = "p_Title";
            this.p_Title.ReadOnly = true;
            // 
            // p_UploadDate
            // 
            this.p_UploadDate.DataPropertyName = "ds_UploadDate";
            this.p_UploadDate.HeaderText = "UploadDate";
            this.p_UploadDate.Name = "p_UploadDate";
            this.p_UploadDate.ReadOnly = true;
            // 
            // p_Owner
            // 
            this.p_Owner.DataPropertyName = "ds_Owner";
            this.p_Owner.HeaderText = "Owner";
            this.p_Owner.Name = "p_Owner";
            this.p_Owner.ReadOnly = true;
            // 
            // p_Subjects
            // 
            this.p_Subjects.DataPropertyName = "ds_Subjects";
            this.p_Subjects.HeaderText = "Subjects";
            this.p_Subjects.Name = "p_Subjects";
            this.p_Subjects.ReadOnly = true;
            // 
            // p_Description
            // 
            this.p_Description.DataPropertyName = "ds_Description";
            this.p_Description.HeaderText = "Description";
            this.p_Description.Name = "p_Description";
            this.p_Description.ReadOnly = true;
            // 
            // IsPublic
            // 
            this.IsPublic.DataPropertyName = "ds_IsPublic";
            this.IsPublic.HeaderText = "IsPublic";
            this.IsPublic.MinimumWidth = 6;
            this.IsPublic.Name = "IsPublic";
            this.IsPublic.ReadOnly = true;
            this.IsPublic.Width = 125;
            // 
            // PendingContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.linkBackToMain);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelContentReview);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PendingContentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PendingContent";
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingContentSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelContentReview;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource contentBindingSource;
        private System.Windows.Forms.Label linkBackToMain;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.BindingSource pendingContentSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_UploadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_Subjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPublic;
    }
}