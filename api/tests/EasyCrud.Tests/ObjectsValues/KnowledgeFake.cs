using EasyCrud.Shared.DomainObjects;

namespace EasyCrud.Tests
{
    public class KnowledgeFake
    {
        public static Knowledge Build()
        {
            var _fakerBuilder = FakerBuilder.New().Build();
            return new Knowledge(
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5), 
                (Weight)_fakerBuilder.Random.Int(0, 5),
                (Weight)_fakerBuilder.Random.Int(0, 5));
        }
    }
}
