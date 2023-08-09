using Logistica_Data.DataModels;
using Logistica_Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Logistica_API.Services;
using Logistica_Data.DataModels.SatControlModels;

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
        public async Task<IEnumerable<Item>> GetAsync()
        {
            _logger.LogInformation("Fetching information about Rutas");
            //var result = DataBaseService.GetRutas();
            var result = await SatControlService.GetMobileListAsync();
            return result;
        }
    }
}
