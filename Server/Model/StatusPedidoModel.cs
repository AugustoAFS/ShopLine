namespace Server.Model
{
    public class StatusPedidoModel
    {
        public int IdPedido { get; set; }
        public string Descricao { get; set; }
        public ICollection<PedidoModel> Pedido { get; set; }
    }
}
