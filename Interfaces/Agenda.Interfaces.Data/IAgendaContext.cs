using Agenda.Entities;
using System.Data.Entity;

namespace Agenda.Interfaces.Data
{
    public interface IAgendaContext
    {
        DbSet<Appointment> Appointments { get; set; }
    }
}
