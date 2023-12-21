using ProjetoInterfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterfaces.Entities
{
    public class Produto 
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Preco { get; set; }
        public DateTime DataFabricacao { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double peso, double preco, DateTime dataFabricacao)
        {
            Nome = nome;
            Peso = peso;
            Preco = preco;
            DataFabricacao = dataFabricacao;
        }



    }
}
