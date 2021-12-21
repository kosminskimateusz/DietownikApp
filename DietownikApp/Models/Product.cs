using System.Text.Json.Serialization;

namespace DietownikApp.Models
{
    public class Products
    {
        [JsonPropertyName("data")]
        public Product[] ProductsList { get; set; }
        public object error { get; set; }
    }

    public class Product
    {
        public string name { get; set; }
        public float kcal { get; set; }
        public float fats { get; set; }
        public float carbs { get; set; }
        public float proteins { get; set; }
        public int id { get; set; }
    }
}
