using Homework1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Entities
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; }

        public Teacher() { }

        public Teacher(int id, string name, string userName, string password, string subject)
        {
            Id = id;
            Name = name;
            UserName = userName;
            Password = password;
            Subject = subject;
        }

        public override void PrintUser()
        {
            base.PrintUser();
            Console.WriteLine(Subject);
        }
    }
}
