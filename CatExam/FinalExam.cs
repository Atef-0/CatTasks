using CatExam.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatExam
{
    class FinalExam : Exam
    {
        public FinalExam(int numberOfQuestions, DateTime timeOfExam, List<Question> questions, Subject subject) : base(numberOfQuestions, timeOfExam, questions, subject)
        {
        }
        

        public override void ShowExam()
        {
            Console.WriteLine("FINAL EXAM");
            foreach (var question in Questions)
            {
                Console.WriteLine($"[{question.Header}] {question.Body}");
                Console.WriteLine($"Marks: {question.Mark}");

                if (question is TorF tf)
                {
                    Console.WriteLine("a- True\nb- False");
                }
                else if (question is MCQ mcq)
                {
                    foreach (var answer in mcq.Answers)
                    {
                        Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
