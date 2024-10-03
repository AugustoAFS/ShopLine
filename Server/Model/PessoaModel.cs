using System.Globalization;

namespace Server.Model
{
    public class PessoaModel
    {
        public int IdPessoa {  get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }
        public string? Usuario { get; set; }
        public string? Senha { get; set; } 
        public ICollection<CarrinhoModel>? Carrinho { get; set; }
        public ICollection<PedidoModel>? Pedido { get; set; }
    }
}
