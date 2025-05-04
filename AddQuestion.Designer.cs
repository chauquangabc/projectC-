namespace ProjectQuizz
{
    partial class AddQuestion
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
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstAnswers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(234, 47);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(309, 22);
            this.txtId.TabIndex = 0;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(234, 103);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(309, 22);
            this.txtContent.TabIndex = 1;
            // 
            // clbQuizz
            // 
            this.clbQuizz.FormattingEnabled = true;
            this.clbQuizz.Location = new System.Drawing.Point(248, 154);
            this.clbQuizz.Name = "clbQuizz";
            this.clbQuizz.Size = new System.Drawing.Size(120, 89);
            this.clbQuizz.TabIndex = 2;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(234, 276);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(309, 22);
            this.txtAnswer.TabIndex = 3;
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.Location = new System.Drawing.Point(579, 276);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(109, 23);
            this.btnAddAnswer.TabIndex = 4;
            this.btnAddAnswer.Text = "Add Answer";
            this.btnAddAnswer.UseVisualStyleBackColor = true;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(345, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstAnswers
            // 
            this.lstAnswers.FormattingEnabled = true;
            this.lstAnswers.ItemHeight = 16;
            this.lstAnswers.Location = new System.Drawing.Point(412, 154);
            this.lstAnswers.Name = "lstAnswers";
            this.lstAnswers.Size = new System.Drawing.Size(120, 84);
            this.lstAnswers.TabIndex = 6;
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAnswers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.clbQuizz);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtId);
            this.Name = "AddQuestion";
            this.Text = "AddQuestion";
            this.Load += new System.EventHandler(this.AddQuestion_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.CheckedListBox clbQuizz;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstAnswers;
    }
}