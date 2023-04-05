namespace Ex09 {
    internal class Program {
        static void Main(string[] args) {
            Media media = new Media();
            Console.Write("Informe a nota 1: ");
            media.nota1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o peso 1: ");
            media.peso1 = double.Parse(Console.ReadLine());
            Console.Write("Informe a nota 2: ");
            media.nota2 = double.Parse(Console.ReadLine());
            Console.Write("Informe a peso 2: ");
            media.peso2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Média Ponderada das notas: {media.CalcularMediaPonderada()}");
        }
    }
}