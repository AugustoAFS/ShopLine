using System.Text.Json.Serialization;

namespace Server.Model
{
    public class StatusPedidoModel
    {
        public int IdPedido { get; set; }
        public string Descricao { get; set; }
        [JsonIgnore]
        public ICollection<PedidoModel> Pedido { get; set; }
    }
}
