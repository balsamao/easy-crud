using EasyCrud.Domain.Entities;
using EasyCrud.Shared.Data;
using System.Threading.Tasks;

namespace EasyCrud.Domain.Repositories
{
    public interface IDeveloperRepository : IRepository<Developer>
    {
        Task UpdatePreference(DeveloperPreference entity);
        Task UpdateSkills(DeveloperSkills entity);
    }
}
