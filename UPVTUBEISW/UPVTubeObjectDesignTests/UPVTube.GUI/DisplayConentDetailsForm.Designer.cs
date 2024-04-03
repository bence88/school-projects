namespace UPVTube.GUI
{
    partial class DisplayConentDetailsForm
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
            this.labelContentDetails = new System.Windows.Forms.Label();
            this.contentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_for_uri = new System.Windows.Forms.Label();
            this.tb_URI = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.label_Owner = new System.Windows.Forms.Label();
            this.tb_Owner = new System.Windows.Forms.TextBox();
            this.label_UpLoadDate = new System.Windows.Forms.Label();
            this.tb_UpLoadDate = new System.Windows.Forms.TextBox();
            this.label_Authorized = new System.Windows.Forms.Label();
            this.tb_Authorized = new System.Windows.Forms.TextBox();
            this.label_IsPublic = new System.Windows.Forms.Label();
            this.tb_IsPublic = new System.Windows.Forms.TextBox();
            this.label_Eval = new System.Windows.Forms.Label();
            this.tb_Eval = new System.Windows.Forms.TextBox();
            this.label_Subjects = new System.Windows.Forms.Label();
            this.tb_Subjects = new System.Windows.Forms.TextBox();
            this.label_Comments = new System.Windows.Forms.Label();
            this.tb_Comments = new System.Windows.Forms.TextBox();
            this.btnMakeComment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelContentDetails
            // 
            this.labelContentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContentDetails.AutoSize = true;
            this.labelContentDetails.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContentDetails.ForeColor = System.Drawing.Color.DarkRed;
            this.labelContentDetails.Location = new System.Drawing.Point(209, 9);
            this.labelContentDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContentDetails.Name = "labelContentDetails";
            this.labelContentDetails.Size = new System.Drawing.Size(167, 22);
            this.labelContentDetails.TabIndex = 44;
            this.labelContentDetails.Text = "Content details";
            this.labelContentDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contentBindingSource
            // 
            this.contentBindingSource.DataSource = typeof(UPVTube.Entities.Content);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(UPVTube.Entities.Member);
            // 
            // label_for_uri
            // 
            this.label_for_uri.AutoSize = true;
            this.label_for_uri.Location = new System.Drawing.Point(12, 57);
            this.label_for_uri.Name = "label_for_uri";
            this.label_for_uri.Size = new System.Drawing.Size(32, 13);
            this.label_for_uri.TabIndex = 46;
            this.label_for_uri.Text = "URI: ";
            // 
            // tb_URI
            // 
            this.tb_URI.Location = new System.Drawing.Point(50, 54);
            this.tb_URI.Name = "tb_URI";
            this.tb_URI.ReadOnly = true;
            this.tb_URI.Size = new System.Drawing.Size(531, 20);
            this.tb_URI.TabIndex = 47;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(12, 87);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(30, 13);
            this.label_Title.TabIndex = 48;
            this.label_Title.Text = "Title:";
            // 
            // tb_Title
            // 
            this.tb_Title.Location = new System.Drawing.Point(48, 84);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.ReadOnly = true;
            this.tb_Title.Size = new System.Drawing.Size(533, 20);
            this.tb_Title.TabIndex = 49;
            // 
            // label_Owner
            // 
            this.label_Owner.AutoSize = true;
            this.label_Owner.Location = new System.Drawing.Point(12, 117);
            this.label_Owner.Name = "label_Owner";
            this.label_Owner.Size = new System.Drawing.Size(41, 13);
            this.label_Owner.TabIndex = 50;
            this.label_Owner.Text = "Owner:";
            // 
            // tb_Owner
            // 
            this.tb_Owner.Location = new System.Drawing.Point(59, 114);
            this.tb_Owner.Name = "tb_Owner";
            this.tb_Owner.ReadOnly = true;
            this.tb_Owner.Size = new System.Drawing.Size(522, 20);
            this.tb_Owner.TabIndex = 51;
            // 
            // label_UpLoadDate
            // 
            this.label_UpLoadDate.AutoSize = true;
            this.label_UpLoadDate.Location = new System.Drawing.Point(12, 148);
            this.label_UpLoadDate.Name = "label_UpLoadDate";
            this.label_UpLoadDate.Size = new System.Drawing.Size(70, 13);
            this.label_UpLoadDate.TabIndex = 52;
            this.label_UpLoadDate.Text = "Upload Date:";
            // 
            // tb_UpLoadDate
            // 
            this.tb_UpLoadDate.Location = new System.Drawing.Point(88, 145);
            this.tb_UpLoadDate.Name = "tb_UpLoadDate";
            this.tb_UpLoadDate.ReadOnly = true;
            this.tb_UpLoadDate.Size = new System.Drawing.Size(132, 20);
            this.tb_UpLoadDate.TabIndex = 53;
            // 
            // label_Authorized
            // 
            this.label_Authorized.AutoSize = true;
            this.label_Authorized.Location = new System.Drawing.Point(237, 148);
            this.label_Authorized.Name = "label_Authorized";
            this.label_Authorized.Size = new System.Drawing.Size(60, 13);
            this.label_Authorized.TabIndex = 54;
            this.label_Authorized.Text = "Authorized:";
            // 
            // tb_Authorized
            // 
            this.tb_Authorized.Location = new System.Drawing.Point(303, 145);
            this.tb_Authorized.Name = "tb_Authorized";
            this.tb_Authorized.ReadOnly = true;
            this.tb_Authorized.Size = new System.Drawing.Size(73, 20);
            this.tb_Authorized.TabIndex = 55;
            // 
            // label_IsPublic
            // 
            this.label_IsPublic.AutoSize = true;
            this.label_IsPublic.Location = new System.Drawing.Point(391, 148);
            this.label_IsPublic.Name = "label_IsPublic";
            this.label_IsPublic.Size = new System.Drawing.Size(57, 13);
            this.label_IsPublic.TabIndex = 56;
            this.label_IsPublic.Text = "Is it public:";
            // 
            // tb_IsPublic
            // 
            this.tb_IsPublic.Location = new System.Drawing.Point(454, 145);
            this.tb_IsPublic.Name = "tb_IsPublic";
            this.tb_IsPublic.ReadOnly = true;
            this.tb_IsPublic.Size = new System.Drawing.Size(73, 20);
            this.tb_IsPublic.TabIndex = 57;
            // 
            // label_Eval
            // 
            this.label_Eval.AutoSize = true;
            this.label_Eval.Location = new System.Drawing.Point(12, 180);
            this.label_Eval.Name = "label_Eval";
            this.label_Eval.Size = new System.Drawing.Size(60, 13);
            this.label_Eval.TabIndex = 58;
            this.label_Eval.Text = "Evaluation:";
            // 
            // tb_Eval
            // 
            this.tb_Eval.Location = new System.Drawing.Point(78, 177);
            this.tb_Eval.Name = "tb_Eval";
            this.tb_Eval.ReadOnly = true;
            this.tb_Eval.Size = new System.Drawing.Size(503, 20);
            this.tb_Eval.TabIndex = 59;
            // 
            // label_Subjects
            // 
            this.label_Subjects.AutoSize = true;
            this.label_Subjects.Location = new System.Drawing.Point(12, 210);
            this.label_Subjects.Name = "label_Subjects";
            this.label_Subjects.Size = new System.Drawing.Size(96, 13);
            this.label_Subjects.TabIndex = 60;
            this.label_Subjects.Text = "Relating Subjects: ";
            // 
            // tb_Subjects
            // 
            this.tb_Subjects.Location = new System.Drawing.Point(114, 207);
            this.tb_Subjects.Name = "tb_Subjects";
            this.tb_Subjects.ReadOnly = true;
            this.tb_Subjects.Size = new System.Drawing.Size(467, 20);
            this.tb_Subjects.TabIndex = 61;
            // 
            // label_Comments
            // 
            this.label_Comments.AutoSize = true;
            this.label_Comments.Location = new System.Drawing.Point(12, 241);
            this.label_Comments.Name = "label_Comments";
            this.label_Comments.Size = new System.Drawing.Size(59, 13);
            this.label_Comments.TabIndex = 62;
            this.label_Comments.Text = "Comments:";
            // 
            // tb_Comments
            // 
            this.tb_Comments.AllowDrop = true;
            this.tb_Comments.Location = new System.Drawing.Point(77, 238);
            this.tb_Comments.Multiline = true;
            this.tb_Comments.Name = "tb_Comments";
            this.tb_Comments.ReadOnly = true;
            this.tb_Comments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Comments.Size = new System.Drawing.Size(503, 140);
            this.tb_Comments.TabIndex = 63;
            // 
            // btnMakeComment
            // 
            this.btnMakeComment.BackColor = System.Drawing.Color.DarkRed;
            this.btnMakeComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMakeComment.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnMakeComment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnMakeComment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnMakeComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeComment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMakeComment.Location = new System.Drawing.Point(430, 399);
            this.btnMakeComment.Margin = new System.Windows.Forms.Padding(0);
            this.btnMakeComment.Name = "btnMakeComment";
            this.btnMakeComment.Size = new System.Drawing.Size(156, 32);
            this.btnMakeComment.TabIndex = 64;
            this.btnMakeComment.Text = "Comment";
            this.btnMakeComment.UseVisualStyleBackColor = false;
            this.btnMakeComment.Click += new System.EventHandler(this.btnMakeComment_Click);
            // 
            // DisplayConentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 440);
            this.Controls.Add(this.btnMakeComment);
            this.Controls.Add(this.tb_Comments);
            this.Controls.Add(this.label_Comments);
            this.Controls.Add(this.tb_Subjects);
            this.Controls.Add(this.label_Subjects);
            this.Controls.Add(this.tb_Eval);
            this.Controls.Add(this.label_Eval);
            this.Controls.Add(this.tb_IsPublic);
            this.Controls.Add(this.label_IsPublic);
            this.Controls.Add(this.tb_Authorized);
            this.Controls.Add(this.label_Authorized);
            this.Controls.Add(this.tb_UpLoadDate);
            this.Controls.Add(this.label_UpLoadDate);
            this.Controls.Add(this.tb_Owner);
            this.Controls.Add(this.label_Owner);
            this.Controls.Add(this.tb_Title);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.tb_URI);
            this.Controls.Add(this.label_for_uri);
            this.Controls.Add(this.labelContentDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DisplayConentDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayConentDetailsForm";
            this.Load += new System.EventHandler(this.DisplayConentDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelContentDetails;
        private System.Windows.Forms.BindingSource contentBindingSource;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.Label label_for_uri;
        private System.Windows.Forms.TextBox tb_URI;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.Label label_Owner;
        private System.Windows.Forms.TextBox tb_Owner;
        private System.Windows.Forms.Label label_UpLoadDate;
        private System.Windows.Forms.TextBox tb_UpLoadDate;
        private System.Windows.Forms.Label label_Authorized;
        private System.Windows.Forms.TextBox tb_Authorized;
        private System.Windows.Forms.Label label_IsPublic;
        private System.Windows.Forms.TextBox tb_IsPublic;
        private System.Windows.Forms.Label label_Eval;
        private System.Windows.Forms.TextBox tb_Eval;
        private System.Windows.Forms.Label label_Subjects;
        private System.Windows.Forms.TextBox tb_Subjects;
        private System.Windows.Forms.Label label_Comments;
        private System.Windows.Forms.TextBox tb_Comments;
        private System.Windows.Forms.Button btnMakeComment;
    }
}