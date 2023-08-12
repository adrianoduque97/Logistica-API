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

        public static async Task<List<MobileItem>> GetMobileListAsync()
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

            return result?.Response?.Mobile?.Item ?? new List<MobileItem>();


        }

        public static async Task<PlateHistory> GetHistoryByPlateAsync(string Plate)
        {
            var urlReq = new UriBuilder(baseUrl + "/HistoyDataLastLocationByPlate")
            {
                Query = $"sLogin={sLogin}&sPassword={sPassword}&sPlate={Plate}"
            };

            var response = client.GetAsync(urlReq.Uri).Result;
            var responseBody = await response.Content.ReadAsStringAsync();

            BasePlateHistory? result;

            XmlSerializer serializer = new(typeof(BasePlateHistory));

            using (StringReader reader = new(responseBody))
            {
                result = (BasePlateHistory?)serializer.Deserialize(reader);
            }

            return result?.Response?.Plate?.Hst ?? new PlateHistory();


        }
    }
}
