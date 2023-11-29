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

        [HttpPost(Name ="SavePlan")]
        public async Task<OkObjectResult> SavePlan( [FromBody] IList<Planner> plan)
        {
            _logger.LogInformation("Saving Plan info");
            var results = await Task.WhenAll(plan.Select(item => AzureStorageService.SafelySaveToTableStorage(item)));
            return Ok($"Added: {results?.Where(c =>c)?.Count()} successfully, Failed: {results?.Where(c => !c)?.Count()}");
        }

        [HttpPut(Name = "UpdatePlan")]
        public async Task<OkObjectResult> UpdatePlan([FromBody] IList<Planner> plan)
        {
            _logger.LogInformation("Updating Plan info");
            var results = await Task.WhenAll(plan.Select(item => AzureStorageService.SafelySaveToTableStorage(item)));
            return Ok($"Updated: {results?.Where(c => c)?.Count()} successfully, Failed: {results?.Where(c => !c)?.Count()}");
        }

        [HttpDelete(Name = "DeletePlan")]
        public async Task<OkObjectResult> DeletePlan([FromQuery] IList<string> plan)
        {
            _logger.LogInformation("Saving Plan info");
            var results = await Task.WhenAll( plan.Select( item =>  AzureStorageService.DeleteTableValue("PlannerData",item)));
            return Ok($"Deleted: {results?.Where(c => c)?.Count()}");
        }
    }
}
