using Agenda.Entities;

namespace Agenda.Interfaces.Repositories
{
    public interface ISaveRespository
    {
        void Save(Appointment appointment);
    }
}
