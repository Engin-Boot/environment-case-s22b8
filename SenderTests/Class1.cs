using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Sender;


namespace SenderTests
{
    
    public class Class1
    {
        [Fact]
        public void TestIfCSVFileOpens()
        {
            IDataReader dataReader = new ReadFromCsv();
            String fileName = @"C:\Users\320107420\OneDrive - Philips\Desktop\environment-case-s22b8\Sender\CSVFile.csv";
            var reader = dataReader.ReadData(fileName);
            Assert.True(reader != null);
        }

        [Fact]
        public void TestIfDataIsPrintedOnTheConsole()
        {
            IDataReader dataReader = new ReadFromCsv();
            String fileName = @"C:\Users\320107420\OneDrive - Philips\Desktop\environment-case-s22b8\Sender\CSVFile.csv";
            var reader = dataReader.ReadData(fileName);
            Assert.True(reader != null);
        }


    }
}
