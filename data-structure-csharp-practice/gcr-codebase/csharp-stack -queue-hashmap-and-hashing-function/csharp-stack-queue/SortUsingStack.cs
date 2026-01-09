using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Stack___Queue__HashMap_and_Hashing_Function
{
    class SortUsingStack
    {
        Stack<int> st = new Stack<int>();
        public void Push(int value)
        {
            st.Push(value);
        }
        public void SortStack()
        {
            if (st.Count <= 1)
                return;
            int top = st.Pop();
            SortStack();
            InsertSorted(top);
        }
        private void InsertSorted(int value)
        {
            if (st.Count == 0 || st.Peek() <= value)
            {
                st.Push(value);
                return;
            }
            int temp = st.Pop();
            InsertSorted(value);
            st.Push(temp);
        }
        public void PrintStackAscending()
        {
            int[] arr = st.ToArray();   
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            SortUsingStack s = new SortUsingStack();
            s.Push(30);
            s.Push(10);
            s.Push(50);
            s.Push(20);
            Console.WriteLine("Before Sorting:");
            s.PrintStackAscending();
            s.SortStack();
            Console.WriteLine("Stack in ascending order: ");
            s.PrintStackAscending();
        }
    }

}
