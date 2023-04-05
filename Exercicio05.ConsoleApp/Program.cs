namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();

            esfera.raio = 10;

            double volumeEsfera = esfera.Volume;

            Console.WriteLine("O volume do esfera é " + volumeEsfera + "cm³");

            Console.ReadLine();
        }
    }
}