using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07 {
    internal class Salario {
        public double salarioBase, totalVendas, percentualComissao;

        public double CalcularSalarioFinal() {
            return salarioBase + (totalVendas * percentualComissao/100) ;
        }
    }
}
