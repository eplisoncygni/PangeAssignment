using Newtonsoft.Json;
using Pangea.Services.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Pangea.Services.Service
{
    public class QueryRepoService : IQueryRepoService
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<dynamic> ProcessRepo(string repoUrl)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", "Nirajan API");

            var stringTask = await client.GetStringAsync("https://api.github.com/users/pangea/repos");
            var dynamicHttpRespone = JsonConvert.DeserializeObject(stringTask);

            return dynamicHttpRespone;
        }
    }
}
