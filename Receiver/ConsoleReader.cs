using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    class ConsoleReader
    {
        public DataRecord data;
        public DataRecord ReadConsole()
        {
<<<<<<< HEAD
            //string val;
            Console.ReadLine();
            return data;

=======
            string val;
            val = Console.ReadLine();
            string[] lines = val.Split(new[] { Environment.NewLine },StringSplitOptions.None);
            data.Time = Convert.ToDateTime(lines[0]);
            data.Temperature = Convert.ToInt32(lines[1]);
            data.Humidity = Convert.ToInt32(lines[2]);
            return data;
>>>>>>> d77380c0631cd3123c98ce263c74eb1cf22642cd
        }
    }
}
