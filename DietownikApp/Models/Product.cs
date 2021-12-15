namespace DietownikApp.Models
{
    public class Root
    {
        public Product[] data { get; set; }
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



    public class Rootobject
    {
        public Weather[] weathers { get; set; }
    }

    public class Weather
    {
        public string[] date { get; set; }
        public int temperatureC { get; set; }
        public string summary { get; set; }
    }


}
