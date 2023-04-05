using Exercicio01.ConsoleApp;

namespace Atividade11_ExerciciosOrientacaoObjeto.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            retangulo.altura = 10;
            retangulo.largura = 20;
            retangulo.profundidade = 30;

            decimal volumeRetangulo = retangulo.CalcularVolume();

            Console.WriteLine("O volume da caixa é " + volumeRetangulo + "cm³");

            Console.ReadLine();
        }
    }
}