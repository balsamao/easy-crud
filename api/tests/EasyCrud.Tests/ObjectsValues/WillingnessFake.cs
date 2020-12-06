using EasyCrud.Shared.DomainObjects;

namespace EasyCrud.Tests
{
    public class WillingnessFake
    {
        public static Willingness Build()
        {
            var _fakerBuilder = FakerBuilder.New().Build();
            return new Willingness(_fakerBuilder.Random.Bool(),
                _fakerBuilder.Random.Bool(),
                _fakerBuilder.Random.Bool(),
                _fakerBuilder.Random.Bool(),
                _fakerBuilder.Random.Bool());
                
        }
    }
}
