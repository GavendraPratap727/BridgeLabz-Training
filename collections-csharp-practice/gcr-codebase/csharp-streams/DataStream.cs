using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Streams
{
    internal class DataStream
    {
        static void Main()
        {
            string filePath = "student.dat";

            FileStream writeStream = null;
            FileStream readStream = null;
            BinaryWriter writer = null;
            BinaryReader reader = null;

            try
            {
                // Write student data
                writeStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                writer = new BinaryWriter(writeStream);

                int rollNumber = 101;
                string name = "Gavendra";
                double gpa = 8.4;

                writer.Write(rollNumber);
                writer.Write(name);
                writer.Write(gpa);

                writer.Close();
                writeStream.Close();

                Console.WriteLine("Student data saved successfully.\n");

                // Read student data
                readStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                reader = new BinaryReader(readStream);

                int savedRoll = reader.ReadInt32();
                string savedName = reader.ReadString();
                double savedGpa = reader.ReadDouble();

                Console.WriteLine("Student Details from File:");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Roll Number: " + savedRoll);
                Console.WriteLine("Name: " + savedName);
                Console.WriteLine("GPA: " + savedGpa);
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                if (writer != null)
                    writer.Close();

                if (readStream != null)
                    readStream.Close();

                if (writeStream != null)
                    writeStream.Close();
            }
        }
    }
}
