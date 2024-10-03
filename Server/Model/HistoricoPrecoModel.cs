namespace Server.Model
{
    public class HistoricoPrecoModel
    {
        public int IdHistorico {  get; set; }  
        public decimal Preco { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime? DataFim { get; set; }
        public int IdObjeto { get; set; }
        public ObjetoModel Objeto { get; set; }
    }
}
