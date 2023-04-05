namespace Exercicio07.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();

            vendedor.SetSalarioBase(1500);

            vendedor.SetComissao(15);

            vendedor.SetVendas(500);

            decimal salarioTotal = vendedor.GetSalarioTotal();

            Console.WriteLine($"O salário total é: R${salarioTotal}");

            Console.ReadLine();
        }
    }
}