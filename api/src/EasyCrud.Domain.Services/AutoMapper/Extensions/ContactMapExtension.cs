using EasyCrud.Domain.Dtos;
using EasyCrud.Shared.DomainObjects;
using System;
using System.Linq.Expressions;

namespace EasyCrud.Domain.Services.AutoMapper.Extensions
{
    internal class ContactMapExtension
    {
        public static Expression<Func<DeveloperDto, Contact>> ConvertToContact
        {
            get
            {
                return dto => new Contact(dto.Phone, dto.Linkedin);
            }
        }
    }
}
