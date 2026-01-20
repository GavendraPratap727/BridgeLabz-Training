using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.DSA_Senario.PassworkCrackerApp
{
    class CrackerUtility : ICrackerUtility
    {
        private Password password;
        private bool found;
        private int attempts;

        // SMALL charset → PC SAFE
        private char[] charset = { 'a', 'b', 'c', '1', '2' };

        public void SetPassword(string pwd)
        {
            password = new Password(pwd);
            found = false;
            attempts = 0;
        }

        public void StartCrack()
        {
            char[] buffer = new char[password.Length()];
            Backtrack(buffer, 0);

            Console.WriteLine("\nAttempts Tried: " + attempts);
            Console.WriteLine("Time Complexity: O(k^n)");
            Console.WriteLine("Space Complexity: O(n)");
        }

        private void Backtrack(char[] buf, int index)
        {
            if (found) return;

            if (index == buf.Length)
            {
                attempts++;
                if (Match(buf))
                {
                    found = true;
                    Console.Write("Password Matched: ");
                    Print(buf);
                }
                return;
            }

            for (int i = 0; i < charset.Length; i++)
            {
                buf[index] = charset[i];
                Backtrack(buf, index + 1);
            }
        }

        private bool Match(char[] attempt)
        {
            char[] real = password.Get();
            for (int i = 0; i < real.Length; i++)
                if (real[i] != attempt[i]) return false;
            return true;
        }

        private void Print(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i]);
           Console.WriteLine();
        }
    }

}
