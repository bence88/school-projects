using UPVTube.Entities;

namespace UPVTube.GUI
{
    partial class SearchContentForm
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
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.linkBackToMain = new System.Windows.Forms.Label();
            this.labelSearchContent = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelNick = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contentURIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(56, 115);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(157, 20);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // linkBackToMain
            // 
            this.linkBackToMain.AutoSize = true;
            this.linkBackToMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkBackToMain.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.linkBackToMain.ForeColor = System.Drawing.Color.DarkRed;
            this.linkBackToMain.Location = new System.Drawing.Point(485, 347);
            this.linkBackToMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkBackToMain.Name = "linkBackToMain";
            this.linkBackToMain.Size = new System.Drawing.Size(114, 11);
            this.linkBackToMain.TabIndex = 37;
            this.linkBackToMain.Text = "Back to HOME page";
            this.linkBackToMain.Click += new System.EventHandler(this.linkBackToMain_Click);
            // 
            // labelSearchContent
            // 
            this.labelSearchContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearchContent.AutoSize = true;
            this.labelSearchContent.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchContent.ForeColor = System.Drawing.Color.DarkRed;
            this.labelSearchContent.Location = new System.Drawing.Point(219, 16);
            this.labelSearchContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearchContent.Name = "labelSearchContent";
            this.labelSearchContent.Size = new System.Drawing.Size(170, 22);
            this.labelSearchContent.TabIndex = 36;
            this.labelSearchContent.Text = "Search Content";
            this.labelSearchContent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelTitle.Location = new System.Drawing.Point(56, 53);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 11);
            this.labelTitle.TabIndex = 35;
            this.labelTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txtTitle.Location = new System.Drawing.Point(56, 67);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(157, 24);
            this.txtTitle.TabIndex = 34;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelStartDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelStartDate.Location = new System.Drawing.Point(56, 102);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(136, 11);
            this.labelStartDate.TabIndex = 33;
            this.labelStartDate.Text = "Ranging from start date";
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelNick.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelNick.Location = new System.Drawing.Point(383, 53);
            this.labelNick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(76, 11);
            this.labelNick.TabIndex = 32;
            this.labelNick.Text = "Owner (nick)";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelSubject.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelSubject.Location = new System.Drawing.Point(220, 53);
            this.labelSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(48, 11);
            this.labelSubject.TabIndex = 31;
            this.labelSubject.Text = "Subject";
            // 
            // txtNick
            // 
            this.txtNick.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txtNick.Location = new System.Drawing.Point(386, 67);
            this.txtNick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNick.Multiline = true;
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(157, 24);
            this.txtNick.TabIndex = 30;
            this.txtNick.TextChanged += new System.EventHandler(this.txtURI_TextChanged);
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txtSubject.Location = new System.Drawing.Point(223, 67);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(157, 24);
            this.txtSubject.TabIndex = 29;
            this.txtSubject.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkRed;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Location = new System.Drawing.Point(386, 109);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 32);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchClick);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelEndDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelEndDate.Location = new System.Drawing.Point(220, 102);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(71, 11);
            this.labelEndDate.TabIndex = 39;
            this.labelEndDate.Text = "To end date";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(223, 115);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(157, 20);
            this.dateTimePickerEnd.TabIndex = 38;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contentURIDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.uploadDateDataGridViewTextBoxColumn,
            this.subjectsDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 146);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(580, 184);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearch_CellDoubleClick);
            // 
            // contentBindingSource
            // 
            this.contentBindingSource.DataSource = typeof(UPVTube.Entities.Content);
            // 
            // contentURIDataGridViewTextBoxColumn
            // 
            this.contentURIDataGridViewTextBoxColumn.DataPropertyName = "ContentURI";
            this.contentURIDataGridViewTextBoxColumn.HeaderText = "ContentURI";
            this.contentURIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contentURIDataGridViewTextBoxColumn.Name = "contentURIDataGridViewTextBoxColumn";
            this.contentURIDataGridViewTextBoxColumn.ReadOnly = true;
            this.contentURIDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // uploadDateDataGridViewTextBoxColumn
            // 
            this.uploadDateDataGridViewTextBoxColumn.DataPropertyName = "UploadDate";
            this.uploadDateDataGridViewTextBoxColumn.HeaderText = "UploadDate";
            this.uploadDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uploadDateDataGridViewTextBoxColumn.Name = "uploadDateDataGridViewTextBoxColumn";
            this.uploadDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.uploadDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectsDataGridViewTextBoxColumn
            // 
            this.subjectsDataGridViewTextBoxColumn.DataPropertyName = "Subjects";
            this.subjectsDataGridViewTextBoxColumn.HeaderText = "Subjects";
            this.subjectsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectsDataGridViewTextBoxColumn.Name = "subjectsDataGridViewTextBoxColumn";
            this.subjectsDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectsDataGridViewTextBoxColumn.Width = 125;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerDataGridViewTextBoxColumn.Width = 125;
            // 
            // SearchContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.linkBackToMain);
            this.Controls.Add(this.labelSearchContent);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelNick);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateTimePickerStart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchContentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.SearchContentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label linkBackToMain;
        private System.Windows.Forms.Label labelSearchContent;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.BindingSource contentBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentURIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
    }
}