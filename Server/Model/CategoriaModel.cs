using System.Text.Json.Serialization;

namespace Server.Model
{
    public class CategoriaModel
    {
        public int IdCategoria { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<ObjetoModel> Objetos { get; set; }
    }

}
