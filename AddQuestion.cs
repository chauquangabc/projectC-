using System;
using System.Collections;
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
    public partial class AddQuestion : Form
    {
        private List<Quizz> listQizz;
        private List<Question> listQuestions;
        public AddQuestion(List<Quizz> qList, List<Question> questionList)
        {
            InitializeComponent();
            listQizz = qList;
            listQuestions = questionList;
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            string answer = txtAnswer.Text.Trim();
            if (!string.IsNullOrWhiteSpace(answer))
            {
                // Kiểm tra nếu câu trả lời chưa có trong list
                if (!lstAnswers.Items.Contains(answer))
                {
                    lstAnswers.Items.Add(answer);
                    txtAnswer.Clear();  // Clear input box sau khi thêm
                }
                else
                {
                    MessageBox.Show("Câu trả lời đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Câu trả lời không thể trống!");
            }
        }


        

        private void AddQuestion_Load_1(object sender, EventArgs e)
        {
            foreach (var quiz in listQizz)
            {
                clbQuizz.Items.Add(quiz);
            }
            clbQuizz.DisplayMember = "Name";
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

            // Tạo đối tượng Question mới và thêm vào danh sách
            Question newQ = new Question(id, content, selectedQuizzIds, answers);
            listQuestions.Add(newQ);

            MessageBox.Show("Thêm câu hỏi thành công!");
            this.Close();
        }

        private void btnAddAnswer_Click_1(object sender, EventArgs e)
        {
            string answer = txtAnswer.Text.Trim();
            if (!string.IsNullOrWhiteSpace(answer))
            {
                // Kiểm tra nếu câu trả lời chưa có trong list
                if (!lstAnswers.Items.Contains(answer))
                {
                    lstAnswers.Items.Add(answer);
                    txtAnswer.Clear();  // Clear input box sau khi thêm
                }
                else
                {
                    MessageBox.Show("Câu trả lời đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Câu trả lời không thể trống!");
            }
        }
    }
}
