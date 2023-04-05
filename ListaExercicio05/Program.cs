using Ex01;

namespace ListaExercicio05 {
    internal class Program {
        static void Main(string[] args) {
            
            CaixaRetangular caixa= new CaixaRetangular();

            caixa.altura = 10;
            caixa.comprimento = 20;
            caixa.largura = 20;


            Console.WriteLine($"Volume {caixa.CalcularVolume()}");

        }
    }
}