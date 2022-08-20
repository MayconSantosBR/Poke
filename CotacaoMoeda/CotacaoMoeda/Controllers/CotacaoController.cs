using CotacaoMoeda.Entities;
using CotacaoMoeda.Models;
using CotacaoMoeda.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CotacaoMoeda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotacaoController : Controller
    {
        private readonly ICotacaoService service;

        public CotacaoController(ICotacaoService service)
        {
            this.service = service;
        }

        [HttpPost("SalvarCotacao")]
        public bool SalvarCotacao(CotacaoModel model)
        {
            try
            {
                service.SalvarCotacao(model);
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpGet("BuscarCotacao")]
        public List<Cotacao> BuscarCotacao([Required]long moedaId, [Required]DateTime date)
        {
            try
            {
                return service.BuscarCotacao(moedaId, date);
            }
            catch
            {
                return null;
            }
        }
    }
}
