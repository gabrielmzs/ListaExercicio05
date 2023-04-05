using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06 {
    internal class TempFahrenheit {
        public double tempCelsius;

        public double ConverterParaFahrenheit() {
            return (tempCelsius * 1.8) + 32;
        }
    }
}
