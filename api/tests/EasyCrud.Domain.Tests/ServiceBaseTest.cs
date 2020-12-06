using AutoMapper;
using EasyCrud.Domain.Services.AutoMapper;

namespace EasyCrud.Domain.Tests
{
    public class ServiceBaseTest
    {
        protected readonly IMapper _mapper;

        public ServiceBaseTest()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();
            });

            _mapper = mapperConfiguration.CreateMapper();
        }
    }
}
