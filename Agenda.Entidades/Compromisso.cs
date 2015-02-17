using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Entidades
{
    public class Compromisso
    {
        public int Id { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }
        
        [Required]
        public DateTime DataFinal { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Timestamp]
        public byte[] Versao { get; set; }
    }
}
