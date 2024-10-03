namespace Server.Model
{
    public class ItemCarrinhoModel
    {
        public int IdItemCarrinho { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
         public int IdCarrinho { get; set; }
        public CarrinhoModel Carrinho { get; set; }
        public int IdObjeto { get; set; }
        public ObjetoModel Objeto { get; set; }
    }
}
