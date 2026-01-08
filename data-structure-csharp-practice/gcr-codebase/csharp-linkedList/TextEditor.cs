using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.LinkedListttt
{
    class TextEditor
    {
        static LinkedList<string> history = new LinkedList<string>();
        static LinkedListNode<string> current = null;
        const int LIMIT = 10;
        static void Main(string[] args)
        {
            AddState("Hello");
            AddState("Hello World");
            AddState("Hello World!");
            AddState("Hello World! How");
            AddState("Hello World! How are you");
            ShowCurrent();
            Undo();
            Undo();
            ShowCurrent();
            Redo();
            ShowCurrent();
            AddState("Hello World How are you today?");
            ShowCurrent();
        }
        static void AddState(string text)
        {
            if (current != null)
            {
                while (current.Next != null)
                    history.Remove(current.Next);
            }
            history.AddLast(text);
            current = history.Last;

            if (history.Count > LIMIT)
            {
                history.RemoveFirst();
            }
        }
        static void Undo()
        {
            if (current != null && current.Previous != null)
            {
                current = current.Previous;
                Console.WriteLine("Undo performed");
            }
            else
            {
                Console.WriteLine("Nothing to undo");
            }
        }

        static void Redo()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Redo performed");
            }
            else
            {
                Console.WriteLine("Nothing to redo");
            }
        }

        static void ShowCurrent()
        {
            if (current != null)
                Console.WriteLine("Current Text: " + current.Value);
            else
                Console.WriteLine("No text available");
        }
    }
    }
