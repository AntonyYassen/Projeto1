using System;

namespace SistemaAluguelVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cadastro do Cliente
            Console.WriteLine("Insira o ID do cliente:");
            int clienteId = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome do cliente:");
            string clienteNome = Console.ReadLine();

            Console.WriteLine("Insira o CPF do cliente:");
            string clienteCPF = Console.ReadLine();

            Console.WriteLine("Insira o telefone do cliente:");
            string clienteTelefone = Console.ReadLine();

            Cliente cliente = new Cliente(clienteId, clienteNome, clienteCPF, clienteTelefone);

            // Cadastro do Veículo
            Console.WriteLine("\nInsira o ID do veículo:");
            int veiculoId = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o modelo do veículo:");
            string veiculoModelo = Console.ReadLine();

            Console.WriteLine("Insira a placa do veículo:");
            string veiculoPlaca = Console.ReadLine();

            Console.WriteLine("Insira o valor da diária do veículo:");
            double veiculoValor = double.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(veiculoId, veiculoModelo, veiculoPlaca, veiculoValor);

            // Definição do período de aluguel
            Console.WriteLine("\nInsira a data de início do aluguel (dd/MM/yyyy):");
            DateTime dataInicio = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Insira a data de término do aluguel (dd/MM/yyyy):");
            DateTime dataFim = DateTime.Parse(Console.ReadLine());

            Aluguel aluguel = new Aluguel(cliente, veiculo, dataInicio, dataFim);

            // --- CONTROLE DE DISPONIBILIDADE E MANUTENÇÃO ---
            Console.WriteLine("\nDeseja alterar o status do veículo?");
            Console.WriteLine("1 - Iniciar manutenção");
            Console.WriteLine("2 - Finalizar manutenção");
            Console.WriteLine("3 - Tornar veículo indisponível");
            Console.WriteLine("4 - Tornar veículo disponível");
            Console.WriteLine("5 - Continuar sem alterações");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    veiculo.IniciarManutencao();
                    break;
                case 2:
                    veiculo.FinalizarManutencao();
                    break;
                case 3:
                    veiculo.MarcarIndisponivel();
                    break;
                case 4:
                    veiculo.MarcarDisponivel();
                    break;
                case 5:
                    Console.WriteLine("Nenhuma alteração feita.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            // Exibir informações do aluguel
            Console.WriteLine("\n📌 Resumo do aluguel:");
            cliente.ExibirInformacoes();
            veiculo.ExibirInformacoes();
            aluguel.ExibirResumoAluguel();
        }
    }
}


