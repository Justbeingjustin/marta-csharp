using Marta.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marta.Services
{
    public class TrainRepository : ITrainRepository
    {
        private readonly string _apiKey;
        private string baseUrl = @"http://developer.itsmarta.com";
        private string trainPath = @"/RealtimeTrain/RestServiceNextTrain/GetRealtimeArrivals";
        private string cacheControl = "Cache-Control";
        private string noCache = "no-cache";

        public TrainRepository(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<List<Train>> GetTrainsAsync()
        {
            var client = new RestClient(baseUrl + trainPath + "?apiKey=" + _apiKey);
            var request = new RestRequest(Method.GET);
            request.AddHeader(cacheControl, noCache);
            var getTrainResponse = await client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<List<Train>>(getTrainResponse.Content);
        }
    }
}