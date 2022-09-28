using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Entities
{
    public class PokemonTypes
    {
        [Key]
        public long IdPokemon { get; set; }
        public Pokemon Pokemon { get; set; }
        public long IdType { get; set; }
        public Types Types { get; set; }
    }
}
