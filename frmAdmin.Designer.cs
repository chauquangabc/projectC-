using System.Windows.Forms;

namespace ProjectQuizz
{
    partial class frmAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnQuizz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagrdQuestionView = new System.Windows.Forms.DataGridView();
            this.datagrdUserView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.datagrdQuizzView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdQuestionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdUserView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdQuizzView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnQuestion);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnQuizz);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 589);
            this.panel1.TabIndex = 0;
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(79, 311);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(105, 23);
            this.btnQuestion.TabIndex = 3;
            this.btnQuestion.Text = "Question";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(92, 239);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 23);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnQuizz
            // 
            this.btnQuizz.Location = new System.Drawing.Point(92, 173);
            this.btnQuizz.Name = "btnQuizz";
            this.btnQuizz.Size = new System.Drawing.Size(75, 23);
            this.btnQuizz.TabIndex = 1;
            this.btnQuizz.Text = "Quizz";
            this.btnQuizz.UseVisualStyleBackColor = true;
            this.btnQuizz.Click += new System.EventHandler(this.btnQuizz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.datagrdQuestionView);
            this.panel2.Controls.Add(this.datagrdUserView);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.datagrdQuizzView);
            this.panel2.Location = new System.Drawing.Point(291, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 589);
            this.panel2.TabIndex = 1;
            // 
            // datagrdQuestionView
            // 
            this.datagrdQuestionView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.datagrdQuestionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdQuestionView.Location = new System.Drawing.Point(15, 24);
            this.datagrdQuestionView.Name = "datagrdQuestionView";
            this.datagrdQuestionView.RowHeadersWidth = 51;
            this.datagrdQuestionView.RowTemplate.Height = 24;
            this.datagrdQuestionView.Size = new System.Drawing.Size(518, 436);
            this.datagrdQuestionView.TabIndex = 5;
            // 
            // datagrdUserView
            // 
            this.datagrdUserView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagrdUserView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdUserView.Location = new System.Drawing.Point(15, 24);
            this.datagrdUserView.Name = "datagrdUserView";
            this.datagrdUserView.RowHeadersWidth = 51;
            this.datagrdUserView.RowTemplate.Height = 24;
            this.datagrdUserView.Size = new System.Drawing.Size(518, 436);
            this.datagrdUserView.TabIndex = 4;
            this.datagrdUserView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrdUserView_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(397, 496);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(243, 497);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(78, 497);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // datagrdQuizzView
            // 
            this.datagrdQuizzView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdQuizzView.Location = new System.Drawing.Point(63, 100);
            this.datagrdQuizzView.Name = "datagrdQuizzView";
            this.datagrdQuizzView.RowHeadersWidth = 51;
            this.datagrdQuizzView.RowTemplate.Height = 24;
            this.datagrdQuizzView.Size = new System.Drawing.Size(437, 330);
            this.datagrdQuizzView.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(836, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrdQuestionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdUserView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdQuizzView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Label label1;
        private Button btnQuizz;
        private Panel panel2;
        private DataGridView datagrdQuizzView;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnUser;
        private DataGridView datagrdUserView;
        private Button btnQuestion;
        private DataGridView datagrdQuestionView;
    }
}