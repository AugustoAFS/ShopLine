namespace Server.Model
{
    public class PedidoModel
    {
        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; } = DateTime.Now;
        public decimal ValorTotal { get; set; }
        public int IdStatus { get; set; }
        public int IdCarrinho { get; set; }
        public CarrinhoModel Carrinho { get; set; }
        public ICollection<ItemPedidoModel> ItemPredido { get; set; }
    }
}
