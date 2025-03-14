using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    class PostGraduate : Student
    {
        public PostGraduate(string name, int age, float grade, string thesisTopic) : base(name, age, grade)
        {
            this.thesisTopic = thesisTopic;
        }
        private string thesisTopic;
        public string ThesisTopic => this.thesisTopic;
        public override void PrintDetails()
        {
            Console.WriteLine($"Graduate Name: {name}\nGraduate Age: {age}\nGraduate Grade: {grade}\nGraduate Thesis Topic: {thesisTopic}\n");
        }
    }
}
