using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    class DataRecord
    {
        private DateTime time;
        private int temperature;
        private int humidity;

        public DateTime Time
        {
            get {
                return time;
            } set {
                time = value;
            }
        }

        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
            }
        }

        public int Humidity
        {
            get
            {
                return humidity;
            }
            set
            {
                humidity = value;
            }
        }


    }
}
