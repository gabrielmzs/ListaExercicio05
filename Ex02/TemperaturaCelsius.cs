using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02 {
    internal class TemperaturaCelsius {
        public double tempFahr;
        public double ConvertTemp() {
            double tempcelsius = (tempFahr - 32) / 1.8;
            return tempcelsius;
        }
    }
}
