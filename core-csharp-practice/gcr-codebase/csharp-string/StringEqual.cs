using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Strings
{

    public class StringEqual
    {

        static bool check(string s, string t) {
            if (s.Length != t.Length) {
                return false;
            }
            for (int i = 0; i < s.Length; i++) {
                if (s[i] != t[i]) {
                    return false;
                }
                
            }
            return true;
        }
   

       public  static void Main(String[] args) {
            Console.WriteLine("Enter 1st string");
            string s = Console.ReadLine(); //input 1st string 
            Console.WriteLine("Enter 2nd string"); //input 2nd string
            string t = Console.ReadLine();
            bool res1 = check(s, t); //call method to check both string equal or not
            bool res2= s.Equals(t);// using .equals() method to check both string equal or not
            Console.WriteLine("result by  using custom fun is both stirngs are equal " + res1);
            Console.WriteLine("result by  usning .equals() is both stirngs are equal " + res2);
            Console.WriteLine("both results are same and right");

        }

    }
}


