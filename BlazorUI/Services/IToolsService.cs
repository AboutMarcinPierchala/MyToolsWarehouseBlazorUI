using BlazorMyToolsMag33.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMyToolsMag33.Services
{
    public interface IToolsService
    {
        Task<IEnumerable<Tool>> GetAll();
        Task<int> Create(Tool tool);
        Task<int> Delete(int Id);
        Task<int> Update(Tool tool);
        Task<Tool> GetById(int Id);
    }
}
