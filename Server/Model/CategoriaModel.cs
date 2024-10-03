namespace Server.Model
{
    public class CategoriaModel
    {
        public int IdCategoria { get; set; }
        public string Name { get; set; }
        public ICollection<ObjetoModel> Objetos { get; set; }
    }

}
