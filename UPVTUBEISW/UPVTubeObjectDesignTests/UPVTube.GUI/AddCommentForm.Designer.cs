namespace UPVTube.GUI
{
    partial class AddCommentForm
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
            this.label_WriteComment = new System.Windows.Forms.Label();
            this.tb_Comment = new System.Windows.Forms.TextBox();
            this.btn_AddComment = new System.Windows.Forms.Button();
            this.btn_CancelComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_WriteComment
            // 
            this.label_WriteComment.AutoSize = true;
            this.label_WriteComment.Location = new System.Drawing.Point(12, 9);
            this.label_WriteComment.Name = "label_WriteComment";
            this.label_WriteComment.Size = new System.Drawing.Size(104, 13);
            this.label_WriteComment.TabIndex = 0;
            this.label_WriteComment.Text = "Write your comment:";
            // 
            // tb_Comment
            // 
            this.tb_Comment.AllowDrop = true;
            this.tb_Comment.Location = new System.Drawing.Point(15, 36);
            this.tb_Comment.Multiline = true;
            this.tb_Comment.Name = "tb_Comment";
            this.tb_Comment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Comment.Size = new System.Drawing.Size(468, 155);
            this.tb_Comment.TabIndex = 1;
            // 
            // btn_AddComment
            // 
            this.btn_AddComment.BackColor = System.Drawing.Color.DarkRed;
            this.btn_AddComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AddComment.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_AddComment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_AddComment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_AddComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddComment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AddComment.Location = new System.Drawing.Point(330, 222);
            this.btn_AddComment.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddComment.Name = "btn_AddComment";
            this.btn_AddComment.Size = new System.Drawing.Size(156, 32);
            this.btn_AddComment.TabIndex = 65;
            this.btn_AddComment.Text = "Add comment";
            this.btn_AddComment.UseVisualStyleBackColor = false;
            this.btn_AddComment.Click += new System.EventHandler(this.btn_AddComment_Click);
            // 
            // btn_CancelComment
            // 
            this.btn_CancelComment.BackColor = System.Drawing.Color.DarkRed;
            this.btn_CancelComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CancelComment.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_CancelComment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_CancelComment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_CancelComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelComment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_CancelComment.Location = new System.Drawing.Point(15, 222);
            this.btn_CancelComment.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CancelComment.Name = "btn_CancelComment";
            this.btn_CancelComment.Size = new System.Drawing.Size(156, 32);
            this.btn_CancelComment.TabIndex = 66;
            this.btn_CancelComment.Text = "Cancel";
            this.btn_CancelComment.UseVisualStyleBackColor = false;
            this.btn_CancelComment.Click += new System.EventHandler(this.btn_CancelComment_Click);
            // 
            // AddCommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 263);
            this.Controls.Add(this.btn_CancelComment);
            this.Controls.Add(this.btn_AddComment);
            this.Controls.Add(this.tb_Comment);
            this.Controls.Add(this.label_WriteComment);
            this.Name = "AddCommentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCommentForm";
            this.Load += new System.EventHandler(this.AddCommentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_WriteComment;
        private System.Windows.Forms.TextBox tb_Comment;
        private System.Windows.Forms.Button btn_AddComment;
        private System.Windows.Forms.Button btn_CancelComment;
    }
}