using CotacaoMoeda.Entities;
using System;
using System.Collections.Generic;

namespace CotacaoMoeda.Repositories.Interfaces
{
    public interface ICotacaoRepository
    {
        void Save(Cotacao cotacao);
        List<Cotacao> GetAll(long moedaId, DateTime data);
    }
}
