using Newtonsoft.Json;

namespace SoftwareKobo.Study163.Models
{
    [JsonObject]
    public class Status
    {
        [JsonProperty("message")]
        public string Message
        {
            get;
            set;
        }

        [JsonProperty("code")]
        public int Code
        {
            get;
            set;
        }
    }
}