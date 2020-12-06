using EasyCrud.Shared.DomainObjects;
using FluentAssertions;
using Xunit;

namespace EasyCrud.Domain.Tests
{
    public class ContactTests
    {
        [Theory]
        [InlineData("","")]
        [InlineData(null,"")]
        public void ShouldRequireValidPhone(string phone, string linkedin)
        {
            var domainException = Assert.Throws<DomainException>(() =>
            new Contact(phone,linkedin));

            domainException.Should().NotBeNull();
            domainException.Message.Should().NotBeNullOrEmpty();
            domainException.Message.Should().Be("Phone is required.");
        }
    }
}
