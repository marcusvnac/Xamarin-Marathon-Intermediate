using Lab03.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Services
{
    public static class Api
    {
        public static async Task<List<Tag>> GetTagsAsync()
        {
            const string BaseUrl = "https://monkey-hub-api.azurewebsites.net/api/";

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.GetAsync($"{BaseUrl}Tags").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                {
                    return JsonConvert.DeserializeObject<List<Tag>>(await new StreamReader(responseStream)
                        .ReadToEndAsync().ConfigureAwait(false));
                }
            }
            return null;
        }
    }
}
