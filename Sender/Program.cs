using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{

    interface IDataReader
    {
        void ReadData();
    }

    class DataReader : IDataReader
    {
       
        public void ReadData()
        {
            Console.WriteLine("heyy");
        }
    }

    class Program
    {   


        static void Main(string[] args)
        {
        }
    }
}
