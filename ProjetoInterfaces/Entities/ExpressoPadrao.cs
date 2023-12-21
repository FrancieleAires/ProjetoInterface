using ProjetoInterfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterfaces.Entities
{
    public class ExpressoPadrao : IServicoEnvio
    {
        public double CalcularTaxaEnvio(Produto produto)
        {
            double taxaEntregaRapida = 0.02; // 2% por kg
            double taxaEntregaAdicional = 0.05; // Taxa adicional
            double valorTotal = 0;
            valorTotal = produto.Peso * taxaEntregaRapida + taxaEntregaAdicional;
            return valorTotal;
        }

        public string EstimarTempoEntrega(Produto produto)
        {
            if (produto.Preco >= 100)
            {
               return "Sua entrega chegará em 3 dias úteis";
            }
            else
            {
                return "Sua entrega chegará em 7 dias úteis";
            }
        }
    }
}
