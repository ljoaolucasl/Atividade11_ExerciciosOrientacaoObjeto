using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.ConsoleApp
{
    public class TemperaturaConvert
    {
        public double ToCelsius(double temperaturaFahrenheit)
        {
            temperaturaFahrenheit -= 32;
            temperaturaFahrenheit /= 1.8;

            return Math.Round(temperaturaFahrenheit, 1);
        }
    }
}
