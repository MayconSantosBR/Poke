using CotacaoMoeda.Entities;
using CotacaoMoeda.Models;
using System.Collections.Generic;
using System;

namespace CotacaoMoeda.Services.Interfaces
{
    public interface ICotacaoService
    {
        bool SalvarCotacao(CotacaoModel model);
        List<Cotacao> BuscarCotacao(long moedaId, DateTime data);
    }
}
