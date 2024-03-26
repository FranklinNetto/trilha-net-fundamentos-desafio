using System.Runtime.CompilerServices;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("\nDigite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            //Verifica se a placa já está na lista antes de inserir
            if (!veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                veiculos.Add(placa.ToUpper());
            }
            else
            {
                Console.WriteLine("\nATENÇÃO! Este veículo já está no pátio. Confira se digitou a placa corretamente.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("\nDigite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = precoInicial + precoPorHora * horas;

                int indice = veiculos.IndexOf(placa.ToUpper());
                veiculos.RemoveAt(indice);

                Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("\nOs veículos estacionados são:\n");

                foreach(string veiculo in veiculos)
                {
                    Console.WriteLine($"- {veiculo}\n");
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.");
            }
        }
    }
}
