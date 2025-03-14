using Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Gender
    {
        M, 
        F
    }
enum SecurityLevel
{
    Guest,
    Developer,
    Secretary,
    DBA
}

namespace Company
{
    
    class Employee
    {
        public int ID { get; }
        public string Name { get; }
        public SecurityLevel Security { get; set; }  
        public decimal Salary { get; set; }
        public DateTime HireDate { get; }
        public Gender Gender { get; }  

        public Employee(int id, string name, SecurityLevel security, decimal salary, DateTime hireDate, Gender gender)
        {
            ID = id;
            Name = name;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security Level: {Security}, {String.Format($"Salary: {Salary}:C")}, Hire Date: {String.Format($"Day-Month-Year: {HireDate:dd-MM-yyyy}")}";
        }
    }
}
