namespace Server.Model
{
    public class EnderecoModel
    {
        public int IdEndereco { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Cep { get; set; }
        public int IdPessoa { get; set; }
        public PessoaModel? Pessoa { get; set; }

    }
}
