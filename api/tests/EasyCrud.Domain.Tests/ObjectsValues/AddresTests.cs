using Bogus;
using EasyCrud.Shared.DomainObjects;
using EasyCrud.Tests;
using FluentAssertions;
using Xunit;

namespace EasyCrud.Domain.Tests
{
    public class AddresTests
    {
        private readonly Faker _faker;

        public AddresTests()
        {
            _faker = FakerBuilder.New().Build();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ShouldRequireValidCity(string city)
        {
            var domainException = Assert.Throws<DomainException>(() =>
            new Address(city, _faker.Address.State()));

            domainException.Should().NotBeNull();
            domainException.Message.Should().NotBeNullOrEmpty();
            domainException.Message.Should().Be("City is required.");
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ShouldRequireValidState(string state)
        {
            var domainException = Assert.Throws<DomainException>(() =>
            new Address(_faker.Address.City(), state));

            domainException.Should().NotBeNull();
            domainException.Message.Should().NotBeNullOrEmpty();
            domainException.Message.Should().Be("State is required.");
        }
    }
}
