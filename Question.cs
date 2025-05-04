using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQuizz
{
    public class Question
    {
        String id, content;
        List<String> quizz_id;
        List<String> answers;

        public Question(string id, string content, List<string> quizz_id, List<string> answers)
        {
            this.Id = id;
            this.Content = content;
            this.Quizz_id = quizz_id;
            this.Answers = answers;
        }

        public string Id { get => id; set => id = value; }
        public string Content { get => content; set => content = value; }
        public List<string> Quizz_id { get => quizz_id; set => quizz_id = value; }
        public List<string> Answers { get => answers; set => answers = value; }
    }

}
