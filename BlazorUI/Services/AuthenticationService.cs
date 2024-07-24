using BlazorMyToolsMag33.Models;
using BlazorMyToolsMag33.Helpers;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorMyToolsMag33.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;

        public Admin Admin { get; private set; }

        public AuthenticationService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService)
        {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task Initialize()
        {
            Admin = await _localStorageService.GetItem<Admin>("admin");
        }

        public async Task Login(string Username, string password)
        {
            Admin = await _httpService.Post<Admin>("/admins/authenticate", new { Username, password });
            Admin.AuthData = $"{Username}:{password}".EncodeBase64();
            await _localStorageService.SetItem("admin", Admin);
        }

        public async Task Logout()
        {
            Admin = null;
            await _localStorageService.RemoveItem("admin");
            _navigationManager.NavigateTo("login");
        }
    }
}
