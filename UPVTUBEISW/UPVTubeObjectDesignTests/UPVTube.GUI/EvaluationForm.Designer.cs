namespace UPVTube.GUI
{
    partial class EvaluationForm
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
            this.txtRejectionReason = new System.Windows.Forms.TextBox();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRejectionReason
            // 
            this.txtRejectionReason.Location = new System.Drawing.Point(60, 59);
            this.txtRejectionReason.Multiline = true;
            this.txtRejectionReason.Name = "txtRejectionReason";
            this.txtRejectionReason.Size = new System.Drawing.Size(311, 165);
            this.txtRejectionReason.TabIndex = 0;
            // 
            // btnAddReview
            // 
            this.btnAddReview.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddReview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddReview.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAddReview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnAddReview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnAddReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReview.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddReview.Location = new System.Drawing.Point(141, 250);
            this.btnAddReview.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(156, 32);
            this.btnAddReview.TabIndex = 12;
            this.btnAddReview.Text = "Add Review";
            this.btnAddReview.UseVisualStyleBackColor = false;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(74, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Please insert your rejection reason";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EvaluationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddReview);
            this.Controls.Add(this.txtRejectionReason);
            this.Name = "EvaluationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EvaluationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRejectionReason;
        private System.Windows.Forms.Button btnAddReview;
        private System.Windows.Forms.Label label1;
    }
}