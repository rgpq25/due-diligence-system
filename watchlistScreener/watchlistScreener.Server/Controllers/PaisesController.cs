using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using watchlistScreener.Server.Data;

namespace watchlistScreener.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public PaisesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult GetAllPaises()
        {
            var allPaises = dbContext.Paises.ToList();
            return Ok(allPaises);
        }
    }
}
