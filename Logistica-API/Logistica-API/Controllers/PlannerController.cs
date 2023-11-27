using Logistica_API.Services;
using Logistica_Data.DataModels;
using Logistica_Data.DataModels.SatControlModels;
using Microsoft.AspNetCore.Mvc;

namespace Logistica_API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class PlannerController : ControllerBase
    {

        private readonly ILogger<PlannerController> _logger;


        public PlannerController(ILogger<PlannerController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = "GetPlannerHistory")]
        public async Task<IEnumerable<IGrouping<DateTime?,Planner>>> GetPlannerHistoryAsync()
        {
            _logger.LogInformation("Fetching information about Planner");
            var tableReference = AzureStorageService.GetTableReference("PlannerData");
            var result = await AzureStorageService.GetPlannerInfo(tableReference);
            var resultList = result.GroupBy(x => x.DateCreated?.Date);
            return resultList;
        }
    }
}
