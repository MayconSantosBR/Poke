using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Entities
{
    public class Effect
    {
        [Key]
        public long IdEffect { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Hability> Habilities { get; set; }
    }
}
