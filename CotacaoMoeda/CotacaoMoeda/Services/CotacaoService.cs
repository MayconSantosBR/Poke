using CotacaoMoeda.Entities;
using CotacaoMoeda.Models;
using CotacaoMoeda.Repositories.Interfaces;
using CotacaoMoeda.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace CotacaoMoeda.Services
{
    public class CotacaoService: ICotacaoService
    {
        private readonly ICotacaoRepository repository;

        public CotacaoService(ICotacaoRepository repository)
        {
            this.repository = repository;
        }

        public bool SalvarCotacao(CotacaoModel model)
        {
            try
            {
                var cotacao = new Cotacao()
                {
                    Valor = model.Valor,
                    Data = model.Data,
                    MoedaId = model.MoedaId
                };

                repository.Save(cotacao);

                return true;
            }
            catch
            {
                throw;
            }
        }

        public List<Cotacao> BuscarCotacao(long moedaId, DateTime data)
        {
            try
            {
                return repository.GetAll(moedaId, data.Date);
            }
            catch
            {
                throw;
            }
        }
    }
}
