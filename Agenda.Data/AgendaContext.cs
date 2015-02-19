using Agenda.Entities;
using Agenda.Interfaces.Data;
using System.Data.Entity;

namespace Agenda.Data
{
    public partial class AgendaContext : DbContext, IAgendaContext
    {
        public AgendaContext()
        {

        }

        public virtual DbSet<Appointment> Appointments { get; set; }
    }
}
