using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    class Checker
    {
        Alerter alerter;
        public Checker(Alerter alert) {
            this.alerter = alert;
        }
        public void Check(DataRecord data) {
            if (data.Temperature >= 37 || data.Temperature <= 4) {
                alerter.Alert("Temperature too high or too low");
            }
            if (data.Temperature >= 40 || data.Temperature <= 0)
            {
                alerter.Alert("Temperature error");
            }
            if (data.Humidity >= 70) {
                alerter.Alert("humidity too high");
            }
            if (data.Humidity >= 90) {
                alerter.Alert("humidity error");
            }
        }
    }
}
