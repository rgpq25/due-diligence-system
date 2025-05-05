using System.ComponentModel.DataAnnotations.Schema;

namespace watchlistScreener.Server.Models.Entities
{
    public class Proveedor
    {
        public Guid Id { get; set; }
        public required string RazonSocial { get; set; }
        public required string NombreComercial { get; set; }
        public required long IdentificacionTributaria { get; set; }
        public required string NumeroTelefonico { get; set; }
        public required string CorreoElectronico { get; set; }
        public required string SitioWeb { get; set; }
        public required string DireccionFisica { get; set; }
        public Guid PaisId { get; set; }

        [ForeignKey("PaisId")]
        public required Pais Pais { get; set; }
        public required double FacturacionAnual { get; set; }
        public required DateTime FechaUltimaEdicion { get; set; }
        public required Boolean EsActivo { get; set; }
    }
}
