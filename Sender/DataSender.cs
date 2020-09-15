using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;


namespace Sender
{

    public class DataSender
    {

        IDataReader dataReader;
        List<String> values;
        StreamReader reader;

        public DataSender()
        {
            dataReader = new ReadFromCsv();
            values = new List<String>();
            reader = null;

        }

        public void ReadDataFromCSV(String fileName)
        {

            reader = dataReader.ReadData(fileName);
        }

        public void ModifyData()
        {
            List<string> headers = new List<string>();
            Timer aTimer;
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 3000;
            var fileName = @"C:\Users\320107420\OneDrive - Philips\Desktop\environment-case-s22b8\SenderOutput.txt";
            File.WriteAllText(fileName, "");

            while (!reader.EndOfStream)
            {
                

                aTimer.Elapsed += OnTimedEvent;
                aTimer.AutoReset = true;


                // Start the timer
                aTimer.Enabled = true;

                //Console.ReadKey();
                
            }

        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (reader.EndOfStream)
                return;
            //Console.Clear();

            PrintData();
        }

        private void PrintData()
        {

            if (reader.EndOfStream)
                return;

            var fileName = @"C:\Users\320107420\OneDrive - Philips\Desktop\environment-case-s22b8\SenderOutput.txt";

            var line = reader.ReadLine();
            values = line.Split(',').ToList();

            String dt = DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm");
            Console.WriteLine("{2},{1},{0}", values[3], values[2], dt);

            String text = dt + "," + values[2] + "," + values[3];
            File.AppendAllText(fileName, text);
        }
    }
}
