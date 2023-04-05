namespace Exercicio06.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperaturaConvert temperaturaConvert = new TemperaturaConvert();

            double temperaturaCelsius = 20;

            double temperaturaFahrenheit = temperaturaConvert.ToFahrenheit(temperaturaCelsius);

            Console.WriteLine($"Convertendo a temperatura {temperaturaCelsius}° Celsius para Fahrenheit ficaria {temperaturaFahrenheit}° Fahrenheit ");

            Console.ReadLine();
        }
    }
}