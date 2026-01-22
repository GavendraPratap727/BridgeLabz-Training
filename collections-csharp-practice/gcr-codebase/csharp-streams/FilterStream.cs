using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Streams
{
    internal class FilterStream
    {
        static void Main()
        {
            string sourceFile = "input.txt";
            string targetFile = "output.txt";

            FileStream readFs = null;
            FileStream writeFs = null;
            BufferedStream bufferedRead = null;
            BufferedStream bufferedWrite = null;
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Input file not found.");
                    return;
                }

                // FileStream + BufferedStream + Encoding
                readFs = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
                bufferedRead = new BufferedStream(readFs);
                reader = new StreamReader(bufferedRead, Encoding.UTF8);

                writeFs = new FileStream(targetFile, FileMode.Create, FileAccess.Write);
                bufferedWrite = new BufferedStream(writeFs);
                writer = new StreamWriter(bufferedWrite, Encoding.UTF8);

                int ch;

                while ((ch = reader.Read()) != -1)
                {
                    char converted = char.ToLower((char)ch);
                    writer.Write(converted);
                }

                Console.WriteLine("File processed successfully.");
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
                if (writer != null)
                    writer.Close();

                if (reader != null)
                    reader.Close();

                if (bufferedRead != null)
                    bufferedRead.Close();

                if (bufferedWrite != null)
                    bufferedWrite.Close();

                if (readFs != null)
                    readFs.Close();

                if (writeFs != null)
                    writeFs.Close();
            }
        }
    }
}
