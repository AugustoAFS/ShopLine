using System.Text.Json.Serialization;

namespace Server.Model
{
    public class TipoModel
    {
        public int IdTipo { get; set; }
        public int Name { get; set; }
        [JsonIgnore]
        public ICollection<ObjetoModel> Objetos { get; set; }
    }
}
