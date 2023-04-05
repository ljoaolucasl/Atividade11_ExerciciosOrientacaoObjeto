using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07.ConsoleApp
{
    internal class Vendedor
    {
        private decimal salarioBase;
        private decimal comissao;
        private decimal vendas;

        public void SetSalarioBase(decimal setSalarioBase)
        {
            salarioBase = setSalarioBase;
        }

        public void SetComissao(decimal setComissao)
        {
            comissao = setComissao;
        }

        public void SetVendas(decimal setVendas)
        {
            vendas = setVendas;
        }

        public decimal GetSalarioTotal()
        {
            return vendas * (comissao / 100) + salarioBase;
        }
    }
}
