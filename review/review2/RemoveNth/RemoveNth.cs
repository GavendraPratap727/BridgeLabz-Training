using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.RemoveNth
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int value)
        {
            data = value;
            next = null;
        }
    }
    class CustomLinkedList
    {
        Node head;
        public void Add(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }
        public void RemoveNthFromEnd(int n)
        {
            Node hatt= new Node(0);
            hatt.next = head;
            Node fast = hatt;
            Node slow = hatt;

            for (int i = 1; i <= n; i++)
            {
                fast = fast.next;
            }

            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;

            head = hatt.next;
        }
        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + "   ");
                temp = temp.next;
            }
        }
    }
    internal class RemoveNth
    {
        static void Main()
        {
            CustomLinkedList list = new CustomLinkedList();
            Console.WriteLine("ENter the number of number of element u want to add in the linked list");
            int n=int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter the " + (i + 1) + " elemet of the list  : ");
                list.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
            Console.WriteLine("Enter which element you want to remove");
            int remove = int.Parse(Console.ReadLine());
            Console.WriteLine("Original linkedlist");
            list.Print();
            list.RemoveNthFromEnd(remove);
            Console.WriteLine();
            Console.WriteLine("After removing the  "+remove +"th  Node from End");
            list.Print();
        }
    }
}
