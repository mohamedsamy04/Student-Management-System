using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    abstract class Student
    {
        public string Name;
        public string Email;
        public string Level;
        public string Id;
        public string Gpa;

        public abstract void Students(List<Student> students);
    }
}