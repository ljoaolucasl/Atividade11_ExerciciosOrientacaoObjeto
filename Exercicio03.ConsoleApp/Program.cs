namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();

            cilindro.raio = 10;
            cilindro.altura = 20;

            double volumeCilindro = cilindro.Volume;

            Console.WriteLine("O volume do cilindro é " + volumeCilindro + "cm³");

            Console.ReadLine();
        }
    }
}