using Logistica_API.Services;
using Logistica_Data.DataModels.SatControlModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Logistica_API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class SatControlController : ControllerBase
    {
        private readonly ILogger<SatControlController> _logger;

        public SatControlController(ILogger<SatControlController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name ="GetMobileList")]
        public async Task<IEnumerable<MobileItem>> GetMobileListAsync()
        {
            _logger.LogInformation("Fetching information about Mobile List");
            var result = await SatControlService.GetMobileListAsync();
            return result;
        }

        [HttpGet(Name ="GetHistoryByPlate")]
        public async Task<PlateHistory> GetHistoryByPlateAsync([FromQuery] string Plate)
        {
            _logger.LogInformation("Fetching information about Plates");
            var result = await SatControlService.GetHistoryByPlateAsync(Plate);
            return result;
        }

        [HttpGet(Name = "GetZonesByPlateAndDate")]
        public async Task<List<PlateZone>> GetZonesByPlateAndDate([FromQuery] string Plate, [FromQuery] DateTime StartDate , [FromQuery] DateTime EndDate)
        {
            _logger.LogInformation("Fetching information about Plates");
            var result = await SatControlService.GetZonesByPlateAndDateAsync(Plate, StartDate, EndDate);
            return result;
        }



    }
}
