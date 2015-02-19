using Agenda.Entities;
using Agenda.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Business
{
    public class AppointmentBusiness
    {
        private ISaveRespository _saveRespository;

        public AppointmentBusiness(ISaveRespository saveRespository)
        {
            // TODO: Complete member initialization
            this._saveRespository = saveRespository;
        }
        public void Save(Appointment appointment)
        {
            this._saveRespository.Save(appointment);
        }
    }
}
