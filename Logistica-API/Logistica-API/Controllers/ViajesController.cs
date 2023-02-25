
using Logistica_Data.DataModels;
using Logistica_Data;
using Microsoft.AspNetCore.Mvc;

namespace Logistica_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ViajesController : ControllerBase
    {
        private readonly ILogger<ViajesController> _logger;
        public ViajesController(ILogger<ViajesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetViajes")]
        public IEnumerable<Viajes> Get()
        {
            _logger.LogInformation("Fetching information about Viajes");
            var result = DataBaseService.GetViajes();
            return result;
        }
    }
}