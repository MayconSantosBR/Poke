using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Entities
{
    public class Hability
    {
        [Key]
        public long IdHability { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public string Description { get; set; }
        public ICollection<Pokemon> Pokemons { get; set; }
        //public List<PokemonHability> PokemonHabilities { get; set; }
        public long TypeId { get; set; }
        public PokemonType Type { get; set; }
        public long EffectId { get; set; }
        public Effect Effect { get; set; }
    }
}
