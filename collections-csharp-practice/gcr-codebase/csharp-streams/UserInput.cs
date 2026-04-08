using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Streams
{
    internal class UserInput
    {
        static void Main()
        {
            StreamReader inputReader = null;
            StreamWriter fileWriter = null;

            try
            {
                // StreamReader for console input
                inputReader = new StreamReader(Console.OpenStandardInput());

                Console.Write("Enter your name: ");
                string name = inputReader.ReadLine();

                Console.Write("Enter your age: ");
                string age = inputReader.ReadLine();

                Console.Write("Enter your favorite programming language: ");
                string language = inputReader.ReadLine();

                // StreamWriter for file output
                fileWriter = new StreamWriter("user_info.txt");

                fileWriter.WriteLine("Name: " + name);
                fileWriter.WriteLine("Age: " + age);
                fileWriter.WriteLine("Favorite Language: " + language);

                Console.WriteLine("\nData saved successfully into file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }
            finally
            {
                if (inputReader != null)
                    inputReader.Close();

                if (fileWriter != null)
                    fileWriter.Close();
            }
        }
    }
}
