using BlazorMyToolsMag33.Models;

namespace BlazorMyToolsMag33.Services
{
    public interface IAdminService
    {
        Task<IEnumerable<Admin>> GetAll();
    }
}
