using AutoMapper;
using EasyCrud.Domain.Dtos;
using EasyCrud.Domain.Entities;
using EasyCrud.Domain.Services.AutoMapper.Extensions;

namespace EasyCrud.Domain.Services.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Developer, DeveloperDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.City, opt => opt.MapFrom(entity => entity.Address.City))
                .ForMember(dto => dto.State, opt => opt.MapFrom(entity => entity.Address.State))
                .ForMember(dto => dto.Linkedin, opt => opt.MapFrom(entity => entity.Contact.Linkedin))
                .ForMember(dto => dto.Phone, opt => opt.MapFrom(entity => entity.Contact.Phone));
            CreateMap<DeveloperDto, Developer>().ConstructUsing(dto => DeveloperMapExtension.Convert(dto));

            CreateMap<DeveloperPreference, DeveloperPreferenceDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.DeveloperId, opt => opt.MapFrom(entity => entity.DeveloperId))
                .ForMember(dto => dto.UpToFourHoursPerDay, opt => opt.MapFrom(entity => entity.Willingness.UpToFourHoursPerDay))
                .ForMember(dto => dto.FourToSixHoursPerDay, opt => opt.MapFrom(entity => entity.Willingness.FourToSixHoursPerDay))
                .ForMember(dto => dto.SixtoEightHoursPerDay, opt => opt.MapFrom(entity => entity.Willingness.SixtoEightHoursPerDay))
                .ForMember(dto => dto.UpToEightHoursADay, opt => opt.MapFrom(entity => entity.Willingness.UpToEightHoursADay))
                .ForMember(dto => dto.OnlyWeekends, opt => opt.MapFrom(entity => entity.Willingness.OnlyWeekends))
                .ForMember(dto => dto.Morning, opt => opt.MapFrom(entity => entity.WorkTime.Morning))
                .ForMember(dto => dto.Afternoon, opt => opt.MapFrom(entity => entity.WorkTime.Afternoon))
                .ForMember(dto => dto.Night, opt => opt.MapFrom(entity => entity.WorkTime.Night))
                .ForMember(dto => dto.Dawn, opt => opt.MapFrom(entity => entity.WorkTime.Dawn))
                .ForMember(dto => dto.Business, opt => opt.MapFrom(entity => entity.WorkTime.Business));

            CreateMap<DeveloperPreferenceDto, DeveloperPreference>().ConstructUsing(dto =>
            new DeveloperPreference(dto.Id, dto.DeveloperId, WillingnessMapExtension.ConvertToDeveloperWillingness.Compile().Invoke(dto),
                   WorkTimeMapExtension.ConvertToDeveloperWorkTime.Compile().Invoke(dto)));

            CreateMap<DeveloperSkills, DeveloperSkillsDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.DeveloperId, opt => opt.MapFrom(entity => entity.DeveloperId))
                .ForMember(dto => dto.AditionalInformation, opt => opt.MapFrom(entity => entity.AditionalInformation))
                .ForMember(dto => dto.LinkCrud, opt => opt.MapFrom(entity => entity.LinkCrud))
                .ForMember(dto => dto.Ionic, opt => opt.MapFrom(entity => entity.Knowledge.Ionic))
                    .ForMember(dto => dto.ReactJS, opt => opt.MapFrom(entity => entity.Knowledge.ReactJS))
                    .ForMember(dto => dto.ReactNative, opt => opt.MapFrom(entity => entity.Knowledge.ReactNative))
                    .ForMember(dto => dto.Android, opt => opt.MapFrom(entity => entity.Knowledge.Android))
                    .ForMember(dto => dto.Flutter, opt => opt.MapFrom(entity => entity.Knowledge.Flutter))
                    .ForMember(dto => dto.SWIFT, opt => opt.MapFrom(entity => entity.Knowledge.SWIFT))
                    .ForMember(dto => dto.IOS, opt => opt.MapFrom(entity => entity.Knowledge.IOS))
                    .ForMember(dto => dto.HTML, opt => opt.MapFrom(entity => entity.Knowledge.HTML))
                    .ForMember(dto => dto.CSS, opt => opt.MapFrom(entity => entity.Knowledge.CSS))
                    .ForMember(dto => dto.Bootstrap, opt => opt.MapFrom(entity => entity.Knowledge.Bootstrap))
                    .ForMember(dto => dto.Jquery, opt => opt.MapFrom(entity => entity.Knowledge.Jquery))
                    .ForMember(dto => dto.AngularJs, opt => opt.MapFrom(entity => entity.Knowledge.AngularJs))
                    .ForMember(dto => dto.Angular, opt => opt.MapFrom(entity => entity.Knowledge.Angular))
                    .ForMember(dto => dto.Java, opt => opt.MapFrom(entity => entity.Knowledge.Java))
                    .ForMember(dto => dto.Python, opt => opt.MapFrom(entity => entity.Knowledge.Python))
                    .ForMember(dto => dto.Flask, opt => opt.MapFrom(entity => entity.Knowledge.Flask))
                    .ForMember(dto => dto.AspNetMVC, opt => opt.MapFrom(entity => entity.Knowledge.AspNetMVC))
                    .ForMember(dto => dto.AspNetWebForm, opt => opt.MapFrom(entity => entity.Knowledge.AspNetWebForm))
                    .ForMember(dto => dto.C, opt => opt.MapFrom(entity => entity.Knowledge.C))
                    .ForMember(dto => dto.Csharp, opt => opt.MapFrom(entity => entity.Knowledge.Csharp))
                    .ForMember(dto => dto.NodeJS, opt => opt.MapFrom(entity => entity.Knowledge.NodeJS))
                    .ForMember(dto => dto.ExpressNodeJs, opt => opt.MapFrom(entity => entity.Knowledge.ExpressNodeJs))
                    .ForMember(dto => dto.Cake, opt => opt.MapFrom(entity => entity.Knowledge.Cake))
                    .ForMember(dto => dto.Django, opt => opt.MapFrom(entity => entity.Knowledge.Django))
                    .ForMember(dto => dto.Majento, opt => opt.MapFrom(entity => entity.Knowledge.Majento))
                    .ForMember(dto => dto.PHP, opt => opt.MapFrom(entity => entity.Knowledge.PHP))
                    .ForMember(dto => dto.Vue, opt => opt.MapFrom(entity => entity.Knowledge.Vue))
                    .ForMember(dto => dto.Wordpress, opt => opt.MapFrom(entity => entity.Knowledge.Wordpress))
                    .ForMember(dto => dto.Ruby, opt => opt.MapFrom(entity => entity.Knowledge.Ruby))
                    .ForMember(dto => dto.MySQLServer, opt => opt.MapFrom(entity => entity.Knowledge.MySQLServer))
                    .ForMember(dto => dto.MySQL, opt => opt.MapFrom(entity => entity.Knowledge.MySQL))
                    .ForMember(dto => dto.Salesforce, opt => opt.MapFrom(entity => entity.Knowledge.Salesforce))
                    .ForMember(dto => dto.Photoshop, opt => opt.MapFrom(entity => entity.Knowledge.Photoshop))
                    .ForMember(dto => dto.Illustrator, opt => opt.MapFrom(entity => entity.Knowledge.Illustrator))
                    .ForMember(dto => dto.SEO, opt => opt.MapFrom(entity => entity.Knowledge.SEO))
                    .ForMember(dto => dto.Laravel, opt => opt.MapFrom(entity => entity.Knowledge.Laravel));

            CreateMap<DeveloperSkillsDto, DeveloperSkills>().ConstructUsing(dto =>
            new DeveloperSkills(dto.Id, dto.DeveloperId, dto.AditionalInformation, dto.LinkCrud, SkillMapExtension.ConvertToDeveloperSkills.Compile().Invoke(dto)));
        }
    }
}
