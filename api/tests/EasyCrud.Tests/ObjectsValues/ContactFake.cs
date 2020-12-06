using EasyCrud.Shared.DomainObjects;

namespace EasyCrud.Tests
{
    public class ContactFake
    {
        public static Contact Build()
        {
            var _fakerBuilder = FakerBuilder.New().Build();
            return new Contact(_fakerBuilder.Person.Phone, "");
        }
    }
}
