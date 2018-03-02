using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantTracking.Domain.Models
{
    public class Entrevista
    {
        public int EntrevistaId { get; set; }
        public DateTime? FechaProgramada { get; set; }
        public DateTime? FechaIniciada { get; set; }
        public DateTime? FechaFinalizada { get; set; }
    }
}
