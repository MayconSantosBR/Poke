using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Hosting;
using PokemonAPI.Entities;

namespace PokemonAPI.Context
{
    public class MainContext: DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonType> Types { get; set; }
        public DbSet<Hability> Habilities { get; set; }
        public DbSet<Effect> Effects { get; set; }
        public DbSet<PokemonHability> PokemonHability { get; set; }
        public DbSet<PokemonPokemonType> PokemonPokemonTypes { get; set; }
        public MainContext(DbContextOptions<MainContext> options): base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder
            //    .Entity<Pokemon>().HasKey(x => x.IdPokemon);

            //modelBuilder
            //    .Entity<PokemonType>().HasKey(x => x.Id);

            //modelBuilder
            //    .Entity<Hability>().HasKey(x => x.IdHability);

            //modelBuilder
            //    .Entity<Effect>().HasKey(x => x.IdEffect);

            //modelBuilder
            //    .Entity<PokemonHability>().HasKey(x => x.Id);

            //modelBuilder
            //    .Entity<PokemonPokemonType>().HasKey(x => x.Id);

            //modelBuilder
            //    .Entity<PokemonPokemonType>()
            //    .HasOne(x => x.PokemonType)
            //    .WithMany(x => x.pokemonPokemonType)
            //    .HasForeignKey(x => x.IdType);

            //modelBuilder
            //   .Entity<PokemonPokemonType>()
            //   .HasOne(x => x.Pokemon)
            //   .WithMany(x => x.pokemonPokemonTypes)
            //   .HasForeignKey(x => x.IdPokemon);

            //modelBuilder
            //    .Entity<PokemonHability>()
            //    .HasOne(x => x.Pokemon)
            //    .WithMany(x => x.PokemonHabilities)
            //    .HasForeignKey(x => x.IdPokemon);

            //modelBuilder
            //    .Entity<PokemonHability>()
            //    .HasOne(x => x.Hability)
            //    .WithMany(x => x.PokemonHabilities)
            //    .HasForeignKey(x => x.IdHability);
        }
    }
}
