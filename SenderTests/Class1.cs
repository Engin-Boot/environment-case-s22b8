using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Sender;
using System.IO;


namespace SenderTests
{
    
    public class Class1
    {
        [Fact]
        public void TestIfCSVFileOpens()
        {
            IDataReader dataReader = new ReadFromCsv();
            String fileName = @"D:\a\environment-case-s22b8\environment-case-s22b8\Sender\CSVFile.csv";
            var reader = dataReader.ReadData(fileName);
            Assert.True(reader != null);
        }

        [Fact]
        public void TestIfDataIsPrintedOnTheConsole()
        {
            DataSender dataSender = new DataSender();
            String fileName = @"C:\Users\320107420\OneDrive - Philips\Desktop\environment-case-s22b8\Sender\CSVFile.csv";
            dataSender.ReadDataFromCSV(fileName);
            dataSender.ModifyData();

            fileName = @"C:\Users\320107420\OneDrive - Philips\Desktop\environment-case-s22b8\SenderOutput.txt";
            var fileName2 = @"C:\Users\320107420\OneDrive - Philips\Desktop\environment-case-s22b8\TextOutput.txt";


            String dt = DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm");
            String data = dt + ",20,30" + dt + ",22,40" + dt + ",0,50" + dt + ",25,100" + dt + ",41,90";

            File.AppendAllText(fileName2, data);

            Assert.True(data.Equals(File.ReadAllText(fileName)));
        }


    }
}
