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
    public partial class frmAdmin : Form
    {
        List<Quizz> listQizz = new List<Quizz>();
        List<User> listUsers = new List<User>();
        List<Question> listQuestions = new List<Question>();

        public frmAdmin()
        {
            InitializeComponent();
            this.Resize += new EventHandler(frmAdmin_Resize);
        }

        private void frmAdmin_Resize(object sender, EventArgs e)
        {
            panel1.Height = this.ClientSize.Height;
            panel1.Width = (int)(this.ClientSize.Width * 1 / 3);

            panel2.Width = this.ClientSize.Width - panel1.Width;
            panel2.Height = this.ClientSize.Height;
            panel2.Left = panel1.Right;
            panel2.Top = 0;

        }

       

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            panel1.Width = (int)(this.ClientSize.Width * 1 / 3);
            panel1.Height = this.ClientSize.Height;

            panel2.Width = this.ClientSize.Width - panel1.Width;
            panel2.Height = this.ClientSize.Height;
            panel2.Left = panel1.Right;
            panel2.Top = 0;

            listQizz.Add(new Quizz("1", "My Country ", "ABCD"));
            listQizz.Add(new Quizz("2", "My Family ", "AHFWF"));
            listQizz.Add(new Quizz("3", "My Hometown ", "DWFW"));

            datagrdQuizzView.DataSource = listQizz;

            listUsers.Add(new User("U1", "admin" ,"abc@gmail.com" , "123456","Admin"));
            listUsers.Add(new User("U2", "user1","xyz@gmail.com", "123456","User"));
            datagrdUserView.Visible = false;

            listQuestions.Add(new Question("Q1", "ABC", new List<string> { "1","2"}, new List<string> { "Dung","Sai","Not given","All Correct"}));
            List<QuestionView> displayList = listQuestions.Select(q => new QuestionView(q)).ToList();
            datagrdQuestionView.DataSource = displayList;
            datagrdQuestionView.Visible = false;


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (datagrdQuizzView.Visible)
            {
                AddQuizz frmAdd = new AddQuizz(listQizz);
                frmAdd.ShowDialog();
                datagrdQuizzView.DataSource = null;
                datagrdQuizzView.DataSource = listQizz;
            }
            else if (datagrdUserView.Visible)
            {
                AddUser frmAdd = new AddUser(listUsers);
                frmAdd.ShowDialog();
                datagrdUserView.DataSource = null;
                datagrdUserView.DataSource = listUsers;
            }
            else if (datagrdQuestionView.Visible) {
                AddQuestion addQuestion = new AddQuestion(listQizz, listQuestions);
                addQuestion.ShowDialog();
                datagrdQuestionView.DataSource = null;
                datagrdQuestionView.DataSource = listQuestions.Select(q => new QuestionView(q)).ToList();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ( datagrdQuizzView.Visible)
            {
                if (datagrdQuizzView.CurrentRow != null)
                {
                    int index = datagrdQuizzView.CurrentRow.Index;
                    if (index >= 0 && index < listQizz.Count)
                    {
                        listQizz.RemoveAt(index);
                        datagrdQuizzView.DataSource = null;
                        datagrdQuizzView.DataSource = listQizz;
                    }
                }
            }
            else if (datagrdUserView.Visible)
            {
                if ( datagrdUserView.CurrentRow != null)
                {
                    int indexUser = datagrdUserView.CurrentRow.Index;
                    if (indexUser >= 0 && indexUser < listUsers.Count)
                    {
                        listUsers.RemoveAt(indexUser);
                        datagrdUserView.DataSource = null;
                        datagrdUserView.DataSource = listUsers;
                    }
                }
            }

            else if (datagrdQuestionView.Visible)
            {
                if(datagrdQuestionView.CurrentRow != null)
                {
                    int indexQuestion = datagrdQuestionView.CurrentRow.Index;
                    if (indexQuestion >= 0 && indexQuestion < listQuestions.Count)
                    {
                        listQuestions.RemoveAt(indexQuestion);
                        datagrdQuestionView.DataSource = null;
                        datagrdQuestionView.DataSource = listQuestions.Select(q => new QuestionView(q)).ToList();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (datagrdQuizzView.Visible)
            {
                if (datagrdQuizzView.CurrentRow != null)
                {
                    int index = datagrdQuizzView.CurrentRow.Index;
                    if (index >= 0 && index < listQizz.Count)
                    {
                        Quizz quizToEdit = listQizz[index];
                        UpdateQuizz formEdit = new UpdateQuizz(quizToEdit);
                        if (formEdit.ShowDialog() == DialogResult.OK)
                        {
                            datagrdQuizzView.DataSource = null;
                            datagrdQuizzView.DataSource = listQizz;
                        }
                    }
                }
            }
            else if (datagrdUserView.Visible)
            {
                int indexUser = datagrdUserView.CurrentRow.Index;
                if (indexUser >= 0 && indexUser < listUsers.Count)
                { 
                    User user = listUsers[indexUser];
                    UpdateUser updateUser = new UpdateUser(user);
                    if (updateUser.ShowDialog() == DialogResult.OK) { 
                        datagrdUserView.DataSource = null;
                        datagrdUserView.DataSource = listUsers;
                    }
                }
            }

            else if (datagrdQuestionView.Visible)
            {
                if (datagrdQuestionView.CurrentRow != null)
                {
                    int index = datagrdQuestionView.CurrentRow.Index;
                    if (index >= 0 && index < listQuestions.Count)
                    {
                        // Lấy câu hỏi cần chỉnh sửa
                        Question questionToEdit = listQuestions[index];

                        // Mở form UpdateQuestion và truyền dữ liệu vào
                        UpdateQuestion updateForm = new UpdateQuestion(listQizz, listQuestions, questionToEdit, index);
                        updateForm.ShowDialog();

                        // Cập nhật lại DataGridView sau khi chỉnh sửa
                        datagrdQuestionView.DataSource = null;
                        datagrdQuestionView.DataSource = listQuestions.Select(q => new QuestionView(q)).ToList();
                    }
                }
            }
           

        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            datagrdQuizzView.Visible = false;
            datagrdUserView.Visible = true;
            datagrdQuestionView.Visible = false;

            datagrdUserView.DataSource = null;
            datagrdUserView.DataSource = listUsers;
        }

        private void btnQuizz_Click(object sender, EventArgs e)
        {
            datagrdQuizzView.Visible = true;
            datagrdUserView.Visible = false;
            datagrdQuestionView.Visible= false;

            datagrdQuizzView.DataSource = null;
            datagrdQuizzView.DataSource = listQizz;

        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            datagrdQuizzView.Visible = false;
            datagrdUserView.Visible = false;
            datagrdQuestionView.Visible = true;

            datagrdQuestionView.DataSource = null;
            datagrdQuestionView.DataSource = listQuestions.Select(q => new QuestionView(q)).ToList();

            datagrdQuestionView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datagrdQuestionView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void datagrdUserView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
