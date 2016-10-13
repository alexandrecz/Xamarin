using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XamarinWeb.Model;

namespace XamarinWeb.Api
{
    public class RestApi
    {

        HttpClient client;
        Model.Repo repo;

        public RestApi()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }



        public static async Task<List<Model.Repo>> GetReposAsync()
        {
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.Add("User-Agent", "Other");

                var json = await client.GetAsync(new Uri("http://192.168.25.167/WebApp/api/githubalexandre"));
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
