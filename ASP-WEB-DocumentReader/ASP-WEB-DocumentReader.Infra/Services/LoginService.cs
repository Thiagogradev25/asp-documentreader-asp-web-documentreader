using ASP_WEB_DocumentReader.Domain.Core.Interfaces;
using ASP_WEB_DocumentReader.Domain.Models;
using Microsoft.AspNetCore.Components;
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
    public class LoginService : ILoginService
    {
        private readonly HttpClient _httpClient;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        private string _userKey = "user";
        public LoginResponse User { get; private set; } 

        public LoginService(HttpClient httpClient, NavigationManager navigationManager, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async void GetUser()
        {
            User = await _localStorageService.GetItem<LoginResponse>(_userKey);
        }

        public async Task Initialize()
        {
            User = await _localStorageService.GetItem<LoginResponse>(_userKey);
        }

        public async Task Login(LoginRequest model)
        {
            User = await Autentica(model);

            await _localStorageService.SetItem(_userKey, User);
        }

        public async Task Logout()
        {
            User = null;
            await _localStorageService.RemoveItem(_userKey);
            _navigationManager.NavigateTo("/Login");
        }

        public async Task<LoginResponse> Autentica(LoginRequest login)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/Login", login);

            var retorno = await response.Content.ReadAsStringAsync();

            UserResponse usuarioLogado = JsonConvert.DeserializeObject<UserResponse>(retorno);

            return usuarioLogado.login;
        }

    }
}
