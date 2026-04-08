using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace bridge.DSA_Senario
{
    class PageNode
    {
        public string url;
        public PageNode prev;
        public PageNode next;
        public PageNode(string url)
        {
            this.url = url;
            prev = null;
            next = null;
        }
    }
    class BrowserBuddy
    {
        PageNode current;
        Stack<PageNode> closedTabs = new Stack<PageNode>();
        public void Visit(string url)
        {
            PageNode newPage = new PageNode(url);
            if (current != null)
            {
                current.next = newPage;
                newPage.prev = current;
            }
            current = newPage;
            Console.WriteLine("Visited on website " + url);
        }
        public void Back()
        {
            if (current != null && current.prev != null)
            {
                current = current.prev;
                Console.WriteLine("Back to " + current.url);
            }
            else Console.WriteLine("No previous page");
        }
        public void Forward()
        {
            if (current != null && current.next != null)
            {
                current = current.next;
                Console.WriteLine("Forward to " + current.url);
            }
            else Console.WriteLine("No next page");
        }
        public void CloseTab()
        {
            if (current == null)
            {
                Console.WriteLine("No tab to close.");
                return;
            }
            closedTabs.Push(current);
            Console.WriteLine("Closed tab: " + current.url);
            if (current.prev != null)
            {
                current = current.prev;
                current.next = null;
            }
            else
            {
                current = null;
            }
        }
        public void RestoreTab()
        {
            if (closedTabs.Count == 0)
            {
                Console.WriteLine("No closed tabs to restore.");
                return;
            }

            current = closedTabs.Pop();
            Console.WriteLine("Restored tab  " + current.url);
        }
        public void ShowCurrent()
        {
            if (current != null)
                Console.WriteLine("Current Page " + current.url);
            else
                Console.WriteLine("No page opened");
        }
        class Menu
        {
            public void ShowMenu()
            {
                BrowserBuddy browser = new BrowserBuddy();
                int choice;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("--- BrowserBuddy Menu ---");
                    Console.WriteLine("1. Visit Page");
                    Console.WriteLine("2. Back");
                    Console.WriteLine("3. Forward");
                    Console.WriteLine("4. Close Tab");
                    Console.WriteLine("5. Restore Closed Tab");
                    Console.WriteLine("6. Show Current Page");
                    Console.WriteLine("0. Exit");
                    Console.Write("Enter choice: ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter URL: ");
                            browser.Visit(Console.ReadLine());
                            break;
                        case 2:
                            browser.Back();
                            break;
                        case 3:
                            browser.Forward();
                            break;
                        case 4:
                            browser.CloseTab();
                            break;
                        case 5:
                            browser.RestoreTab();
                            break;
                        case 6:
                            browser.ShowCurrent();
                            break;
                    }

                } while (choice != 0);
            }
        }
        class StartApp
        {
            static void Main()
            {
                new Menu().ShowMenu();
            }
        }

    }
   
}
