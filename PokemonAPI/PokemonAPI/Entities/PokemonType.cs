using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Entities
{
    public class PokemonType
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<Pokemon> Pokemons { get; set; }
        public ICollection<PokemonPokemonType> pokemonPokemonType { get; set; }
    }
}
