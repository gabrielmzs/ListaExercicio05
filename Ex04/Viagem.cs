using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04 {
    internal class Viagem {

        public double KmInicial, KmFinal, Consumo;

        public double KmPorLitro() {
            double distancia = KmFinal - KmInicial;
            return distancia / Consumo;
        }
    }
}
