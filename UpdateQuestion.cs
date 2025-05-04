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
    public partial class UpdateQuestion : Form
    {

        private List<Quizz> listQizz;
        private List<Question> listQuestions;
        private int selectedIndex; // Lưu index của câu hỏi cần cập nhật
        private Question currentQuestion; // Lưu câu hỏi cần cập nhật
        public UpdateQuestion(List<Quizz> qList, List<Question> questionList, Question question, int index)
        {
            InitializeComponent();
            listQizz = qList;
            listQuestions = questionList;
            currentQuestion = question;
            selectedIndex = index;
        }

        private void UpdateQuestion_Load(object sender, EventArgs e)
        {
            // Điền thông tin câu hỏi vào các trường
            txtId.Text = currentQuestion.Id;
            txtContent.Text = currentQuestion.Content;

            // Điền danh sách quiz vào CheckedListBox và chọn các quiz hiện tại của câu hỏi
            foreach (var quiz in listQizz)
            {
                clbQuizz.Items.Add(quiz);
            }
            clbQuizz.DisplayMember = "Name";

            // Chọn các quiz đã được gắn vào câu hỏi
            foreach (var quiz in listQizz)
            {
                if (currentQuestion.Quizz_id.Contains(quiz.Id))
                {
                    clbQuizz.SetItemChecked(clbQuizz.Items.IndexOf(quiz), true);
                }
            }

            // Điền các câu trả lời hiện có vào ListBox
            foreach (var answer in currentQuestion.Answers)
            {
                lstAnswers.Items.Add(answer);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string content = txtContent.Text.Trim();

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show("ID và Nội dung không được để trống!");
                return;
            }

            // Lấy danh sách quizz_id từ CheckedItems
            List<string> selectedQuizzIds = new List<string>();
            foreach (var item in clbQuizz.CheckedItems)
            {
                Quizz quiz = item as Quizz;
                if (quiz != null)
                {
                    selectedQuizzIds.Add(quiz.Id);  // Thêm ID của quiz vào danh sách
                }
            }

            // Lấy danh sách câu trả lời từ ListBox
            List<string> answers = lstAnswers.Items.Cast<string>().ToList();

            // Kiểm tra nếu không có câu trả lời hoặc không chọn quiz nào
            if (selectedQuizzIds.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một Quiz!");
                return;
            }

            if (answers.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một câu trả lời!");
                return;
            }

            // Cập nhật câu hỏi trong danh sách
            Question updatedQuestion = new Question(id, content, selectedQuizzIds, answers);
            listQuestions[selectedIndex] = updatedQuestion;

            MessageBox.Show("Cập nhật câu hỏi thành công!");
            this.Close();  // Đóng form sau khi lưu
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                lstAnswers.Items.Add(txtAnswer.Text.Trim());
                txtAnswer.Clear();
            }
        }

        private void btnDeleteAnswer_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có mục nào được chọn trong ListBox
            if (lstAnswers.SelectedItem != null)
            {
                // Xóa mục được chọn
                lstAnswers.Items.Remove(lstAnswers.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn câu trả lời cần xóa!");
            }
        }
    } 
}
