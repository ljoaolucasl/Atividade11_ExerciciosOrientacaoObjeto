using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08.ConsoleApp
{
    public class LataDeOleo
    {
        public static double raio;
        public static double altura;

        public static double CalcularVolume()
        {
            return Math.Round(Math.PI * Math.Pow(raio, 2) * altura);
        }
    }
}
