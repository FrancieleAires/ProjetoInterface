using ProjetoInterfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterfaces.Services
{
    internal class ProcessadorDeProdutos
    {
        public ProcessadorDeProdutos() 
        { 
        }  
        public double CalcularCustoTotal(Produto produto, IServicoEnvio servicoEnvio)
        {

            double custoEnvio = servicoEnvio.CalcularTaxaEnvio(produto);
            double custoTotal = produto.Preco + custoEnvio;
            return custoTotal;
        }
    }
}
