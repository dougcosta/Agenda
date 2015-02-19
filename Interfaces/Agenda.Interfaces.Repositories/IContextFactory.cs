using Agenda.Data;

namespace Agenda.Interfaces.Repositories
{
    public interface IContextFactory
    {
        AgendaContext Create();
    }
}
