namespace ApplicantTracking.Domain.Models
{
    public class Domicilio
    {
        public int DomicilioId { get; set; }
        public string Calle { get; set; }
        public string NumeroInterior { get; set; }
        public string NumeroExterior { get; set; }
        public string EntreCalles { get; set; }
        public string Colonia { get; set; }
        public string CodigoPostal { get; set; }
    }
}