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
        public string line = String.Empty;
        public DataRecord ReadConsole()
        {
            if (String.IsNullOrEmpty(line)) {
                line = Console.ReadLine();
            }
            var lines = line.Split(',').ToList();
            try
            {
                this.data.Time = Convert.ToDateTime(lines[0]);
            }
            catch (Exception e)
            {
                this.data.Time = DateTime.ParseExact(lines[0], "dd/MM/yyyy HH:mm", null);
            }

            this.data.Temperature = Convert.ToInt32(lines[1]);
            this.data.Humidity = Convert.ToInt32(lines[2]);
            return this.data;
        }
    }
}
