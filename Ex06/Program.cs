namespace Ex06 {
    internal class Program {
        static void Main(string[] args) {
            TempFahrenheit tempFahren= new TempFahrenheit();
            Console.Write("Informe a temperatura em Celsius: ");
            tempFahren.tempCelsius = double.Parse(Console.ReadLine());

            Console.WriteLine($"Temperatura em Celsius: {tempFahren.ConverterParaFahrenheit()}");
        }
    }
}