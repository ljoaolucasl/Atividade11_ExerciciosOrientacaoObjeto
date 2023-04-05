using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06.ConsoleApp
{
    internal class TemperaturaConvert
    {
        public double ToFahrenheit(double temperaturaCelsius)
        {
            temperaturaCelsius *= 1.8;
            temperaturaCelsius += 32;
            
            return Math.Round(temperaturaCelsius, 1);
        }
    }
}
