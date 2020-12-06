using EasyCrud.Domain.Dtos;
using EasyCrud.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace EasyCrud.Domain.Services.AutoMapper.Extensions
{
    internal class DeveloperMapExtension
    {
        public static Developer Convert(DeveloperDto dto)
        {
            return ConvertToDeveloper.Compile().Invoke(dto);
        }

        public static Expression<Func<DeveloperDto, Developer>> ConvertToDeveloper
        {
            get
            {
                return dto => new Developer(dto.Id, dto.Email, dto.Name, dto.Portfolio, dto.HourlySalary,
                    ContactMapExtension.ConvertToContact.Compile().Invoke(dto), AddressMapExtension.ConvertToAddress.Compile().Invoke(dto),
                    new DeveloperPreference(dto.Preference.Id, dto.Id, WillingnessMapExtension.ConvertToDeveloperWillingness.Compile().Invoke(dto.Preference),
                    WorkTimeMapExtension.ConvertToDeveloperWorkTime.Compile().Invoke(dto.Preference)),
                    new DeveloperSkills(dto.Skills.Id, dto.Id, dto.Skills.AditionalInformation, dto.Skills.LinkCrud, SkillMapExtension.ConvertToDeveloperSkills.Compile().Invoke(dto.Skills)));

            }
        }
    }
}
