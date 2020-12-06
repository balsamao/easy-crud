using EasyCrud.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyCrud.Domain.Services
{
    public interface IDeveloperService
    {
        IReadOnlyCollection<string> Errors { get; set; }
        Task<long> ApplyADeveloper(DeveloperDto developerDto);
        Task UpdateAnApplicant(DeveloperDto developerDto);
        Task RemoveAnApplicant(long id);
        Task<DeveloperDto> GetAnApplicant(long id);
        Task<List<DeveloperDto>> GetAllApplicants();
    }
}
