using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatExam
{
    class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public Answer(string answerText, int answerId)
        {
            AnswerText = answerText;
            AnswerId = answerId;
        }
    }
}
