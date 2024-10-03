using System.Text.Json.Serialization.Metadata;

namespace Server.Model
{
    public class ItemPedidoModel
    {
        public int IdItemPedido { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int IdPedido { get; set; }
        public PedidoModel Pedido { get; set; }
        public int IdObjeto { get; set; }
        public ObjetoModel Objeto { get; set; }
    }
}
