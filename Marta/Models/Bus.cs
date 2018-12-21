using Newtonsoft.Json;
using System;

namespace Marta.Models
{
    public class Bus
    {
        [JsonProperty("adherence")]
        public string Adherence { get; set; }

        [JsonProperty("block_abbr")]
        public string BlockAbbr { get; set; }

        [JsonProperty("block_id")]
        public long BlockId { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("route")]
        public long Route { get; set; }

        [JsonProperty("stop_id")]
        public long StopId { get; set; }

        [JsonProperty("timepoint")]
        public string Timepoint { get; set; }

        [JsonProperty("trip_id")]
        public long TripId { get; set; }

        [JsonProperty("vehicle")]
        public long Vehicle { get; set; }
    }
}