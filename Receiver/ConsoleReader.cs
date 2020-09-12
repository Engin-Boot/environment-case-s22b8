using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    class ConsoleReader
    {
        public DataRecord data = new DataRecord();


        public DataRecord ReadConsole()
        {
            string line;
            line = Console.ReadLine();
            var lines = line.Split(',').ToList();
            this.data.Time = Convert.ToDateTime(lines[0]);
            this.data.Temperature = Convert.ToInt32(lines[1]);
            this.data.Humidity = Convert.ToInt32(lines[2]);
            return this.data;
        }
    }
}
