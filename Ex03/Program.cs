namespace Ex03 {
    internal class Program {
        static void Main(string[] args) {
            Cilindro cilindro = new Cilindro();
            Console.Write("Informe a altura do cilindro: ");
            cilindro.altura = double.Parse(Console.ReadLine());
            Console.Write("Informe o raio do cilindro: ");
            cilindro.raio= double.Parse(Console.ReadLine());

            Console.WriteLine($"O volume do cilindro é: {cilindro.CalcularVolume()}");
        }
    }
}