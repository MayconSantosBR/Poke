using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Entities
{
    public class Pokemon
    {
        [Key]
        public long IdPokemon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Types> Types { get; set; }
        public ICollection<Hability> Habilities { get; set; }
        public List<PokemonTypes> PokemonTypes { get; set; }
        public List<PokemonHability> PokemonHabilities { get; set; }

    }
}
