using Marta.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marta.Services
{
    public class BusRepository : IBusRepository
    {
        private readonly string _apiKey;

        private string baseUrl = @"http://developer.itsmarta.com";
        private string busPath = @"/BRDRestService/RestBusRealTimeService/GetAllBus";
        private string busRoutePath = @"/BRDRestService/RestBusRealTimeService/GetBusByRoute/";
        private string cacheControl = "Cache-Control";
        private string noCache = "no-cache";

        public BusRepository(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<List<Bus>> GetBusByRouteAsync(long route)
        {
            var client = new RestClient(baseUrl + busRoutePath + route + "?apiKey=" + _apiKey);
            var request = new RestRequest(Method.GET);
            request.AddHeader(cacheControl, noCache);
            var getTrainResponse = await client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<List<Bus>>(getTrainResponse.Content);
        }

        public async Task<List<Bus>> GetBusesAsync()
        {
            var client = new RestClient(baseUrl + busPath + "?apiKey=" + _apiKey);
            var request = new RestRequest(Method.GET);
            request.AddHeader(cacheControl, noCache);
            var getTrainResponse = await client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<List<Bus>>(getTrainResponse.Content);
        }
    }
}