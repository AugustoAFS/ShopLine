using System.Text.Json.Serialization;

namespace Server.Model
{
    public class MarcaModel
    {
        public int IdMarca { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<ObjetoModel> Objetos { get; set; }
    }
}
