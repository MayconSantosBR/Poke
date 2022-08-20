using System.ComponentModel.DataAnnotations;
using System;

namespace CotacaoMoeda.Models
{
    public class CotacaoModel
    {
        [Required]
        public decimal Valor { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public long MoedaId { get; set; }
    }
}
