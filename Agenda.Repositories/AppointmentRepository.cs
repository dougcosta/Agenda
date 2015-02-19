using Agenda.Data;
using Agenda.Entities;
using Agenda.Interfaces.Repositories;
using System.Linq;

namespace Agenda.Repositories
{
    public class AppointmentRepository : ISaveRespository
    {
        private readonly IContextFactory _contextFactory;

        public AppointmentRepository(IContextFactory contextFactory)
        {
            // TODO: Complete member initialization
            this._contextFactory = contextFactory;
        }

        public Appointment Select(int id)
        {
            Appointment appointment = null;

            using (var context = new AgendaContext())
            {
                var appointments = context.Appointments.Where(c => c.Id.Equals(id));

                if (appointments.Count() > 0)
                    appointment = appointments.FirstOrDefault();
            }

            return appointment;
        }

        public void Save(Appointment appointment)
        {
            using (var context = this._contextFactory.Create())
            {
                context.Appointments.Add(appointment);
                context.SaveChanges();
            }
        }
    }
}
