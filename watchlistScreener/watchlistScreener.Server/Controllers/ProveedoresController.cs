using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using watchlistScreener.Server.Data;
using watchlistScreener.Server.Models;
using watchlistScreener.Server.Models.Entities;

namespace watchlistScreener.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedoresController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public ProveedoresController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult GetAllProveedores()
        {
            var allProveedores = dbContext.Proveedores
                .Where(p => p.EsActivo == true)
                .Include(p => p.Pais)
                .ToList();

            return Ok(allProveedores);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetProveedorById(Guid id)
        {
            var proveedor = dbContext.Proveedores.Find(id);

            if (proveedor is null)
            {
                return NotFound();
            }

            return Ok(proveedor);
        }

        [HttpPost]
        public IActionResult AddProveedor(AddProveedorDto dto)
        {
            var pais = dbContext.Paises.Find(dto.PaisId);
            if (pais is null)
            {
                return BadRequest("País no válido.");
            }

            var nuevoProveedor = new Proveedor()
            {
                RazonSocial = dto.RazonSocial,
                NombreComercial = dto.NombreComercial,
                IdentificacionTributaria = dto.IdentificacionTributaria,
                NumeroTelefonico = dto.NumeroTelefonico,
                CorreoElectronico = dto.CorreoElectronico,
                SitioWeb = dto.SitioWeb,
                DireccionFisica = dto.DireccionFisica,
                PaisId = dto.PaisId,
                Pais = pais,
                FacturacionAnual = dto.FacturacionAnual,
                FechaUltimaEdicion = DateTime.UtcNow,
                EsActivo = true
            };

            dbContext.Proveedores.Add(nuevoProveedor);
            dbContext.SaveChanges();

            return Ok(nuevoProveedor);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateProveedor(Guid id, AddProveedorDto dto)
        {
            var proveedor = dbContext.Proveedores.Find(id);
            if (proveedor is null)
            {
                return NotFound();
            }

            var pais = dbContext.Paises.Find(dto.PaisId);
            if (pais is null)
            {
                return BadRequest("País no válido.");
            }

            proveedor.RazonSocial = dto.RazonSocial;
            proveedor.NombreComercial = dto.NombreComercial;
            proveedor.IdentificacionTributaria = dto.IdentificacionTributaria;
            proveedor.NumeroTelefonico = dto.NumeroTelefonico;
            proveedor.CorreoElectronico = dto.CorreoElectronico;
            proveedor.SitioWeb = dto.SitioWeb;
            proveedor.DireccionFisica = dto.DireccionFisica;
            proveedor.PaisId = dto.PaisId;
            proveedor.Pais = pais;
            proveedor.FacturacionAnual = dto.FacturacionAnual;
            proveedor.FechaUltimaEdicion = DateTime.UtcNow;

            dbContext.SaveChanges();
            return Ok(proveedor);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteProveedor(Guid id)
        {
            var proveedor = dbContext.Proveedores.Find(id);

            if (proveedor is null)
            {
                return NotFound();
            }

            proveedor.EsActivo = false;
            dbContext.SaveChanges();

            return Ok();
        }
    }
}
