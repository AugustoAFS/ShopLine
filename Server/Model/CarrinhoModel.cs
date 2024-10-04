using System.Text.Json.Serialization;

namespace Server.Model
{
    public class CarrinhoModel
    {
        public int? IdCarrinho { get; set; }
        public string? Status { get; set; }
        public int? IdPessoa { get; set; }
        public PessoaModel? Pessoa { get; set; }
        [JsonIgnore]
        public ICollection<ItemCarrinhoModel>? ItemCarrinho { get; set; }
        
    }
}
