using EasyCrud.Domain.Dtos;
using EasyCrud.Shared.DomainObjects;
using System;
using System.Linq.Expressions;

namespace EasyCrud.Domain.Services.AutoMapper.Extensions
{
    internal class AddressMapExtension
    {
        public static Expression<Func<DeveloperDto, Address>> ConvertToAddress
        {
            get
            {
                return dto => new Address(dto.City, dto.State);
            }
        }

    }
}
