using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex03 {
    internal class Cilindro {
        public double raio;
        public double altura;

        public double CalcularVolume() {
            return Math.PI * Math.Pow(raio, 2) * altura;
        }
    }
}
