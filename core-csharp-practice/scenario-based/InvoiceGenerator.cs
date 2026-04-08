using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Senario
{
    class InvoiceGenerator
    {
        // Method to take invoice input and display total amount
        static void Invoice() {
            Console.WriteLine("Enter invoice details For ex-: Logo Design - 3000 INR, Web Page - 4500 INR");
            string input= Console.ReadLine();
            string[] task = ParseInvoice(input);
            double totleAmount = GetTotalAmount(task);
            Console.WriteLine("The totle invoice amount is " + totleAmount);
        }
        // Method to split invoice string and display task details
        static string[] ParseInvoice(string input) {
            string[]task=input.Split(',');
            Console.WriteLine("Invoice  details");
            foreach (string work in task) {
                string[] works = work.Split("-");
                Console.WriteLine("Task : "+works[0].Trim() + " Amount " + works[1].Trim());
            }
            return task;
        }
        // Method to calculate total invoice amount
        static double GetTotalAmount(string[] tasks) {
            double totle = 0;
            foreach(string task in tasks)
            {
                string[] parts = task.Split('-');
                string amount = parts[1].Replace("INR", "").Trim();
                totle += int.Parse(amount);
            }
            return totle;
        }
        // Main method – program execution starts here
        static void Main(String[] args) {
            Invoice(); // Calling Invoice method
        }
    }
}
