using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09.ConsoleApp
{
    internal class Prova
    {
        private decimal[] notas = new decimal[3];

        public void SetNotas(decimal nota1, decimal nota2, decimal nota3)
        {
            notas[0] = nota1;
            notas[1] = nota2;
            notas[2] = nota3;
        }

        public decimal GetMediaHarmonica()
        {
            return Math.Round(3 / (1 / notas[0] + 1 / notas[1] + 1 / notas[2]), 1);
        }
    }
}
