namespace watchlistScreener.Models
{
    public class AddProveedorDto
    {
        public required string RazonSocial { get; set; }
        public required string NombreComercial { get; set; }
        public required int IdentificacionTributaria { get; set; }
        public required string NumeroTelefonico { get; set; }
        public required string CorreoElectronico { get; set; }
        public required string SitioWeb { get; set; }
        public required string DireccionFisica { get; set; }
        public required string Pais { get; set; }
        public required double FacturacionAnual { get; set; }
    }
}
