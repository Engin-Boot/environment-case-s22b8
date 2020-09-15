using System;
using System.IO;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

namespace Receiver
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter data");
            for (int i = 0; i < 10; i++)
            {
                ConsoleReader consoleReader = new ConsoleReader();
                DataRecord dataRecord = consoleReader.ReadConsole();
                Alerter alerter = new EmailAlert();
                Checker checker = new Checker(alerter);
                checker.Check(dataRecord);
            }
            
        }
    }
}
