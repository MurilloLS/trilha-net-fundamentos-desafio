namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            //"this" usado para evitar ambiguidade entre os parâmetros do construtor e os campos da classe que têm o mesmo nome. 
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado!
            Console.Clear();

            // Implementado! (TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos")
            string placaDoVeiculo = "";
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placaDoVeiculo = Console.ReadLine();
            veiculos.Add(placaDoVeiculo);
        }

        public void RemoverVeiculo()
        {
            // Implementado!
            Console.Clear();

            Console.WriteLine("Digite a placa do veículo para remover:");

            // Implementado! (TODO: Pedir para o usuário digitar a placa e armazenar na variável placa)
            string placa = "";
            placa = Console.ReadLine();

            // Implementado!
            Console.WriteLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                //Implementado! (TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado)
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                                
                int horas = 0;
                decimal valorTotal = 0;

                // Implementado! 
                horas = int.Parse(Console.ReadLine());

                // Implementado! (TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal)
                valorTotal = precoInicial + precoPorHora * horas;

                // Implementado! (TODO: Remover a placa digitada da lista de veículos)
                veiculos.Remove(placa);

                // Implementado!
                Console.WriteLine();

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Implementado!
            Console.Clear();

            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Implementado! (TODO: Realizar um laço de repetição, exibindo os veículos estacionados)
                foreach(string lista in veiculos)
                {
                    Console.WriteLine(lista);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
