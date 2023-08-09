using Logistica_Data.DataModels.SatControlModels;
using System.Xml.Serialization;

namespace Logistica_API.Services
{
    public static class SatControlService
    {
        private static readonly string baseUrl = "https://web1ws.shareservice.co/wsHistoryGetByPlate.asmx";
        private static readonly string sLogin = "Sistemassilogisticaecu";
        private static readonly string sPassword = "sistemassilogisticaecu2023";
        private static readonly HttpClient client = new();

        public static async Task<List<Item>> GetMobileListAsync()
        {
            var urlReq = new UriBuilder(baseUrl + "/GetMobileList")
            {
                Query = $"sLogin={sLogin}&sPassword={sPassword}"
            };

            var response = client.GetAsync(urlReq.Uri).Result;
            var responseBody = await response.Content.ReadAsStringAsync();

            BaseItems? result;

            XmlSerializer serializer = new(typeof(BaseItems));

            using (StringReader reader = new(responseBody))
            {
                result = (BaseItems?)serializer.Deserialize(reader);
            }

            return result?.Response?.Mobile?.Item ?? new List<Item>();


        }
    }
}
