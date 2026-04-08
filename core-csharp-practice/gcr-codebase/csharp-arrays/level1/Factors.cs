using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
     class Factors
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter a number to find its factor"); 
            int n= int.Parse(Console.ReadLine()); //input a number
            int maxFactor = 10;
            int[] fac = new int[maxFactor];
            int j= 0;
            for(int i = 1; i <= n / 2; i++)
            {
                if(n%i==0)
                {
                    if (j == maxFactor)
                    {
                        maxFactor = maxFactor * 2;
                        int[]temp=new int[maxFactor];
                        for (int k = 0; k < j; k++)
                        {
                            temp[k]=fac[k];
                        }
                        fac = temp;

                    }
                    fac[j++] = i;
                }
            }
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(fac[i]);
            }
            
                
            
        }
    }
}
