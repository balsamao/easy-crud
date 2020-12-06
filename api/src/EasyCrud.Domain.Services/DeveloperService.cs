using AutoMapper;
using EasyCrud.Domain.Dtos;
using EasyCrud.Domain.Entities;
using EasyCrud.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyCrud.Domain.Services
{
    public class DeveloperService : IDeveloperService
    {
        private readonly IDeveloperRepository _developerRepository;
        private readonly IMapper _mapper;
        
        public IReadOnlyCollection<string> Errors { get; set; }

        public DeveloperService(IDeveloperRepository developerRepository, IMapper mapper)
        {
            _developerRepository = developerRepository;
            _mapper = mapper;

            Errors = new List<string>();
        }

        public async Task<long> ApplyADeveloper(DeveloperDto developerDto)
        {
            var entity = _mapper.Map<Developer>(developerDto);
            if (entity.Validate())
                return await _developerRepository.Insert(entity);

            Errors = entity.Errors;
            return 0;
        }

        public async Task UpdateAnApplicant(DeveloperDto developerDto)
        {
            var entity = _mapper.Map<Developer>(developerDto);
            var entityPreference = _mapper.Map<DeveloperPreference>(developerDto.Preference);
            var entitySkills = _mapper.Map<DeveloperSkills>(developerDto.Skills);

            if (entity.Validate() && entityPreference.Validate() && entitySkills.Validate())
            {
                await _developerRepository.Update(entity);
                await _developerRepository.UpdatePreference(entityPreference);
                await _developerRepository.UpdateSkills(entitySkills);
            }
            else
                Errors = entity.Errors;

            await Task.CompletedTask;
        }

        public async Task RemoveAnApplicant(long id)
        {
            await _developerRepository.Remove(id);
        }

        public async Task<List<DeveloperDto>> GetAllApplicants()
        {
            var developers = await _developerRepository.GetAll();
            return _mapper.Map<List<DeveloperDto>>(developers);
        }

        public async Task<DeveloperDto> GetAnApplicant(long id)
        {
            var developer = await _developerRepository.GetById(id);
            return _mapper.Map<DeveloperDto>(developer);
        }
    }
}
