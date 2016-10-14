using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XamarinWeb.Api
{
    public class WCFApi
    {
        public WCFApi()
        {

        }


        public static async Task<List<Model.Repo>> GetReposAsync()
        {
            using (var client = new HttpClient())
            {

                //var customObject = new CustomClass() { Name = "John", Id = 333 };
                //var serialized = JsonConvert.SerializeObject(new { obj = customObject });

                //var httpClient = new HttpClient();
                //var request = new StringContent(serialized, Encoding.UTF8, "application/json");
                //var response = await httpClient.PostAsync("http://localhost:49452/Metrics.svc/LogStartup", request);
                //string content = await response.Content.ReadAsStringAsync();
                //        [OperationContract]
                //[WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
                //ClassGetPagedList<T> GetList(GetListParam queryParam);

                dynamic queryParam = new GetListParam() { };
                var serialized = JsonConvert.SerializeObject(new { obj = queryParam });
                var request = new StringContent(serialized, Encoding.UTF8, "application/json");
                
                var json = await client.PostAsync(new Uri("http://localhost/PubliWeb/Services/AnexoService.svc/GetList"), request);
                
                var repos = new List<Model.Repo>();
                if (json.IsSuccessStatusCode)
                {
                    var content = await json.Content.ReadAsStringAsync();
                    repos = JsonConvert.DeserializeObject<List<Model.Repo>>(content);
                }

                return repos;
            }
        }

    }
}
