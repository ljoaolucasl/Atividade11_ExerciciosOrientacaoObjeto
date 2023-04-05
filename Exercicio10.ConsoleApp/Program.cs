namespace Exercicio10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prova prova = new Prova();

            prova.SetNotas(8, 3, 6, 2);

            decimal mediaPonderada = prova.GetMediaPonderada();

            Console.WriteLine($"A média ponderada é {mediaPonderada}");

            Console.ReadLine();
        }
    }
}