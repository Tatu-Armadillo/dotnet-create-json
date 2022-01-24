using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace console
{
    public class Pokemon
    {
        [JsonInclude]
        public long Id { get; set; }
        [JsonInclude]
        public string Nome { get; set; }
        [JsonInclude]
        public List<Type> types { get; set; }
        // public List<Pokemon> Evolutions { get; set; }

        public Pokemon(long id, string nome, List<Type> types)
        {
            this.Id = id;
            this.Nome = nome;
            this.types = types;
        }
        // public Pokemon(long id, string nome, List<Type> types, List<Pokemon> evolutions)
        // {
        //     this.Id = id;
        //     this.Nome = nome;
        //     this.types = types;
        //     this.Evolutions = evolutions;
        // }

        public override string ToString()
        {
            if (this.types.Count == 1)
            {
                return $"Name: {this.Nome} Type: {this.types[0]} | Id: {this.Id}\n";
            }
            else
            {
                return $"Name: {this.Nome} | Types: {this.types[0]}, {this.types[1]} | Id: {this.Id}\n";
            }
        }

    }
}