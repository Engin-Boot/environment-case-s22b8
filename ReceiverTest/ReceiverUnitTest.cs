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
            dataRecord.Time = DateTime.ParseExact(time, "dd/MM/yyyy HH:mm", null);
            string input = Console.ReadLine();
            var lines = input.Split(',').ToList();
            Assert.True(dataRecord.Temperature == Convert.ToInt32(lines[1]));
            Assert.True(dataRecord.Humidity == Convert.ToInt32(lines[2]));
            Assert.True(dataRecord.Time == DateTime.ParseExact(lines[0], "dd/MM/yyyy HH:mm", null));
        }
        [Fact]
        public void WhenThereIsErrorInTemperatureValueAndHumidityValueAlertIsInvoked()
        {
            Receiver.Alerter alerter = new DummyAlert();
            Receiver.DataRecord dataRecord = new DataRecord();
            string time = "1/1/2002 10:10";
            dataRecord.Time = DateTime.ParseExact(time, "dd/MM/yyyy HH:mm", null);
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
            dataRecord.Time = DateTime.ParseExact(time, "dd/MM/yyyy HH:mm", null);
            dataRecord.Temperature = 37;
            dataRecord.Humidity = 70;
            Receiver.Checker checker = new Checker(alerter);
            checker.Check(dataRecord);
            Assert.True(alerter.Alert(""));

        }
    }


}
