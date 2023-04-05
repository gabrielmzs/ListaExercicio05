using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05 {
    internal class Esfera {
        public double raio;

        public double CalcularVolume() {
            return (4 *Math.PI *Math.Pow(raio, 3) / 3);
        }
    }
}
