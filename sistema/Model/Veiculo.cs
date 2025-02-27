namespace SistemaAluguelVeiculos {
    public class Veiculo {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public double PrecoPorDia { get; set; }
        public bool Disponivel { get; private set; } = true;
        public bool EmManutencao { get; private set; } = false;

        public Veiculo(int id, string modelo, string placa, double precoPorDia) {
            Id = id;
            Modelo = modelo;
            Placa = placa;
            PrecoPorDia = precoPorDia;
        }

        public void ExibirInformacoes() {
            Console.WriteLine($"Veículo: {Modelo}, Placa: {Placa}, Preço por Dia: {PrecoPorDia:C}");
            Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}, Em Manutenção: {(EmManutencao ? "Sim" : "Não")}");
        }
        public void MarcarIndisponivel()
        {
            Disponivel = false;
        }

        public void MarcarDisponivel()
        {
            Disponivel = true;
            EmManutencao = false;
        }

        public void IniciarManutencao()
        {
            if (Disponivel)
            {
                Console.WriteLine("O veículo está disponível e será enviado para manutenção.");
            }
            EmManutencao = true;
            Disponivel = false;
        }

        public void FinalizarManutencao()
        {
            if (EmManutencao)
            {
                Console.WriteLine("Manutenção finalizada. O veículo está disponível para aluguel.");
                EmManutencao = false;
                Disponivel = true;
            }
            else
            {
                Console.WriteLine("Este veículo não está em manutenção.");
            }
        }
}
