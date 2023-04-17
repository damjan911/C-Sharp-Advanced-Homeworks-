using Homework1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Entities
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }
        public Student() { }

        public Student(int id, string name, string userName, string password, List<int> grades) 
        { 
            Id = id;
            Name = name;
            UserName = userName;
            Password = password;
            Grades = grades;
        }

        public override void PrintUser()
        {
            base.PrintUser();
            foreach (var item in Grades)
            {
                Console.WriteLine(item);
            }
        }
    }
}
