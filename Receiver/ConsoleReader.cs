using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Receiver
{
    class ConsoleReader
    {
        public DataRecord data = new DataRecord();

        public DataRecord ReadConsole()
        {
            string line;
            line = Console.ReadLine();
            if (line == null) {
                Console.WriteLine("line null");
            }
            var lines = line.Split(',').ToList();
            string fileName = @"C:\Users\320105541\OneDrive - Philips\Desktop\bootcamp\output.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes(lines[1]);
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes(lines[2]);
                    fs.Write(author, 0, author.Length);
                }
            }
            catch (Exception Ex)
            {
                //Console.WriteLine(Ex.ToString());
            }
            this.data.Time = DateTime.ParseExact(lines[0], "dd/MM/yyyy HH:mm", null);
            this.data.Temperature = Convert.ToInt32(lines[1]);
            this.data.Humidity = Convert.ToInt32(lines[2]);


            

            return this.data;
        }
    }
}
