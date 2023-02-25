using Logistica_Data.DataModels;
using Logistica_Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Logistica_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RutasController : ControllerBase
    {
        private readonly ILogger<RutasController> _logger;
        public RutasController(ILogger<RutasController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRutas")]
        public IEnumerable<Rutas> Get()
        {
            _logger.LogInformation("Fetching information about Rutas");
            var result = DataBaseService.GetRutas();
            return result;
        }
    }
}
