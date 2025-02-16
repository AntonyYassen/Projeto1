namespace SistemaAluguelVeiculos {
    public class Veiculo {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public double PrecoPorDia { get; set; }

        public Veiculo(int id, string modelo, string placa, double precoPorDia) {
            Id = id;
            Modelo = modelo;
            Placa = placa;
            PrecoPorDia = precoPorDia;
        }

        public void ExibirInformacoes() {
            Console.WriteLine($"Veículo: {Modelo}, Placa: {Placa}, Preço por Dia: {PrecoPorDia:C}");
        }
    }
}
