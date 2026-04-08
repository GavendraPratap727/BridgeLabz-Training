using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Streams
{
    internal class PipedStream
    {
        static void Main()
        {
            try
            {
                // Create pipe for inter-thread communication
                AnonymousPipeServerStream pipeServer =
                    new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable);

                AnonymousPipeClientStream pipeClient =
                    new AnonymousPipeClientStream(PipeDirection.In, pipeServer.GetClientHandleAsString());

                Thread writerThread = new Thread(() => WriteData(pipeServer));
                Thread readerThread = new Thread(() => ReadData(pipeClient));

                writerThread.Start();
                readerThread.Start();

                writerThread.Join();
                readerThread.Join();

                pipeServer.Dispose();
                pipeClient.Dispose();
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void WriteData(AnonymousPipeServerStream pipe)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(pipe, Encoding.UTF8))
                {
                    writer.AutoFlush = true;

                    writer.WriteLine("Hello from Writer Thread");
                    Thread.Sleep(500);

                    writer.WriteLine("This data is sent through PipeStream");
                    Thread.Sleep(500);

                    writer.WriteLine("End of message");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Writer Error: " + ex.Message);
            }
        }

        static void ReadData(AnonymousPipeClientStream pipe)
        {
            try
            {
                using (StreamReader reader = new StreamReader(pipe, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine("Reader received: " + line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Reader Error: " + ex.Message);
            }
        }
    }
}
