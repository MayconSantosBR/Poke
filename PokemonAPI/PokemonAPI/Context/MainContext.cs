using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Hosting;
using PokemonAPI.Entities;

namespace PokemonAPI.Context
{
    public class MainContext: DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Hability> Habilities { get; set; }
        public DbSet<Effect> Effects { get; set; }
        //public DbSet<PokemonTypes> PokemonTypes { get; set; }
        //public DbSet<PokemonHability> PokemonHability { get; set; }
        public MainContext(DbContextOptions<MainContext> options): base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Pokemon>()
                .HasMany(p => p.Types)
                .WithMany(p => p.Pokemons)
                .UsingEntity<PokemonTypes>(
                    j => j.HasOne(pt => pt.Types)
                        .WithMany(t => t.PokemonTypes)
                        .HasForeignKey(pt => pt.IdType),
                    j => j.HasOne(pt => pt.Pokemon)
                        .WithMany(p => p.PokemonTypes)
                        .HasForeignKey(pt => pt.IdPokemon));

            modelBuilder
                .Entity<Pokemon>()
                .HasMany(p => p.Habilities)
                .WithMany(p => p.Pokemons)
                .UsingEntity<PokemonHability>(
                    j => j.HasOne(pt => pt.Hability)
                        .WithMany(t => t.PokemonHabilities)
                        .HasForeignKey(pt => pt.IdHability),
                    j => j.HasOne(pt => pt.Pokemon)
                        .WithMany(p => p.PokemonHabilities)
                        .HasForeignKey(pt => pt.IdPokemon));
            modelBuilder.Entity<PokemonTypes>().HasKey(c => c.IdPokemon);
            modelBuilder.Entity<PokemonHability>().HasKey(c => c.IdHability);
        }
    }
}
