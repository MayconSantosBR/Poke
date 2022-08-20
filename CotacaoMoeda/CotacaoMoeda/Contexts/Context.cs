using CotacaoMoeda.Entities;
using Microsoft.EntityFrameworkCore;

namespace CotacaoMoeda.Repositories.Contexts
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        {
        }

        public DbSet<Moeda> Moeda { get; set; }
        public DbSet<Cotacao> Cotacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
