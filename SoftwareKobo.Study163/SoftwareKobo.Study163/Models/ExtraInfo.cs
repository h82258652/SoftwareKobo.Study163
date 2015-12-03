using Newtonsoft.Json;

namespace SoftwareKobo.Study163.Models
{
    [JsonObject]
    public class ExtraInfo
    {
        // TODO
        // 初步推测，若返回1449140159623，则实际是1449140159.623这样的时间戳。
        [JsonProperty("currentTime")]
        public long CurrentTime
        {
            get;
            set;
        }
    }
}