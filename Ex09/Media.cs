using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09 {
    internal class Media {
        public double nota1, peso1, nota2, peso2;

        public double CalcularMediaPonderada() {
            return ((nota1*peso1)+ (nota2*peso2))/2;
        }
    }
}
