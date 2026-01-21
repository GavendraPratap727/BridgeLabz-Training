using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Senario.EduStudent
{
    class Student
    {
        private string name;
        private int marks;

        public Student(string name, int marks)
        {
            this.name = name;
            this.marks = marks;
        }

        public string GetName()
        {
            return name;
        }

        public int GetMarks()
        {
            return marks;
        }
    }

}
