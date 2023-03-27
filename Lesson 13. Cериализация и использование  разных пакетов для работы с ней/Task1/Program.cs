using System.Text.Json;


namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var file = new FileStream("SuperHero.json", FileMode.OpenOrCreate))
            {
                var suard = JsonSerializer.Deserialize<SuperHero>(file);
            }
        }
    }
}