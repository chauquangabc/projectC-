namespace ProjectQuizz
{
    partial class UpdateQuestion
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.clbQuizz = new System.Windows.Forms.CheckedListBox();
            this.lstAnswers = new System.Windows.Forms.ListBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(241, 55);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(286, 22);
            this.txtId.TabIndex = 0;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(241, 125);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(286, 22);
            this.txtContent.TabIndex = 1;
            // 
            // clbQuizz
            // 
            this.clbQuizz.FormattingEnabled = true;
            this.clbQuizz.Location = new System.Drawing.Point(241, 187);
            this.clbQuizz.Name = "clbQuizz";
            this.clbQuizz.Size = new System.Drawing.Size(120, 89);
            this.clbQuizz.TabIndex = 2;
            // 
            // lstAnswers
            // 
            this.lstAnswers.FormattingEnabled = true;
            this.lstAnswers.ItemHeight = 16;
            this.lstAnswers.Location = new System.Drawing.Point(419, 187);
            this.lstAnswers.Name = "lstAnswers";
            this.lstAnswers.Size = new System.Drawing.Size(120, 84);
            this.lstAnswers.TabIndex = 3;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(241, 303);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(298, 22);
            this.txtAnswer.TabIndex = 4;
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.Location = new System.Drawing.Point(587, 303);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(107, 23);
            this.btnAddAnswer.TabIndex = 5;
            this.btnAddAnswer.Text = "Add Answer";
            this.btnAddAnswer.UseVisualStyleBackColor = true;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(357, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteAnswer
            // 
            this.btnDeleteAnswer.Location = new System.Drawing.Point(587, 218);
            this.btnDeleteAnswer.Name = "btnDeleteAnswer";
            this.btnDeleteAnswer.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteAnswer.TabIndex = 7;
            this.btnDeleteAnswer.Text = "Delete Answer";
            this.btnDeleteAnswer.UseVisualStyleBackColor = true;
            this.btnDeleteAnswer.Click += new System.EventHandler(this.btnDeleteAnswer_Click);
            // 
            // UpdateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteAnswer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lstAnswers);
            this.Controls.Add(this.clbQuizz);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtId);
            this.Name = "UpdateQuestion";
            this.Text = "UpdateQuestion";
            this.Load += new System.EventHandler(this.UpdateQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.CheckedListBox clbQuizz;
        private System.Windows.Forms.ListBox lstAnswers;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteAnswer;
    }
}