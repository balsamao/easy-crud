using EasyCrud.Shared.DomainObjects;

namespace EasyCrud.Tests
{
    public class AddressFake
    {
        public static Address Build()
        {
            var _fakerBuilder = FakerBuilder.New().Build();
            return new Address(_fakerBuilder.Address.City(), _fakerBuilder.Address.State());
        }
    }
}
