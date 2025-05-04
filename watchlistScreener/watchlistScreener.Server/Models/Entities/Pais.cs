namespace watchlistScreener.Server.Models.Entities
{
    public class Pais
    {
        public Guid Id { get; set; }
        public required string Nombre { get; set; }
        public required string Codigo { get; set; }
    }
}
