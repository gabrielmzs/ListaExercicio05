namespace Ex08 {
    internal class Program {
        static void Main(string[] args) {
            Lata lata = new Lata();
            Console.Write("Informe a altura da lata: ");
            lata.altura = double.Parse(Console.ReadLine());
            Console.Write("Informe o raio do lata: ");
            lata.raio = double.Parse(Console.ReadLine());

            Console.WriteLine($"O volume do lata é: {lata.CalcularVolume()}");
        }
    }
}