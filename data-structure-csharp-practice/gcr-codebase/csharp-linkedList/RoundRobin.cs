using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.LinkedListttt
{
   
        class Process
        {
            public int pid;
            public int burst;
            public int remaining;
            public int priority;
            public int waiting;
            public int turnaround;
            public Process next;

            public Process(int pid, int burst, int priority)
            {
                this.pid = pid;
                this.burst = burst;
                this.remaining = burst;
                this.priority = priority;
                next = null;
            }
        }
        class Scheduler
        {
            Process head = null;

            public void AddProcess(int pid, int burst, int priority)
            {
                Process p = new Process(pid, burst, priority);

                if (head == null)
                {
                    head = p;
                    p.next = head;
                    return;
                }

                Process temp = head;
                while (temp.next != head)
                {
                    temp = temp.next;
                }

                temp.next = p;
                p.next = head;
            }

            public void RunRoundRobin(int quantum)
            {
                if (head == null)
                {
                    Console.WriteLine("No processes");
                    return;
                }

                int time = 0;
                int count = CountProcesses();
                Process curr = head;

                while (count > 0)
                {
                    DisplayQueue();

                    if (curr.remaining > 0)
                    {
                        if (curr.remaining > quantum)
                        {
                            curr.remaining -= quantum;
                            time += quantum;
                        }
                        else
                        {
                            time += curr.remaining;
                            curr.remaining = 0;
                            curr.turnaround = time;
                            curr.waiting = curr.turnaround - curr.burst;
                            count--;
                            Console.WriteLine("Process " + curr.pid + " completed");
                        }
                    }

                    curr = curr.next;
                }

                CalculateAverage();
            }

            void DisplayQueue()
            {
                Process temp = head;
                Console.Write("Queue: ");

                do
                {
                    Console.Write("[P" + temp.pid + " RT:" + temp.remaining + "] ");
                    temp = temp.next;
                }
                while (temp != head);

                Console.WriteLine();
            }

            int CountProcesses()
            {
                if (head == null) return 0;

                int c = 0;
                Process temp = head;
                do
                {
                    c++;
                    temp = temp.next;
                }
                while (temp != head);

                return c;
            }

            void CalculateAverage()
            {
                Process temp = head;
                int totalWait = 0;
                int totalTurn = 0;
                int n = CountProcesses();

                do
                {
                    totalWait += temp.waiting;
                    totalTurn += temp.turnaround;
                    temp = temp.next;
                }
                while (temp != head);

                Console.WriteLine("Average Waiting Time: " + (double)totalWait / n);
                Console.WriteLine("Average Turnaround Time: " + (double)totalTurn / n);
            }
        }

        class RoundRobin
        {
            static void Main(string[] args)
            {
                Scheduler s = new Scheduler();

                s.AddProcess(1, 10, 1);
                s.AddProcess(2, 5, 2);
                s.AddProcess(3, 8, 1);
                s.AddProcess(4, 6, 3);

                int timeQuantum = 3;
                Console.WriteLine("Time Quantum = " + timeQuantum);
                s.RunRoundRobin(timeQuantum);
            }
        }
    }


