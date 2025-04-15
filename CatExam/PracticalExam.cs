using CatExam.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatExam
{
    class PracticalExam : Exam
    {
        public PracticalExam(int numberOfQuestions, DateTime timeOfExam, List<Question> questions, Subject subject) : base(numberOfQuestions, timeOfExam, questions, subject)
        {
        }
        public override void ShowExam()
        {
            Console.WriteLine("PRACTICAL EXAM");
            foreach (var question in Questions)
            {
                Console.WriteLine($"[{question.Header}] {question.Body}");
                Console.WriteLine($"Marks: {question.Mark}");
                Console.WriteLine("1. True\n2. False");
                Console.WriteLine();
            }
        }
    }
}
