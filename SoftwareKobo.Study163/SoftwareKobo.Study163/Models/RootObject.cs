using Newtonsoft.Json;

namespace SoftwareKobo.Study163.Models
{
    [JsonObject]
    public class RootObject
    {
        [JsonProperty("status")]
        public Status Status
        {
            get;
            set;
        }

        [JsonProperty("results")]
        public Results Results
        {
            get;
            set;
        }

        [JsonProperty("extraInfo")]
        public ExtraInfo ExtraInfo
        {
            get;
            set;
        }
    }
}