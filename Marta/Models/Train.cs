using Newtonsoft.Json;
using System;

namespace Marta.Models
{
    public class Train
    {
        [JsonProperty("DESTINATION")]
        public string Destination { get; set; }

        [JsonProperty("DIRECTION")]
        public string Direction { get; set; }

        [JsonProperty("EVENT_TIME")]
        public DateTime EventTime { get; set; }

        [JsonProperty("LINE")]
        public string Line { get; set; }

        [JsonProperty("NEXT_ARR")]
        public string NextArrival { get; set; }

        [JsonProperty("STATION")]
        public string Station { get; set; }

        [JsonProperty("TRAIN_ID")]
        public long TrainId { get; set; }

        [JsonProperty("WAITING_SECONDS")]
        public long WaitingSeconds { get; set; }

        [JsonProperty("WAITING_TIME")]
        public string WaitingTime { get; set; }
    }
}