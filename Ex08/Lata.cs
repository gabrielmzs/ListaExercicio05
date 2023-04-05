using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08 {
    internal class Lata {
        public double raio;
        public double altura;

        public double CalcularVolume() {
            return Math.PI * Math.Pow(raio, 2) * altura;
        }
    }
}
