namespace console
{
    public class Type
    {
        public long Id { get; set; }
        public string Nome { get; set; }

        public Type(long id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public override string ToString()
        {
            return $"{this.Nome}";
        }
    }
}