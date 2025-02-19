using System;

namespace SistemaAluguelVeiculos
{
    class Program
    {
        static void Main(string[] args){
            //dados do usuario
            Console.WriteLine("Insira o ID do cliente:");
            int clienteId = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome do cliente:");
            string clienteNome = Console.ReadLine();

            Console.WriteLine("Insira o CPF do cliente:");
            string clienteCPF = Console.ReadLine();

            Console.WriteLine("Insira o telefone do cliente:");
            string clienteTelefone = Console.ReadLine();

            Cliente cliente = new Cliente(clienteId, clienteNome, clienteCPF, clienteTelefone);

            Console.WriteLine("Insira o ID do veículo:");
            int veiculoId = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o modelo do veículo:");
            string veiculoModelo = Console.ReadLine();

            Console.WriteLine("Insira a placa do veículo:");
            string veiculoPlaca = Console.ReadLine();

            Console.WriteLine("Insira o valor da diária do veículo:");
            double veiculoValor = double.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(veiculoId, veiculoModelo, veiculoPlaca, veiculoValor);

            Console.WriteLine("Insira a data de início do aluguel (dd/MM/yyyy):");
            DateTime dataInicio = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Insira a data de término do aluguel (dd/MM/yyyy):");
            DateTime dataFim = DateTime.Parse(Console.ReadLine());

            Aluguel aluguel = new Aluguel(cliente, veiculo, dataInicio, dataFim);

            cliente.ExibirInformacoes();
            veiculo.ExibirInformacoes();
            aluguel.ExibirResumoAluguel();
        }
    }
}

