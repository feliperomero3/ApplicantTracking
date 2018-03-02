using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantTracking.Domain.Models
{
    public class Vacante
    {
        public int VacanteId { get; set; }
        public string Titulo { get; set; }
        public string Puesto { get; set; }
        public string Departamento { get; set; }
        public string TipoContrato { get; set; }
        public string Empresa { get; set; }
        public DateTime? FechaCreada { get; set; }
        public DateTime? FechaModificada { get; set; }
        
    }
}
