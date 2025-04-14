using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatExam.Questions
{
    class MCQ : Question
    {
        public Answer[] Answers { get; set; }
        public int CorrectAnswerId { get; set; }
        public MCQ(string header, string body, int mark, Answer[] answers, int correctAnswerId) : base(header, body, mark)
        {
            Answers = answers;
            CorrectAnswerId = correctAnswerId;
        }
    }
}
