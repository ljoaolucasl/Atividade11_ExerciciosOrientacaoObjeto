using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10.ConsoleApp
{
    internal class Prova
    {
        private decimal[] notas = new decimal[2];
        private decimal[] peso = new decimal[2];

        public void SetNotas(decimal nota1, decimal peso1, decimal nota2, decimal peso2)
        {
            notas[0] = nota1;
            notas[1] = nota2;

            peso[0] = peso1;
            peso[1] = peso2;
        }

        public decimal GetMediaPonderada()
        {
            return Math.Round((peso[0] * notas[0] + peso[1] * notas[1]) / (peso[0] + peso[1]), 1);
        }
    }
}
