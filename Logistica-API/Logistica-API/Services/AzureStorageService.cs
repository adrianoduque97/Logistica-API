using Logistica_Data.DataModels;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Azure.Cosmos.Table.Queryable;

namespace Logistica_API.Services
{
    public static class AzureStorageService
    {
        private static CloudStorageAccount _tableCloudStorageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=silogisticastorage;AccountKey=F0JnU2MD5BQg5XNd//GsvIa/xie5+rfzysBDy2lPkMWP7+/gFLAuUqstBz/sEfE7Ynu0h2Jg4c7D+AStsGwa3g==;EndpointSuffix=core.windows.net");


        public static async Task<List<Planner>> GetPlannerInfo(CloudTable plannerTable)
        {
            try
            {
                var itemQuery = plannerTable.CreateQuery<Planner>();
                var items = await QueryAsync(itemQuery);
                return items.ToList();
            }
            catch (Exception ex)
            {
                //log.LogError(ex, "Failure getting dependant branches");
                return new List<Planner>();
            }

        }

        public static async Task<List<T>> QueryAsync<T>(IQueryable<T> query) where T : ITableEntity, new()
        {
            TableQuerySegment<T> querySegment = null;
            List<T> models = new List<T>();

            while (querySegment == null || querySegment.ContinuationToken != null)
            {
                querySegment = await query.AsTableQuery()
                    .ExecuteSegmentedAsync(querySegment != null ? querySegment.ContinuationToken : null);
                models.AddRange(querySegment);
            }
            return models;
        }

        public static CloudTable GetTableReference(string tableName)
        {
            var cloudTableClient = _tableCloudStorageAccount.CreateCloudTableClient();
            return cloudTableClient.GetTableReference(tableName);
        }
    }
}
