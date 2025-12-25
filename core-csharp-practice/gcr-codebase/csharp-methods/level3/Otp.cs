using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl3
{
    class Otp
    {
        static int generateOtp()
        {
            Random r = new Random();
            int otp = r.Next(100000, 1000000);
            return otp;
        }

        static bool checkUnique(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] otps = new int[10];
            for (int i = 0; i < otps.Length; i++)
            {
                otps[i] = generateOtp();
            }
            Console.WriteLine("Generated OTPs:");
            for (int i = 0; i < otps.Length; i++)
            {
                Console.WriteLine(otps[i]);
            }
            bool res= checkUnique(otps);
            if (res) Console.WriteLine("All OTPs are unique");
            else Console.WriteLine("OTPs are not unique");

        }
    }

}
