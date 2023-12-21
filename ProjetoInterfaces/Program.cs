namespace ProjetoInterfaces
{
    using ProjetoInterfaces.Entities;
    using ProjetoInterfaces.Services;
    using System;
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔═════════════════════╗");
            Console.WriteLine("║       ENTREGAS      ║");
            Console.WriteLine("╚═════════════════════╝");
            Console.WriteLine("Bem-vindo(a), digite as informações do produto.");
            Console.WriteLine();
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Peso do produto (kg): ");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Data de fabricação do produto (DD/MM/AAAA): ");
            DateTime dataFabricacao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Produto produto = new Produto(nome, peso, preco, dataFabricacao);

            Console.WriteLine("╔═════════════════════╗");
            Console.WriteLine("║   ESCOLHA 1 OPÇÃO   ║");
            Console.WriteLine("╠═════════════════════╣");
            Console.WriteLine("║ 1-ENTREGA RÁPIDA    ║");
            Console.WriteLine("║ 2-ENTREGA PADRÃO    ║");
            Console.WriteLine("║ 0-FECHAR            ║");
            Console.WriteLine("╚═════════════════════╝");
            Console.Write("\nEscolha uma opção: ");
            int opMenu = int.Parse(Console.ReadLine());

            IServicoEnvio servicoEnvio = null; // Inicialize com null

            switch (opMenu)
            {
                case 1:
                    servicoEnvio = new ExpressoRapido();
                    break;
                case 2:
                    servicoEnvio = new ExpressoPadrao();
                    break;
                default:
                    Console.WriteLine("Menu inválido, digite novamente.");
                    return;
            }

            ProcessadorDeProdutos processadorProdutos = new ProcessadorDeProdutos();
            double custoEnvio = servicoEnvio.CalcularTaxaEnvio(produto);
            string estimativaEntrega = servicoEnvio.EstimarTempoEntrega(produto);
            double custoTotal = processadorProdutos.CalcularCustoTotal(produto, servicoEnvio);

            Console.WriteLine($"\nCusto de envio: R${custoEnvio:F2}");
            Console.WriteLine($"Data estimada de entrega: {estimativaEntrega}");
            Console.WriteLine($"Custo total do produto com envio: R${custoTotal:F2}");
        }
    }
}
