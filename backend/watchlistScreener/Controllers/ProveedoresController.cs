using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using watchlistScreener.Data;
using watchlistScreener.Models;
using watchlistScreener.Models.Entities;

namespace watchlistScreener.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedoresController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public ProveedoresController(ApplicationDbContext dbContext) {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult GetAllProveedores()
        {
            var allProveedores = dbContext.Proveedores.ToList();
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
        public IActionResult AddProveedor(AddProveedorDto addProveedorDto)
        {
            var proveedorEntity = new Proveedor()
            {
                RazonSocial = addProveedorDto.RazonSocial,
                NombreComercial = addProveedorDto.NombreComercial,
                IdentificacionTributaria = addProveedorDto.IdentificacionTributaria,
                NumeroTelefonico = addProveedorDto.NumeroTelefonico,
                CorreoElectronico = addProveedorDto.CorreoElectronico,
                SitioWeb = addProveedorDto.SitioWeb,
                DireccionFisica = addProveedorDto.DireccionFisica,
                Pais = addProveedorDto.Pais,
                FacturacionAnual = addProveedorDto.FacturacionAnual,
                FechaUltimaEdicion = DateTime.UtcNow
        };

            dbContext.Proveedores.Add(proveedorEntity);
            dbContext.SaveChanges();

            return Ok(proveedorEntity);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateProveedor(Guid id, AddProveedorDto addProveedorDto)
        {
            var proveedor = dbContext.Proveedores.Find(id);

            if (proveedor is null)
            {
                return NotFound();
            }

            proveedor.RazonSocial = addProveedorDto.RazonSocial;
            proveedor.NombreComercial = addProveedorDto.NombreComercial;
            proveedor.IdentificacionTributaria = addProveedorDto.IdentificacionTributaria;
            proveedor.NumeroTelefonico = addProveedorDto.NumeroTelefonico;
            proveedor.CorreoElectronico = addProveedorDto.CorreoElectronico;
            proveedor.SitioWeb = addProveedorDto.SitioWeb;
            proveedor.DireccionFisica = addProveedorDto.DireccionFisica;
            proveedor.Pais = addProveedorDto.Pais;
            proveedor.FacturacionAnual = addProveedorDto.FacturacionAnual;
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

            dbContext.Proveedores.Remove(proveedor);
            dbContext.SaveChanges();

            return Ok();
        }
    }
}
