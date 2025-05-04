using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuizz
{
    public partial class UpdateQuizz : Form
    {
        private Quizz quizToEdit;
        public UpdateQuizz( Quizz quizToEdit)
        {
            InitializeComponent();
            this.quizToEdit = quizToEdit;


            // Hiển thị dữ liệu lên TextBox
            txtId.Text = quizToEdit.Id;
            txtTitle.Text = quizToEdit.Name;
            txtDes.Text = quizToEdit.Description;
        }

        private void UpdateQuizz_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Cập nhật lại đối tượng
            quizToEdit.Id = txtId.Text.Trim();
            quizToEdit.Name = txtTitle.Text.Trim();
            quizToEdit.Description = txtDes.Text.Trim();
            this.Close();
        }
    }
}
