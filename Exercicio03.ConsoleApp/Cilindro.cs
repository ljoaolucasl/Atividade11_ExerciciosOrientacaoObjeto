using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.ConsoleApp
{
    public class Cilindro
    {
        public double raio;
        public double altura;

        public double Volume
        {
            get
            {
                return Math.Round(Math.PI * Math.Pow(raio, 2) * altura);
            }
        }
    }
}
