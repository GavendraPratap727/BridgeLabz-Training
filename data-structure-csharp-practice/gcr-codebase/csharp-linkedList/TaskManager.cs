using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.LinkedListttt
{
    using System;

namespace TaskSchedulerApp
{
    class Task
    {
        public int id;
        public string name;
        public int priority;
        public string dueDate;
        public Task next;
        public Task(int id, string name, int priority, string dueDate)
        {
            this.id = id;
            this.name = name;
            this.priority = priority;
            this.dueDate = dueDate;
            next = null;
        }
    }
    class TaskManager
    {
        Task head = null;
        Task currentTask = null;
        public void AddTaskAtStart(int id, string name, int priority, string dueDate)
        {
            Task newTask = new Task(id, name, priority, dueDate);
            if (head == null)
            {
                head = newTask;
                newTask.next = head;
                currentTask = head;
                return;
            }
            Task temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }
            newTask.next = head;
            temp.next = newTask;
            head = newTask;
        }
        public void AddTaskAtEnd(int id, string name, int priority, string dueDate)
        {
            Task newTask = new Task(id, name, priority, dueDate);
            if (head == null)
            {
                head = newTask;
                newTask.next = head;
                currentTask = head;
                return;
            }
            Task temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }
            temp.next = newTask;
            newTask.next = head;
        }
        public void AddTaskAtPosition(int position, int id, string name, int priority, string dueDate)
        {
            if (position <= 1)
            {
                AddTaskAtStart(id, name, priority, dueDate);
                return;
            }
            Task temp = head;
            for (int i = 1; i < position - 1 && temp.next != head; i++)
            {
                temp = temp.next;
            }
            Task newTask = new Task(id, name, priority, dueDate);
            newTask.next = temp.next;
            temp.next = newTask;
        }
        public void RemoveTask(int id)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }
            Task temp = head;
            Task prev = null;
            do
            {
                if (temp.id == id)
                {
                    if (temp == head)
                    {
                        Task last = head;
                        while (last.next != head)
                        {
                            last = last.next;
                        }
                        head = head.next;
                        last.next = head;
                        Console.WriteLine("Task removed.");
                        return;
                    }
                    prev.next = temp.next;
                    Console.WriteLine("Task removed.");
                    return;
                }
                prev = temp;
                temp = temp.next;

            } while (temp != head);

            Console.WriteLine("Task not found.");
        }
        public void ShowNextTask()
        {
            if (currentTask == null)
            {
                Console.WriteLine("No tasks to show.");
                return;
            }
            Console.WriteLine($"Task ID: {currentTask.id}, Name: {currentTask.name}, Priority: {currentTask.priority}, Due: {currentTask.dueDate}");
            currentTask = currentTask.next;
        }

        public void ShowAllTasks()
        {
            if (head == null)
            {
                Console.WriteLine("Task list is empty.");
                return;
            }
            Task temp = head;
            Console.WriteLine("\nTask List:");
            do
            {
                Console.WriteLine($"ID: {temp.id}, Name: {temp.name}, Priority: {temp.priority}, Due: {temp.dueDate}");
                temp = temp.next;
            }
            while (temp != head);
        }

        public void FindTaskByPriority(int priority)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }
            Task temp = head;
            bool found = false;
            do
            {
                if (temp.priority == priority)
                {
                    Console.WriteLine($"ID: {temp.id}, Name: {temp.name}, Due: {temp.dueDate}");
                    found = true;
                }
                temp = temp.next;
            }
            while (temp != head);
            if (!found)
                Console.WriteLine("No task found with this priority.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();
            manager.AddTaskAtEnd(1, "Submit Ka Assignment", 1, "10-Apr");
            manager.AddTaskAtEnd(2, "Project Work", 2, "20-Apr");
            manager.AddTaskAtStart(3, "Exam Preparation", 1, "15-Apr");
            manager.ShowAllTasks();
            Console.WriteLine("Next Tasks:");
            manager.ShowNextTask();
            manager.ShowNextTask();
            Console.WriteLine("Search Priority 1:");
            manager.FindTaskByPriority(1);
            Console.WriteLine("Remove Task ID 2:");
            manager.RemoveTask(2);
            manager.ShowAllTasks();
        }
    }
}

}
