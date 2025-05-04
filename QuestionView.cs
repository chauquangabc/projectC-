using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQuizz
{
    public class QuestionView
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string QuizzIds { get; set; }
        public string Answers { get; set; }

        public QuestionView(Question q)
        {
            Id = q.Id;
            Content = q.Content;
            QuizzIds = string.Join("\r\n", q.Quizz_id);
            Answers = string.Join("\r\n", q.Answers);
        }
    }
}
