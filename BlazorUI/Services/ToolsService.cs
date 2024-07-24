using BlazorMyToolsMag33.Models;
using System.ComponentModel.Design;

namespace BlazorMyToolsMag33.Services
{
    public class ToolsService : IToolsService
    {
        private IHttpService _httpService;

        public ToolsService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public Task<IEnumerable<Tool>> GetAll()
        {
            return _httpService.Get<IEnumerable<Tool>>("/Tools");
        }

        public async Task<int> Create(Tool tool)
        {
            var result = await _httpService.Post<Tool>("/Tools", tool);
            return result.Id;
        }

        public async Task<int> Delete(int id)
        {
            await _httpService.Delete($"/Tools/{id}");
            return id;

        }

        public async Task<int> Update(Tool tool)
        {
            await _httpService.Put<Tool>($"/Tools/{tool.Id}", tool);
            return tool.Id;
        }

        public Task<Tool> GetById(int id)
        {
            return _httpService.Get<Tool>($"/Tools/{id}");
        }

        public Task<Tool> GetByName(string name)
        {
            return _httpService.Get<Tool>($"/Tools/ToolName");
        }
    }
}
