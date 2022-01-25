using System.Collections.Generic;
using System.Text.Json;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Type> types = new List<Type>();
            List<Pokemon> evolutions = new List<Pokemon>();
            Type fire = new Type(1L, "Fire");
            Type water = new Type(2L, "Water");
            Type grass = new Type(3L, "Grass");
            Type posion = new Type(4L, "Posion");

            string fileName = "pokedex.json";
            JsonHelper.InitJson(fileName, "pokedex");

            types.Add(grass);
            Pokemon bulbasaur = new Pokemon(1L, "Bulbasaur", types);

            Pokemon ivysaur = new Pokemon(2L, "Ivysaur", types);
            Pokemon venusaur = new Pokemon(3L, "Venusaur", types);
            bulbasaur.Evolutions.Add(ivysaur);
            ivysaur.Evolutions.Add(venusaur);

            string jsonString = JsonSerializer.Serialize(bulbasaur);
            JsonHelper.AppendObjectAndBreak(fileName, jsonString);
            // File.AppendAllText(fileName, ", \n");
            jsonString = JsonSerializer.Serialize(ivysaur);
            JsonHelper.AppendObjectAndBreak(fileName, jsonString);
            jsonString = JsonSerializer.Serialize(venusaur);
            JsonHelper.AppendObjectAndBreak(fileName, jsonString);

            // File.WriteAllText("pokemon.txt", bulbasaur.ToString());
            types.Clear();

            types.Add(fire);
            Pokemon charmander = new Pokemon(4L, "Charmander", types);
            Pokemon charmeleon = new Pokemon(5L, "Charmeleon", types);
            Pokemon charizard = new Pokemon(6L, "Charizard", types);
            charmander.Evolutions.Add(charmeleon);
            charmeleon.Evolutions.Add(charizard);

            jsonString = JsonSerializer.Serialize(charmander);
            JsonHelper.AppendObjectAndBreak(fileName, jsonString);
            jsonString = JsonSerializer.Serialize(ivysaur);
            JsonHelper.AppendObjectAndBreak(fileName, jsonString);
            jsonString = JsonSerializer.Serialize(ivysaur);
            JsonHelper.AppendObjectAndBreak(fileName, jsonString);

            // File.AppendAllText("pokemon.txt", charmander.ToString());
            types.Clear();

            types.Add(water);
            Pokemon squirtle = new Pokemon(7L, "Squirtle", types);
            Pokemon wartortle = new Pokemon(8L, "Wartortle", types);
            Pokemon blastoise = new Pokemon(9L, "Blastoise", types);
            squirtle.Evolutions.Add(wartortle);
            wartortle.Evolutions.Add(blastoise);

            jsonString = JsonSerializer.Serialize(squirtle);
            JsonHelper.AppendObjectAndBreak(fileName, jsonString);
            jsonString = JsonSerializer.Serialize(wartortle);
            JsonHelper.AppendObjectAndBreak(fileName, jsonString);
            jsonString = JsonSerializer.Serialize(blastoise);
            JsonHelper.AppendObject(fileName, jsonString);

            // File.AppendAllText("pokemon.txt", squirtle.ToString());
            types.Clear();
            JsonHelper.CloseJson(fileName);
        }
    }
}
