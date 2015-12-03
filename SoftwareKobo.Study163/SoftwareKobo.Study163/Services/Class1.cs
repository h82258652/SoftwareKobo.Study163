using Newtonsoft.Json;
using SoftwareKobo.Study163.Models;
using System;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace SoftwareKobo.Study163.Services
{
    public class Class1
    {
        public async Task<RootObject> Method1()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync(new Uri("http://study.163.com/mob/index/newAllMix/v1"), null);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<RootObject>(json);
            }
        }
    }
}