using EasyCrud.Domain.Dtos;
using EasyCrud.Shared.DomainObjects;
using System;
using System.Linq.Expressions;

namespace EasyCrud.Domain.Services.AutoMapper.Extensions
{
    internal class SkillMapExtension
    {
        public static Expression<Func<DeveloperSkillsDto, Knowledge>> ConvertToDeveloperSkills
        {
            get
            {
                return dto => new Knowledge(
                    dto.Ionic,
                    dto.ReactJS,
                    dto.ReactNative,
                    dto.Android,
                    dto.Flutter,
                    dto.SWIFT,
                    dto.IOS,
                    dto.HTML,
                    dto.CSS,
                    dto.Bootstrap,
                    dto.Jquery,
                    dto.AngularJs,
                    dto.Angular,
                    dto.Java,
                    dto.Python,
                    dto.Flask,
                    dto.AspNetMVC,
                    dto.AspNetWebForm,
                    dto.C,
                    dto.Csharp,
                    dto.NodeJS,
                    dto.ExpressNodeJs,
                    dto.Cake,
                    dto.Django,
                    dto.Majento,
                    dto.PHP,
                    dto.Vue,
                    dto.Wordpress,
                    dto.Ruby,
                    dto.MySQLServer,
                    dto.MySQL,
                    dto.Salesforce,
                    dto.Photoshop,
                    dto.Illustrator,
                    dto.SEO,
                    dto.Laravel);
            }
        }
    }
}
