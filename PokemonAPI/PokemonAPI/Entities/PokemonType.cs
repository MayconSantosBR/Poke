using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Entities
{
    public class PokemonType
    {
        public long Id { get; set; }
        public string Name { get; set; }
        //public ICollection<Pokemon> Pokemons { get; set; }
        public ICollection<PokemonPokemonType> pokemonPokemonTypes { get; set; }
    }
}
