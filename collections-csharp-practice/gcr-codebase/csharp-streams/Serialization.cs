using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace BridgeLabz.Collections.Streams
{
    class Employee
    {
        public int id;
        public string name;
        public string department;
        public double salary;
    }

    internal class SerializationDemo
    {
        static void Main()
        {
            string filePath = "employees.json";

            try
            {
                // Create employee list
                List<Employee> employees = new List<Employee>();

                employees.Add(new Employee { id = 1, name = "Amit", department = "IT", salary = 45000 });
                employees.Add(new Employee { id = 2, name = "Riya", department = "HR", salary = 38000 });
                employees.Add(new Employee { id = 3, name = "Karan", department = "Finance", salary = 52000 });

                // Serialize (save to file)
                string jsonData = JsonSerializer.Serialize(employees);
                File.WriteAllText(filePath, jsonData);

                Console.WriteLine("Employees saved successfully.\n");

                // Deserialize (read from file)
                string readData = File.ReadAllText(filePath);
                List<Employee> savedEmployees =
                    JsonSerializer.Deserialize<List<Employee>>(readData);

                // Display data
                Console.WriteLine("Employee Details from File:");
                Console.WriteLine("---------------------------");

                foreach (Employee emp in savedEmployees)
                {
                    Console.WriteLine("ID: " + emp.id);
                    Console.WriteLine("Name: " + emp.name);
                    Console.WriteLine("Department: " + emp.department);
                    Console.WriteLine("Salary: " + emp.salary);
                    Console.WriteLine();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
