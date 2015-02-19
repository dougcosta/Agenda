using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Entities
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        
        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string Description { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }
}
