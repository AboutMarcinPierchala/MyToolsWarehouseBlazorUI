using BlazorMyToolsMag33.Models;

namespace BlazorMyToolsMag33.Services
{
    public class AdminService : IAdminService
    {
        private IHttpService _httpService;

        public AdminService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<Admin>> GetAll()
        {
            return await _httpService.Get<IEnumerable<Admin>>("/admins");
        }
    }

}
