using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using LumenWorks.Framework.IO.Csv;

namespace Sender
{
    interface IDataReader{
     void ReadData(); 
    }

    class ReadFromCsv: IDataReader{
      public void ReadData(){
            var csvTable = new DataTable();  
                using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"\CSVFile.csv")), true))  
                {  
                    csvTable.Load(csvReader);  
                }  
            
                string Row1 = csvTable.rows[0][0].ToString();
                Console.WriteLine(Row1);

        }
    }

    class Program
    {   
        static void Main(string[] args)
        {
        }
    }
}
