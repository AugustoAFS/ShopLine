namespace Server.Model
{
    public class PagamentoModel
    {
        public int IdPagamento { get; set; }
        public string MetodoPagamento { get; set; }
        public string StatusPagamento { get; set; }
        public DateTime DataPagamento { get; set; } = DateTime.Now;
        public int IdPedido { get; set; }
        public PedidoModel Pedido { get; set; }
    }
}
