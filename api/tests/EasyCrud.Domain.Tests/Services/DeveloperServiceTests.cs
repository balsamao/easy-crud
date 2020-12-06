using EasyCrud.Domain.Dtos;
using EasyCrud.Domain.Entities;
using EasyCrud.Domain.Repositories;
using EasyCrud.Domain.Services;
using EasyCrud.Tests;
using Moq;
using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace EasyCrud.Domain.Tests.Services
{
    public class DeveloperServiceTests : ServiceBaseTest
    {
        private readonly Mock<IDeveloperRepository> _developerRepositoryMock;
        private readonly DeveloperService _developerService;

        public DeveloperServiceTests()
        {
            _developerRepositoryMock = new Mock<IDeveloperRepository>();
            _developerService = new DeveloperService(_developerRepositoryMock.Object, _mapper);
        }

        [Fact]
        public async Task<long> ShouldBeApplyANewDeveloper()
        {
            _developerRepositoryMock.Setup(s => s.Insert(It.IsAny<Developer>())).ReturnsAsync(FakerBuilder.New().Build().Random.Long(0, 10));

            var developerDto = _mapper.Map<DeveloperDto>(DeveloperFake.New().Build());

            var newId = await _developerService.ApplyADeveloper(developerDto);

            newId.ShouldNotBe(0);

            _developerRepositoryMock.Verify(s => s.Insert(It.Is<Developer>(p => p.Email == developerDto.Email)));

            return newId;
        }

        [Fact]
        public async Task ShouldBeUpdateAnApplicant()
        {
            long developerId = await ShouldBeApplyANewDeveloper();

            _developerRepositoryMock.Setup(s => s.Update(It.IsAny<Developer>()));

            var developerDto = _mapper.Map<DeveloperDto>(DeveloperFake.New().Build());
            developerDto.Id = developerId;

            await _developerService.UpdateAnApplicant(developerDto);

            _developerRepositoryMock.Verify(s => s.Update(It.Is<Developer>(p => p.Id == developerId)));
        }

        [Fact]
        public async Task ShouldBeRemoveAnApplicant()
        {
            long developerId = FakerBuilder.New().Build().Random.Long(min: 1);

            _developerRepositoryMock.Setup(s => s.Remove(It.IsAny<long>()));

            await _developerService.RemoveAnApplicant(developerId);

            _developerRepositoryMock.Verify(s => s.Remove(It.Is<long>(id => id == developerId)));
        }
    }
}
