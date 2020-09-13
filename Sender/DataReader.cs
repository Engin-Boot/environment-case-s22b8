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
        List<String> values;
        StreamReader reader;

        public DataSender()
        {
            dataReader = new ReadFromCsv();
            values=new List<String>();
            reader=null;
            
        }


        public void ModifyData()
        {

            String fileName = @"C:\Users\320107420\OneDrive - Philips\Desktop\environment-case-s22b8\Sender\CSVFile.csv";
            reader = dataReader.ReadData(fileName);
            List<string> headers = new List<string>();
            Timer aTimer;
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 2000;
             // Hook up the Elapsed event for the timer. 
            
                    
            while (!reader.EndOfStream)
            {
                  
                   
                    aTimer.Elapsed +=OnTimedEvent;
                    aTimer.AutoReset = true;


                    // Start the timer
                    aTimer.Enabled = true;
            
                    Console.ReadKey();
                    
             }
             
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if(reader.EndOfStream)
                return;
            Console.Clear();
            String dt = DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm");
            Console.Write("{0},",dt);
            PrintData();
        }

        public void PrintData()
        {

            if(reader.EndOfStream)
                return;

            var line =reader.ReadLine();
            values = line.Split(',').ToList();
            Console.WriteLine("{1},{0}",values[3],values[2]);
        
        }
    }
}
