using Microsoft.EntityFrameworkCore;
using Server.Model;

namespace Server.data
{
    public class ShopLineDbContext : DbContext
    {

        public ShopLineDbContext(DbContextOptions<ShopLineDbContext> options) : base(options)
        { }

        public DbSet<PessoaModel> Pessoa { get; set; }
        public DbSet<EnderecoModel> Endereco { get; set; }

        public DbSet<ObjetoModel> Objeto { get; set; }
        public DbSet<MarcaModel> Marca { get; set; }
        public DbSet<TipoModel> Tipo { get; set; }
        public DbSet<CategoriaModel> Categoria { get; set; }
        public DbSet<HistoricoPrecoModel> HistoricoPreco { get; set; }

        public DbSet<CarrinhoModel> Carrinho { get; set; }
        public DbSet<ItemCarrinhoModel> ItemCarrinho { get; set; }
        
        public DbSet<PedidoModel> Pedido { get; set; }
        public DbSet<ItemPedidoModel> ItemPedido { get; set; }
        public DbSet<StatusPedidoModel> StatusPedido { get; set; }
        
        public DbSet<PagamentoModel> Pagamento { get; set; }
    }
}
