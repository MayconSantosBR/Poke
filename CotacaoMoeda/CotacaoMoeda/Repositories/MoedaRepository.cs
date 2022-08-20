using CotacaoMoeda.Entities;
using CotacaoMoeda.Repositories.Contexts;
using CotacaoMoeda.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CotacaoMoeda.Repositories
{
    public class MoedaRepository : IMoedaRepository
    {
        private readonly Context context;

        public MoedaRepository(Context context)
        {
            this.context = context;
        }

        public void Save(Moeda moeda)
        {
            try
            {
                context.Add(moeda);
                context.SaveChanges();
                context.ChangeTracker.Clear();
            }
            catch
            {
                throw;
            }
        }

        public List<Moeda> GetAll()
        {
            try
            {
                return context.Moeda.ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
