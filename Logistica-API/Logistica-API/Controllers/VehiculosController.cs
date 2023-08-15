using Logistica_Data.DataModels;
using Logistica_Data;
using Microsoft.AspNetCore.Mvc;

namespace Logistica_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiculosController : ControllerBase
    {
        private readonly ILogger<VehiculosController> _logger;
        public VehiculosController(ILogger<VehiculosController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetVehiculos")]
        public IEnumerable<Vehiculos> Get()
        {
            _logger.LogInformation("Fetching information about Vehiculos");
            var result = DataBaseService.GetVehiculos();
            return result;
        }

    }
}
