using Bogus;
using EasyCrud.Domain.Entities;

namespace EasyCrud.Tests
{
    public class DeveloperSkillsFake
    {
        private static Faker _faker;
        private long _developerId;
        private long _id;

        public static DeveloperSkillsFake New()
        {
            _faker = FakerBuilder.New().Build();

            return new DeveloperSkillsFake()
            {
                _id = _faker.Random.Long(min: 1),
                _developerId = _faker.Random.Long(min: 1)
            };
        }

        public DeveloperSkillsFake ApplyId(long id)
        {
            _id = id;
            return this;
        }

        public DeveloperSkillsFake ApplyDeveloperId(long developerId)
        {
            _developerId = developerId;
            return this;
        }

        public DeveloperSkills Build()
        {
            return new DeveloperSkills(_id, _developerId, "", "", KnowledgeFake.Build());
        }
    }
}
