using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Sender
{
    class Program
    {   
        static void Main(string[] args)
        {
            Thread.Sleep(2000);
            DataSender dataReader=new DataSender();
            dataReader.ModifyData();
        }
    }
}
