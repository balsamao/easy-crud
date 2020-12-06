using EasyCrud.Tests;

namespace EasyCrud.Infra.Tests
{
    public abstract class ConfigurationTest
    {
        protected EasyDbContext _db;

        public ConfigurationTest()
        {
            _db = DbContextBuilder.Make(DependenceInjectionTest.Make());
        }
    }
}
