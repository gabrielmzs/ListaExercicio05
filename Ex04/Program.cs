namespace Ex04 {
    internal class Program {
        static void Main(string[] args) {
            Viagem viagem = new Viagem();
            Console.Write("Informe o Km Inicial: ");
            viagem.KmInicial = double.Parse(Console.ReadLine());
            Console.Write("Informe o Km Final: ");
            viagem.KmFinal = double.Parse(Console.ReadLine());
            Console.Write("Informe o consumdo: ");
            viagem.Consumo = double.Parse(Console.ReadLine());

            Console.WriteLine($"O carro faz {viagem.KmPorLitro()} Km/l.");
        }
    }
}