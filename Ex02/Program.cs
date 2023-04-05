namespace Ex02 {
    internal class Program {
        static void Main(string[] args) {
            TemperaturaCelsius temp = new TemperaturaCelsius();
            Console.WriteLine("Informe a temperatura em Fahrenheit");
            temp.tempFahr = double.Parse(Console.ReadLine());

            Console.WriteLine($"Temperatura em Celsius: {temp.ConvertTemp()}");
        }
    }
}