using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Type> types = new List<Type>(); 
            Type fire = new Type(1L, "Fire");
            Type water = new Type(2L, "Water");
            Type grass = new Type(3L, "Grass");
            Type posion = new Type(4L, "Posion");
            
            string fileName = "pokedex.json";
            File.WriteAllText(fileName, "{\n\"pokedex\": [\n");
            
            types.Add(grass);
            Pokemon bulbasaur = new Pokemon(1L, "Bulbasaur", types);
            // File.WriteAllText("pokemon.txt", bulbasaur.ToString());
            string jsonString = JsonSerializer.Serialize(bulbasaur);
            File.AppendAllText(fileName, jsonString);
            File.AppendAllText(fileName, ", \n");

            types.Clear();

            types.Add(fire);
            Pokemon charmander = new Pokemon(4L, "Charmander", types);
            jsonString = JsonSerializer.Serialize(charmander);
            File.AppendAllText(fileName, jsonString);
            File.AppendAllText(fileName, ", \n");
            // File.AppendAllText("pokemon.txt", charmander.ToString());

            types.Clear();
            types.Add(water);
            Pokemon squirtle = new Pokemon(7L, "Squirtle", types);
            jsonString = JsonSerializer.Serialize(squirtle);
            File.AppendAllText(fileName, jsonString);
            // File.AppendAllText("pokemon.txt", squirtle.ToString());

            // List<Pokemon> pokedex = new List<Pokemon>();
            // pokedex.Add(bulbasaur);
            // pokedex.Add(charmander);
            // pokedex.Add(squirtle);
            File.AppendAllText(fileName, "]\n}");

            
        }

    }
}
