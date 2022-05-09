using ASP_API_DocumentReader.Domain.Models;
using ASP_WEB_DocumentReader.Domain.Core.Interfaces;
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

        public async Task<IEnumerable<MenuItem>> GetMenu()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<MenuItem>>("api/Menu");
        }
    }
}
