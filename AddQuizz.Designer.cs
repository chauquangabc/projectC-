namespace ProjectQuizz
{
    partial class AddQuizz
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.bntAdd = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(234, 79);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(309, 22);
            this.txtId.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 149);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(309, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(234, 232);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(309, 22);
            this.txtDes.TabIndex = 2;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(342, 318);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 3;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(142, 82);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(18, 16);
            this.Id.TabIndex = 4;
            this.Id.Text = "Id";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(130, 149);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(36, 16);
            this.Name.TabIndex = 5;
            this.Name.Text = "Tittle";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // AddQuizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddQuizz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label3;
    }
}