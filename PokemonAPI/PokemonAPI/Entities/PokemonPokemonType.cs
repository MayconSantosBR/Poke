using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Entities
{
    public class PokemonPokemonType
    {
        public long Id { get; set; }
        public long IdPokemon { get; set; }
        public Pokemon Pokemon { get; set; }
        public long IdType { get; set; }
        public PokemonType PokemonType { get; set; }
    }
}
