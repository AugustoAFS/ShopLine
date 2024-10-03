namespace Server.Model
{
    public class TipoModel
    {
        public int IdTipo { get; set; }
        public int Name { get; set; }
        public ICollection<ObjetoModel> Objetos { get; set; }
    }
}
