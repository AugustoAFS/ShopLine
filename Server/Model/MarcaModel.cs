namespace Server.Model
{
    public class MarcaModel
    {
        public int IdMarca { get; set; }
        public string Name { get; set; }
        public ICollection<ObjetoModel> Objetos { get; set; }
    }
}
