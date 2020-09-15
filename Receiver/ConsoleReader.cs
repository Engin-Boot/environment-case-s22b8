using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Receiver
{
    public class ConsoleReader
    {
        public DataRecord data = new DataRecord();

        public DataRecord ReadConsole()
        {
            string line;
            line = Console.ReadLine();
            if (line == null) {
                Console.WriteLine("line null");
                return this.data;
            }
            var lines = line.Split(',').ToList();

        
           
           
            this.data.Time = DateTime.ParseExact(lines[0], "dd/MM/yyyy HH:mm", null);

            this.data.Temperature = Convert.ToInt32(lines[1]);
            this.data.Humidity = Convert.ToInt32(lines[2]);


            

            return this.data;
        }
    }
}
