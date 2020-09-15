using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Receiver;
using System.Runtime.Remoting.Messaging;

namespace ReceiverTests
{
    public class DummyAlert : Alerter
    {
        bool x = false;
        public bool Alert(string message)
        {
            x = true;
            return x;
        }
        
    }
    public class ReceiverUnitTest
    {
        [Fact]
        public void WhenReadConsoleIsCalledDataRecordObejectIsReturned()
        {
            Receiver.DataRecord dataRecord = new DataRecord();
            dataRecord.Temperature = 35;
            dataRecord.Humidity = 40;
            string time = "1/1/2002 10:10";
            dataRecord.Time = Convert.ToDateTime(time);
            Receiver.ConsoleReader consoleReader = new ConsoleReader();
            consoleReader.line = "1/1/2002 10:10,35,40";
            Receiver.DataRecord data = consoleReader.ReadConsole();
            Assert.True(dataRecord.Temperature == data.Temperature);
            Assert.True(dataRecord.Humidity == data.Humidity);
            Assert.True(dataRecord.Time == data.Time);
        }
        [Fact]
        public void WhenThereIsErrorInTemperatureValueAndHumidityValueAlertIsInvoked()
        {
            Receiver.Alerter alerter = new DummyAlert();
            Receiver.DataRecord dataRecord = new DataRecord();
            string time = "1/1/2002 10:10";
            dataRecord.Time = Convert.ToDateTime(time);
            dataRecord.Temperature = 40;
            dataRecord.Humidity = 90;
            Receiver.Checker checker = new Checker(alerter);
            checker.Check(dataRecord);
            Assert.True(alerter.Alert(""));
        }

        [Fact]
        public void WhenTemperatureAndHumidityTooHighAlertIsInvoked()
        {
            Receiver.Alerter alerter = new DummyAlert();
            Receiver.DataRecord dataRecord = new DataRecord();
            string time = "1/1/2002 10:10";
            dataRecord.Time = Convert.ToDateTime(time);
            dataRecord.Temperature = 37;
            dataRecord.Humidity = 70;
            Receiver.Checker checker = new Checker(alerter);
            checker.Check(dataRecord);
            Assert.True(alerter.Alert(""));

        }
    }


}
