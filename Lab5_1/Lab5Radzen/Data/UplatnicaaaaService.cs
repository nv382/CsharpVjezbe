using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace Lab5Radzen.Data
{
    public class UplatnicaaaaService
    {
        private readonly HttpClient httpClient;

        public UplatnicaaaaService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


        public async Task<IEnumerable<Uplatnicaaa>> GetUplatnicee()
        {
            return await httpClient.GetFromJsonAsync<Uplatnicaaa[]>("https://localhost:7258/api/Uplatnicas");
        }

    }
}
