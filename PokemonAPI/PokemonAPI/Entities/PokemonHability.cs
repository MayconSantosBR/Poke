using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Entities
{
    public class PokemonHability
    {
        [Key]
        public long Id { get; set; }
        public long IdPokemon { get; set; }
        public Pokemon Pokemon { get; set; }
        public long IdHability { get; set; }
        public Hability Hability { get; set; }
    }
}
