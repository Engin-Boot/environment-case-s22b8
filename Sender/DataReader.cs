using System;
using System.IO;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Sender
{
    public interface IDataReader
    {
        StreamReader ReadData(String fileName);
    }

    public class ReadFromCsv : IDataReader
    {
        public StreamReader ReadData(String fileName)
        {

            StreamReader reader = new StreamReader(File.OpenRead(fileName));
            return reader;
        }
    }

}
