using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.Stack___Queue__HashMap_and_Hashing_Function
{
    using System;
    using System.Collections.Generic;

    class StockSpanProblem
    {
        static void Main(String[]args)
        {
            int[] prices = {100,80,60,70,60,75,85};
            int n = prices.Length;
            int[] span = new int[n];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                {
                    stack.Pop();
                }
                span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
                stack.Push(i);
            }
            Console.WriteLine("Stock Prices:");
            foreach (int p in prices)
                Console.WriteLine(p+" ");
            Console.WriteLine("Stock Span:");
            foreach (int s in span)
                Console.Write(s+" ");
        }
    }

}
