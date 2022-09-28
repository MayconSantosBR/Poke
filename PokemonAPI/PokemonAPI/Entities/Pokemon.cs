using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Entities
{
    public class Pokemon
    {
        [Key]
        public long IdPokemon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<PokemonType> Types { get; set; }
        public ICollection<Hability> Habilities { get; set; }
        public List<PokemonPokemonType> PokemonTypes { get; set; }
        public ICollection<PokemonPokemonType> pokemonPokemonTypes { get; set; }
        public List<PokemonHability> PokemonHabilities { get; set; }

    }
}
