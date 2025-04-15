using CatExam.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatExam
{
    class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public FinalExam SubjectMCQExam { get; set; }
        public PracticalExam SubjectPracticalExam { get; set; }
        public List<Question> Questions { get; set; }
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }
        public void CreateExam(int numberOfQuestions, DateTime timeOfExam, bool isFinal)
        {
            if(isFinal)
            {
                string type;
                for (int i = 0; i < numberOfQuestions; i++)
                {
                    Console.WriteLine("Enter Question type:(MCQ/TF)");
                    type = Console.ReadLine();
                    if (type=="MCQ")
                    {
                        createMCQ();
                    }
                    else
                    {
                        createTF();
                    }
                }
                SubjectMCQExam = new FinalExam(numberOfQuestions, timeOfExam, Questions,this);
            }
            else
            {
                for (int i = 0; i < numberOfQuestions; i++)
                {
                    createTF();
                }
                SubjectPracticalExam = new PracticalExam(numberOfQuestions, timeOfExam, Questions,this);
            }


        }
        public void createMCQ()
        {
            var HBM = getHBM();
            Console.WriteLine("Enter the answers");
            Answer[] answers = new Answer[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the answer");
                string answerBody = Console.ReadLine();
                Console.WriteLine("Enter the answer id");
                int answerId = int.Parse(Console.ReadLine());
                answers[i] = new Answer(answerBody, answerId);
            }
            Console.WriteLine("Enter the correct answer id");
            int correctAnswerId = int.Parse(Console.ReadLine());
            Questions.Add(new MCQ(HBM.header, HBM.body, HBM.mark,answers,correctAnswerId));
        }
        public void createTF()
        {
            var HBM=getHBM();
            Console.WriteLine("Enter the correct answer (true/false)");
            bool correctAnswer = bool.Parse(Console.ReadLine());
            Questions.Add(new TorF(HBM.header, HBM.body, HBM.mark, correctAnswer));
        }
        public (string header,string body,int mark) getHBM()
        {
            Console.WriteLine("Enter the question header");
            string header = Console.ReadLine();
            Console.WriteLine("Enter the question body");
            string body = Console.ReadLine();
            Console.WriteLine("Enter the question mark");
            int mark = int.Parse(Console.ReadLine());
            return (header, body, mark);
        } 
        public void getAnswers(Answer[] answers)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the answer");
                string answerBody = Console.ReadLine();
                Console.WriteLine("Enter the answer id");
                int answerId = int.Parse(Console.ReadLine());
                answers[i] = new Answer(answerBody, answerId);
            }
        }
    }
}
