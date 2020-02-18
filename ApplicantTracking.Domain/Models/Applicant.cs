using System;

namespace ApplicantTracking.Domain.Models
{
    public class Applicant
    {
        public int ApplicantId { get; set; }
        public string ApellidoParterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public Domicilio Domicilio { get; set; }
        public string Nacionalidad { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
    }
}
