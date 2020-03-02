using System;
using System.IO;
using System.Text;
using System.Text.Unicode;

namespace lab_57_streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Delete("data.txt");

           // create file (APPEND, UTF8, BUFFER 1024)
           using (var writer = new StreamWriter("data.txt",true, Encoding.UTF8, 1024))
            {
                for (int i = 0; i< 10; i++)
                {
                    writer.WriteLine($"New log item {i} at {DateTime.Now}");
                }
            }


            // also could use FOR STRING OR ARRAY OF STRINGS  
            string OneExtraLine = "some more text";
           using (var writer = File.AppendText("data.txt"))
            {
                writer.WriteLine(OneExtraLine);
            }




            // read file
            string output = null;
            using (var reader = new StreamReader("data.txt"))
            {
                // 3 ways to read data
                // 1
                while ((output = reader.ReadLine()) != null){
                    Console.WriteLine(output);
                }
            }

            Console.WriteLine($"\n\nNow Getting Data Async\n");
            ReadDataAsync(); // off the mainry


            ReadAndWriteDataToMemory();  // simulate encryption module

            Console.WriteLine("\n\nProgram Has Terminated\n\n");
            Console.ReadLine();  // FAKE TERMINATION
        }

        static async void ReadDataAsync()
        {
            string lineofdata = null;

            using (var reader = new StreamReader("data.txt"))
            {
                // second version of getting data
                while (true)
                {
                    lineofdata = await reader.ReadLineAsync();
                    if (lineofdata == null) break;
                    Console.WriteLine(lineofdata);
                }


            }
        }

        static void ReadAndWriteDataToMemory() { 
            // wrapper around a Memory Stream : use in Security
            // destination assumed in RAM : system handle destination
            using (var memorystream = new MemoryStream())
            {
                // memory only operates with BYTE STREAM OF RAW BINARY 1/0 
                // does not use character stream
                var buffer = new byte[5];  // byte array (empty)
                                           // fill with binary data 
                buffer[0] = (int)'h';
                buffer[1] = (int)'e';
                buffer[2] = (int)'l';
                buffer[3] = (int)'l';
                buffer[4] = (int)'o';

                // send fake data 10 times
                for (int i = 0; i < 10; i++)
                {
                    memorystream.Write(buffer);
                }
                // force buffer to be sent
                memorystream.Flush();


                // read back with memory reader
                // but first reset pointer of stream to start
                memorystream.Position = 0;
                using (var reader = new StreamReader(memorystream))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
        }
    }
}
