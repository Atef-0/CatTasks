using CatExam.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatExam
{
    abstract class Exam
    {
        public DateTime TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public Subject Subject { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
        public Exam(int numberOfQuestions, DateTime timeOfExam, List<Question> questions, Subject subject)
        {
            NumberOfQuestions = numberOfQuestions;
            TimeOfExam = timeOfExam;
            Questions = questions;
            Subject = subject;
        }

        public abstract void ShowExam();
    }
}
