namespace Exercicio09.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prova prova = new Prova();

            prova.SetNotas(8, 9, 6);

            decimal mediaHarmonica = prova.GetMediaHarmonica();

            Console.WriteLine($"A média harmônica é {mediaHarmonica}");

            Console.ReadLine();
        }
    }
}