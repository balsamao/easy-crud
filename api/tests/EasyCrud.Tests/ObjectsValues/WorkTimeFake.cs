using EasyCrud.Shared.DomainObjects;

namespace EasyCrud.Tests
{
    public class WorkTimeFake
    {
        public static WorkTime Build()
        {
            var _fakerBuilder = FakerBuilder.New().Build();
            return new WorkTime(_fakerBuilder.Random.Bool(),
                _fakerBuilder.Random.Bool(),
                _fakerBuilder.Random.Bool(),
                _fakerBuilder.Random.Bool(),
                _fakerBuilder.Random.Bool());

        }
    }
}
