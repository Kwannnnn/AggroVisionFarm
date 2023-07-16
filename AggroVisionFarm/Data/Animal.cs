using System.Text.Json.Serialization;

namespace AggroVisionFarm.Data
{
    public class Animal
    {
        [JsonPropertyName("animalNumber")]
        public string Number { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("children")]
        public List<Animal> Children { get; set; } = new List<Animal>();

        public string getChildrenToString()
        {
            return String.Join(", ", Children.Select(c => c.Number));
		}
    }
}