namespace SistemaAluguelVeiculos {
    public class Cliente {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        public Cliente(int id, string nome, string cpf, string telefone) {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }

        public void ExibirInformacoes() {
            Console.WriteLine($"Cliente: {Nome}, CPF: {Cpf}, Telefone: {Telefone}");
        }
    }
}
