using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace XamarinGit.ApiGit
{
    public class Api
    {
        /// <summary>
        /// Respository by name 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task<List<Model.Repo>> GetReposByNameAsync(string name)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Other");

                var json = await client.GetAsync(new Uri($"https://api.github.com/search/repositories?q= {name}"));
                var repos = new List<Model.Repo>();
                if (json.IsSuccessStatusCode)
                {
                    var content = await json.Content.ReadAsStringAsync();
                    dynamic ob = JsonConvert.DeserializeObject<dynamic>(content);
                    repos = JsonConvert.DeserializeObject<List<Model.Repo>>(ob.items.ToString());

                }

                return repos;
            }
        }

        /// <summary>
        /// Respository by username 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task<List<Model.Repo>> GetMyReposAsync(string name)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Other");

                var json = await client.GetAsync(new Uri("https://api.github.com/users/" + name + "/repos?type=owner"));
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
