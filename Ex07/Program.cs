namespace Ex07 {
    internal class Program {
        static void Main(string[] args) {
            Salario salario = new Salario();
            Console.Write("Informe o salário base: ");
            salario.salarioBase = double.Parse(Console.ReadLine());
            Console.Write("Informe o total de vendas: ");
            salario.totalVendas = double.Parse(Console.ReadLine());
            Console.Write("Informe a porcentagem de comissão: ");
            salario.percentualComissao= double.Parse(Console.ReadLine());

            Console.WriteLine($"O salário final do vendedor será de: {salario.CalcularSalarioFinal()}");
        }
    }
}