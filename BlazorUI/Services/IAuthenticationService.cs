using BlazorMyToolsMag33.Models;

namespace BlazorMyToolsMag33.Services
{
    public interface IAuthenticationService
    {
        Admin Admin { get; }
        Task Initialize();
        Task Login(string username, string password);
        Task Logout();
    }
}
