using CotacaoMoeda.Entities;
using System.Collections.Generic;

namespace CotacaoMoeda.Repositories.Interfaces
{
    public interface IMoedaRepository
    {
        void Save(Moeda moeda);
        List<Moeda> GetAll();
    }
}
