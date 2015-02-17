using Agenda.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dados
{
    public partial class AgendaContext : DbContext
    {
        public AgendaContext()
        {

        }

        public virtual DbSet<Compromisso> Compromissos { get; set; }
    }
}
