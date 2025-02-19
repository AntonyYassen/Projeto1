namespace SistemaAluguelVeiculos
{
    /// <summary>
    /// prueba
    /// </summary>
    public class Aluguel
    {
        public Cliente Cliente { get; set; }
        public Veiculo Veiculo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public Aluguel(Cliente cliente, Veiculo veiculo, DateTime dataInicio, DateTime dataFim)
        {
            Cliente = cliente;
            Veiculo = veiculo;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

        public double CalcularValorTotal()
        {
            TimeSpan duracao = DataFim - DataInicio;
            return duracao.Days * Veiculo.PrecoPorDia;
        }

        public void ExibirResumoAluguel()
        {
            Console.WriteLine($"Cliente: {Cliente.Nome}");
            Console.WriteLine($"Veículo: {Veiculo.Modelo}");
            Console.WriteLine($"Período: {DataInicio.ToShortDateString()} a {DataFim.ToShortDateString()}");
            Console.WriteLine($"Valor Total: {CalcularValorTotal():C}");
        }
    }
}
