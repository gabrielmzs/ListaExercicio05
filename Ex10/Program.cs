using static Ex10.MediaHarmonica;

namespace Ex10 {
    internal class Program {
        static void Main(string[] args) {
            MediaHarmonica media = new MediaHarmonica();
            Console.Write("Informe a nota 1: ");
            media.nota1 = double.Parse(Console.ReadLine());
            Console.Write("Informe a nota 2: ");
            media.nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Média Harmonica das notas: {media.CalcularMediaHarmonica()}");
        }
    }
}