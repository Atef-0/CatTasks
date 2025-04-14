using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatExam.Questions
{
    class TorF : Question
    {
        public bool CorrectAnswer { get; set; }
        public TorF(string header, string body, int mark, bool correctAnswer) : base(header, body, mark)
        {
            CorrectAnswer = correctAnswer;
        }
        
    }
    
}

