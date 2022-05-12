using ASP_API_DocumentReader.Domain.Models;
using ASP_WEB_DocumentReader.Domain.Core.Interfaces;
using ASP_WEB_DocumentReader.Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ASP_WEB_DocumentReader.Infra.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient _httpClient;

        public MenuService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<MenuItem>> GetMenu(Perfil perfil)
        {
            var retornoJson = await _httpClient.PostAsJsonAsync<Perfil>("api/Menu", perfil);

            return JsonConvert.DeserializeObject<IEnumerable<MenuItem>>(await retornoJson.Content.ReadAsStringAsync());
        }
    }
}
