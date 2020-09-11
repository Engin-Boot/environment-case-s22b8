using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sender
{
    public class A{

    public void fun(){
    
    }

    }

    class Program
    {

        static void Main(string[] args)
        {
            A obj=new A();
            obj.fun();
            DataRecord dr=new DataRecord();
            dr.Temperature=30;
            Console.WriteLine(dr.Temperature);
        }
    }
}
