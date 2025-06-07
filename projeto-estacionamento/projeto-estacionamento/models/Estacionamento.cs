using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_estacionamento.models
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
            Console.WriteLine("Digite a placa do veículo para estacionar");
            string placa = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("Placa inválida. Tente novamente");
                return;
            }

            if (veiculos.Any(v => v.Equals(placa, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Este veículo já está estacionado.");
                return;
            }

            veiculos.Add(placa.ToUpper());
            Console.WriteLine($"Veículo com placa {placa.ToUpper()} adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.Equals(placa, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu no estacionamento: ");

                string inputHoras = Console.ReadLine();
                int horas;

                if (!int.TryParse(inputHoras, out horas) || horas < 0)
                {
                    Console.WriteLine("Números de horas inválido!");
                    return;
                }

                decimal valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.RemoveAll(v => v.Equals(placa, StringComparison.OrdinalIgnoreCase));

                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de R$: {valorTotal:F2}");

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está aqui. Confira se digitou a placa corretamente!");
            }
        }

        public void ListarVeiculo()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Percorre cada veículo na lista e exibe no console
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"- {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados!");
            }
        }
    }
}