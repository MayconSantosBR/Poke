using CotacaoMoeda.Entities;
using CotacaoMoeda.Models;
using CotacaoMoeda.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CotacaoMoeda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoedaController : Controller
    {
        private readonly IMoedaService service;

        public MoedaController(IMoedaService service)
        {
            this.service = service;
        }

        [HttpPost("SalvarMoeda")]
        public bool SalvarMoeda([FromBody]MoedaModel model)
        {
            try
            {
                service.SalvarMoeda(model);
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpGet("BuscarMoedas")]
        public List<Moeda> BuscarMoedas()
        {
            try
            {
                return service.BuscarMoedas();
            }
            catch
            {
                return null;
            }
        }
    }
}
