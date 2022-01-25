using System.Collections.Generic;

namespace console
{
    public class Pokemon
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public List<Type> types { get; set; }
        public List<Pokemon> Evolutions { get; set; }

        public Pokemon(long id, string nome, List<Type> types)
        {
            this.Id = id;
            this.Nome = nome;
            this.types = types;
            this.Evolutions = new List<Pokemon>();
        }

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