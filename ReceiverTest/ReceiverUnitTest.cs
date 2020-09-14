using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Receiver;


namespace ReceiverTests
{   
    public class ReceiverUnitTest
    {
        [Fact]
        public void Test(){
        Receiver.ConsoleReader  consoleReader=new Receiver.ConsoleReader();
            Assert.True(true);
        }
    }


}
