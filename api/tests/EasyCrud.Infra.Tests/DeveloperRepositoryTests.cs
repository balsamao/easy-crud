using Shouldly;
using EasyCrud.Infra.Repositories;
using EasyCrud.Tests;
using System.Threading.Tasks;
using Xunit;
using System.Linq;

namespace EasyCrud.Infra.Tests
{
    public class DeveloperRepositoryTest : ConfigurationTest
    {
        private readonly DeveloperRepository _developerRepository;

        public DeveloperRepositoryTest()
        {
            _developerRepository = new DeveloperRepository(_db);
        }

        [Fact]
        public async Task<long> ShouldBeInsertANewDeveloper()
        {
            var newId = await _developerRepository.Insert(DeveloperFake.New().Build());

            newId.ShouldNotBe(0);

            return newId;
        }

        [Fact]
        public async Task ShouldBeUpdateADeveloper()
        {
            var obj1 = _db.Developers.FirstOrDefault();
            obj1.ApplyName("Changed the Name");
            await _developerRepository.Update(obj1);

            var obj2 = _db.Developers.FirstOrDefault();

            obj1.Name.ShouldBe(obj2.Name);
        }

        [Fact]
        public async Task ShouldBeRemoveADeveloper()
        {
            var id = await ShouldBeInsertANewDeveloper();
            await _developerRepository.Remove(id);

            var entity = _db.Developers.FirstOrDefault(d => d.Id == id);

            entity.ShouldBeNull();
        }
    }
}
