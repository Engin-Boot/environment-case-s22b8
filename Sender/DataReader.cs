using System;
using System.IO;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sender
{
    interface IDataReader
    {
        StreamReader ReadData(String fileName);
    }

    class ReadFromCsv : IDataReader
    {
        public StreamReader ReadData(String fileName)
        {

            StreamReader reader = new StreamReader(File.OpenRead(fileName));
            return reader;
        }
    }

    class DataSender
    {

        IDataReader dataReader;

        public DataSender()
        {
            dataReader = new ReadFromCsv();
        }


        public void ModifyData()
        {

            String fileName = @"C:\Users\320107420\OneDrive - Philips\Desktop\environment-case-s22b8\Sender\CSVFile.csv";
            bool isheader = true;
            var reader = dataReader.ReadData(fileName);
            List<string> headers = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                if (isheader)
                {
                    isheader = false;
                    headers = values.ToList();
                    

                }
                else
                {
                    int i = 0;
                    for (i = 0; i < values.Length; i++)
                    {
                        if(i==2)
                            Console.Write(string.Format("  {0}   =   {1}°C   ;", headers[i], values[i]));
                        else
                            Console.Write(string.Format("  {0}   =   {1}   ;", headers[i], values[i]));
                    }

                    Console.WriteLine();

                }
            }
        }
    }
}