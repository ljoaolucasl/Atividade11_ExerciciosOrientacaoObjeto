using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05.ConsoleApp
{
    internal class Esfera
    {
        public double raio;
        public double altura;

        public double Volume
        {
            get
            {
                return Math.Round(4.0/3.0 * Math.PI * Math.Pow(raio, 3));
            }
        }
    }
}
