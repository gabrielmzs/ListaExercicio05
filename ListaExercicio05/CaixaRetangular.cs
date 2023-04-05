using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Ex01 {
    internal class CaixaRetangular
    {
        public int altura;
        public int comprimento;
        public int largura;

        public decimal CalcularVolume() 
        {
            return altura * comprimento * largura;
        }
    }


}
