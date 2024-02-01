using System.Text.Json.Serialization;

namespace aspClientApp.Models
{
      public class StateDTO
    {
        [JsonPropertyName("stateId")]
        public int StateId {get; set;}
         [JsonPropertyName("stateName")]
        public string StateName {get; set;} = null!;
         [JsonPropertyName("Price")]
        public decimal Price {get; set;}
    }
}