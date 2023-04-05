using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.ConsoleApp
{
    public class Retangulo
    {
        public decimal altura;
        public decimal largura;
        public decimal profundidade;

        public decimal CalcularVolume()
        {
            return altura * largura * profundidade;
        }
    }
}
