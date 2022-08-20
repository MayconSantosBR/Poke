using System;
using System.ComponentModel.DataAnnotations;

namespace CotacaoMoeda.Entities
{
    public class Cotacao
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required]
        public DateTime Data { get; set; }

        public long MoedaId { get; set; }
        public Moeda Moeda { get; set; }
    }
}
