using CotacaoMoeda.Entities;
using CotacaoMoeda.Repositories.Contexts;
using CotacaoMoeda.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CotacaoMoeda.Repositories
{
    public class CotacaoRepository : ICotacaoRepository
    {
        private readonly Context context;

        public CotacaoRepository(Context context)
        {
            this.context = context;
        }

        public void Save(Cotacao cotacao)
        {
            try
            {
                context.Add(cotacao);
                context.SaveChanges();
                context.ChangeTracker.Clear();
            }
            catch
            {
                throw;
            }
        }

        public List<Cotacao> GetAll(long moedaId, DateTime data)
        {
            try
            {
                return context.Cotacao
                    .Where(c => c.MoedaId.Equals(moedaId))
                    .Where(c => c.Data.Date.Equals(data.Date))
                    .Include(c => c.Moeda)
                    .ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
