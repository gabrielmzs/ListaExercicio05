using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10 {
    internal class MediaHarmonica {

        public double nota1, nota2;

        public double CalcularMediaHarmonica() {
            return 2 / ((1 / nota1) + (1 / nota2));
        }
    }
}
