using ProjetoInterfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterfaces.Entities
{
    public class ExpressoRapido : IServicoEnvio
    {
        public double CalcularTaxaEnvio(Produto produto)
        {

            double taxaEntregaRapida = 0.1; // 10% por kg
            double taxaEntregaAdicional = 0.05; // Taxa adicional
            double valorTotal = 0;
            valorTotal = produto.Peso * taxaEntregaRapida + taxaEntregaAdicional;
            return valorTotal;
            /* lógica fictícia, ou seja, A taxa de entrega
             * padrão para entregas rápidas é de 5%, + os R$0.10 por kg do produto  */
            ;
           
        }

        public string EstimarTempoEntrega(Produto produto)
        {
            if(produto.Preco >= 100)
            {
                return "Sua entrega chegará em 1 dia útil";
            }
            else
            {
                return "Sua entrega chegará em 4 dias úteis";
            }
        }
    }
}
