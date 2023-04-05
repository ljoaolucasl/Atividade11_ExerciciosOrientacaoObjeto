namespace Exercicio08.ConsoleApp
{
    internal class Program : LataDeOleo
    {
        static void Main(string[] args)
        {
            raio = 5;
            altura = 10;

            double volumeLata = CalcularVolume();

            Console.WriteLine("O volume da Lata de Óleo é " + volumeLata + "cm³");

            Console.ReadLine();
        }
    }
}