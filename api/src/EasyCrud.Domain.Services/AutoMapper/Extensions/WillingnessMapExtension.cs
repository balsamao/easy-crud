using EasyCrud.Domain.Dtos;
using EasyCrud.Shared.DomainObjects;
using System;
using System.Linq.Expressions;

namespace EasyCrud.Domain.Services.AutoMapper.Extensions
{
    internal class WillingnessMapExtension
    {
        public static Expression<Func<DeveloperPreferenceDto, Willingness>> ConvertToDeveloperWillingness
        {
            get
            {
                return dto => new Willingness(dto.UpToFourHoursPerDay, dto.FourToSixHoursPerDay,
                    dto.SixtoEightHoursPerDay, dto.UpToEightHoursADay, dto.OnlyWeekends);
            }
        }
    }
}
