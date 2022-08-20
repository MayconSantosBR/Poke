using CotacaoMoeda.Entities;
using CotacaoMoeda.Models;
using CotacaoMoeda.Repositories.Interfaces;
using CotacaoMoeda.Services.Interfaces;
using System.Collections.Generic;

namespace CotacaoMoeda.Services
{
    public class MoedaService: IMoedaService
    {
        private readonly IMoedaRepository repository;

        public MoedaService(IMoedaRepository repository)
        {
            this.repository = repository;
        }

        public bool SalvarMoeda(MoedaModel model)
        {
            try
            {
                var moeda = new Moeda()
                {
                    Nome = model.Nome,
                    Pais = model.Pais,
                    Sigla = model.Sigla
                };

                repository.Save(moeda);

                return true;
            }
            catch
            {
                throw;
            }
        }

        public List<Moeda> BuscarMoedas()
        {
            try
            {
                return repository.GetAll();
            }
            catch
            {

                throw;
            }
        }
    }
}
