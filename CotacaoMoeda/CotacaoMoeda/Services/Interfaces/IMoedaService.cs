using CotacaoMoeda.Entities;
using CotacaoMoeda.Models;
using System.Collections.Generic;

namespace CotacaoMoeda.Services.Interfaces
{
    public interface IMoedaService
    {
        bool SalvarMoeda(MoedaModel model);
        List<Moeda> BuscarMoedas();
    }
}
