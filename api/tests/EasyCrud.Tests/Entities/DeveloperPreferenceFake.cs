using Bogus;
using EasyCrud.Domain.Entities;

namespace EasyCrud.Tests
{
    public class DeveloperPreferenceFake
    {
        private static Faker _faker;
        private long _developerId;
        private long _id;

        public static DeveloperPreferenceFake New()
        {
            _faker = FakerBuilder.New().Build();

            return new DeveloperPreferenceFake()
            {
                _id = _faker.Random.Long(min: 1),
                _developerId = _faker.Random.Long(min: 1)
            };
        }

        public DeveloperPreferenceFake ApplyId(long id)
        {
            _id = id;
            return this;
        }

        public DeveloperPreferenceFake ApplyDeveloperId(long developerId)
        {
            _developerId = developerId;
            return this;
        }

        public DeveloperPreference Build()
        {
            return new DeveloperPreference(_id, _developerId, WillingnessFake.Build(), WorkTimeFake.Build());
        }
    }
}
