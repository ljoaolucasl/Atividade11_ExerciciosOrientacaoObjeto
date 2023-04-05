namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();

            decimal consumoPorLitro = veiculo.CalcularConsumo(50, 150, 8);

            Console.WriteLine($"O Consumo foi {consumoPorLitro}km/l");

            Console.ReadLine();
        }
    }
}