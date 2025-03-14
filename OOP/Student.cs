using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//Properties:
//-Name
//- Age
//- Grade
namespace OOP
{
    class Student
    {
        
        protected string name;
        protected int age;
        protected float grade;
        public Student(string name,int age,float grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
        public string Name { 
            get => this.Name ; 
        }
        public int Age {
            get
            {
                return this.age;
            }  
        }
        public float Grade { get => this.Grade; set => this.grade =value; }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Student Name: {name}\nStudent Age: {age}\nStudent Grade: {grade}\n");
        }

    }
}
