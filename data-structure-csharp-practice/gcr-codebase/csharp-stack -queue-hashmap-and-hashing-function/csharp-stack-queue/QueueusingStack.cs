using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Stack___Queue__HashMap_and_Hashing_Function
{
    internal class QueueusingStack
    {
        Stack<int> InStack = new Stack<int>();
        Stack<int> OutStack= new Stack<int>();
        public void Enqueue(int val) {
            InStack.Push(val);
            Console.WriteLine(val +" is added into the queue");
        }
        public void Dequeue() {
            if (InStack.Count == 0 && OutStack.Count == 0) {
                Console.WriteLine("Queue is empty");
                return;
            }
            if (OutStack.Count == 0) {
                while (InStack.Count > 0) { 
                    OutStack.Push(InStack.Pop());
                }
            }
            Console.WriteLine(OutStack.Pop() + " Dequeued");

        }
        public void PrintQueue() {
            if (InStack.Count == 0 && OutStack.Count == 0)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            foreach (int item in OutStack)
            {
                Console.Write(item + " ");
            }
            int[] temp = InStack.ToArray();
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                Console.Write(temp[i] + " ");
            }
        }
        public static void Main(String[] args) {
            QueueusingStack q = new QueueusingStack();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(35);
            q.Enqueue(45);
            q.Dequeue();
            q.Enqueue(5);
            q.Dequeue();
            q.Dequeue();
            q.Enqueue(61);
            q.PrintQueue();
        }
    }
}
