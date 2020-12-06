using EasyCrud.Domain.Dtos;
using EasyCrud.Shared.DomainObjects;
using System;
using System.Linq.Expressions;

namespace EasyCrud.Domain.Services.AutoMapper.Extensions
{
    internal class WorkTimeMapExtension
    {
        public static Expression<Func<DeveloperPreferenceDto, WorkTime>> ConvertToDeveloperWorkTime
        {
            get
            {
                return dto => new WorkTime(dto.Morning, dto.Afternoon, dto.Night, dto.Dawn, dto.Business);
            }
        }
    }
}
