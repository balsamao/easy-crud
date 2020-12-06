using Bogus;
using EasyCrud.Domain.Entities;

namespace EasyCrud.Tests
{
    public class DeveloperFake
    {
        private static Faker _faker;
        private long _id;

        public static DeveloperFake New()
        {
            _faker = FakerBuilder.New().Build();

            return new DeveloperFake()
            {
                _id = _faker.Random.Long(min: 1)
            };
        }

        public DeveloperFake ApplyId(long id)
        {
            _id = id;
            return this;
        }

        public Developer Build()
        {
            var _fakerBuilder = FakerBuilder.New().Build();
            return new Developer(
                _id, 
                _fakerBuilder.Person.Email,
                _fakerBuilder.Person.FullName,
                "",
                _fakerBuilder.Random.Decimal(0, 1000),
                ContactFake.Build(),
                AddressFake.Build(),
                DeveloperPreferenceFake.New().ApplyDeveloperId(_id).Build(),
                DeveloperSkillsFake.New().ApplyDeveloperId(_id).Build());
        }
    }
}
