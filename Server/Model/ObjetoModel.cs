using System.Text.Json.Serialization;

namespace Server.Model
{
    public class ObjetoModel
    {
        public int IdObjeto { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string preco { get; set; }
        public string estoque { get; set; }
        public int? IdCategoria { get; set; }
        public CategoriaModel Categoria { get; set; }
        public int? IdMarca { get; set; }
        public MarcaModel Marca { get; set; }
        public int? IdTipo { get; set; }
        public TipoModel Tipo { get; set; }
        [JsonIgnore]
        public ICollection<ItemCarrinhoModel> ItemCarrinho { get; set; }
        [JsonIgnore]
        public ICollection<ItemPedidoModel> ItemPedido { get; set; }

    }
}
