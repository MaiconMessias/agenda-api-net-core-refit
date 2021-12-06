using System.Text.Json.Serialization;

namespace consumindo_api.Models
{
    public class Pessoa {
        
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("nome")]
        public string Nome{ get; set; }
        [JsonPropertyName("cpf")]
        public string Cpf { get; set; }
        [JsonPropertyName("endereco")]
        public int Endereco{ get; set; } 
    }
}