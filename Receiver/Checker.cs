using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    public class Checker
    {
        public Alerter alerter;
        public Checker(Alerter alert) {
            this.alerter = alert;
        }
        public bool CheckTemperatureError(DataRecord data) 
        {
            if (data.Temperature >= 40 || data.Temperature <= 0)
            {
                alerter.Alert("Temperature error");
                return true;
            }
            return false;
        }
        public bool CheckTemperatureHighOrLow(DataRecord data)
        {
            if (data.Temperature >= 37 || data.Temperature <= 4)
            {
                alerter.Alert("Temperature too high or too low");
                return true;
            }
            return false;
        }
        public bool CheckHumidityError(DataRecord data) 
        {
            if (data.Humidity >= 90)
            {
                alerter.Alert("humidity error");
                return true;
            }
            return false;
        }
        public bool CheckHumidityHigh(DataRecord data)
        {
            if (data.Humidity >= 70)
            {
                alerter.Alert("humidity too high");
                return true;
            }
            return false;
        }
        public void Check(DataRecord data) 
        {
            if (!CheckTemperatureError(data))
            {
                CheckTemperatureHighOrLow(data);
            }
            if (!CheckHumidityError(data))
            {
                CheckHumidityHigh(data);
            }
        }
    }
}
