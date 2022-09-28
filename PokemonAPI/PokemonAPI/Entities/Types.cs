using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Entities
{
    public class Types
    {
        [Key]
        public long IdType { get; set; }
        public string Name { get; set; }
        public ICollection<Pokemon> Pokemons { get; set; }
        public List<PokemonTypes> PokemonTypes { get; set; }
        public List<Hability> Habilities { get; set; }
    }
}
