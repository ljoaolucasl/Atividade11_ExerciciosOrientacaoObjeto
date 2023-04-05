using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.ConsoleApp
{
    public class Veiculo
    {
        public decimal CalcularConsumo(decimal kmInicial, decimal kmFinal, decimal consumo)
        {
            return Math.Round((kmFinal - kmInicial) / consumo);
        }
    }
}
