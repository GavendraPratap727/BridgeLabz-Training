using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.DSA_Senario.ExamProctor
{
    //main class
    internal class ExamProctorApp
    {
        //main method
        static void Main(string[] args) {
            new ExamMenu().Start(); //calling non static method named start in the calss ExamMenu
        }
    }
}
