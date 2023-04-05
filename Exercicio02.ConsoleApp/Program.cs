namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperaturaConvert temperatura = new TemperaturaConvert();

            double temperaturaFahrenheit = 50;

            double temperaturaCelsius = temperatura.ToCelsius(temperaturaFahrenheit);

            Console.WriteLine($"Convertendo a temperatura {temperaturaFahrenheit}° Fahrenheit para Celsius ficaria {temperaturaCelsius}° Celsius ");

            Console.ReadLine();
        }
    }
}