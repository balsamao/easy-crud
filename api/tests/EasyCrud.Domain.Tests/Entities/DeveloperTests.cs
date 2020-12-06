using Bogus;
using EasyCrud.Domain.Entities;
using EasyCrud.Tests;
using FluentAssertions;
using Xunit;

namespace EasyCrud.Domain.Tests
{
    public class DeveloperTests
    {
        private readonly Faker _faker;

        public DeveloperTests()
        {
            _faker = FakerBuilder.New().Build();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ShouldRequireValidEmail(string email)
        {
            var entity = new Developer(1, email, null, null, 0, null, null, null, null);
            var validation = entity.Validate();

            validation.Should().BeFalse();
            entity.Errors.Should().NotBeNullOrEmpty();
            entity.Errors.Should().Contain("Email is required");
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ShouldRequireValidName(string name)
        {
            var entity = new Developer(1, _faker.Person.Email, name, null, 0, null, null, null, null);
            var validation = entity.Validate();

            validation.Should().BeFalse();
            entity.Errors.Should().NotBeNullOrEmpty();
            entity.Errors.Should().Contain("Name is required");
        }

        [Fact]
        public void ShouldRequireValidContact()
        {
            var entity = new Developer(_faker.Random.Long(), _faker.Person.Email, _faker.Person.FullName, null, 0, null, null, null, null);
            var validation = entity.Validate();

            validation.Should().BeFalse();
            entity.Errors.Should().NotBeNullOrEmpty();
            entity.Errors.Should().Contain("Contact is required");
        }

        [Fact]
        public void ShouldRequireValidAddress()
        {
            var entity = new Developer(_faker.Random.Long(), _faker.Person.Email, _faker.Person.FullName, null, 0, ContactFake.Build(), null, null, null);
            var validation = entity.Validate();

            validation.Should().BeFalse();
            entity.Errors.Should().NotBeNullOrEmpty();
            entity.Errors.Should().Contain("Addres is required");
        }

        [Fact]
        public void ShouldRequireValidSkills()
        {
            var entity = new Developer(_faker.Random.Long(), _faker.Person.Email, _faker.Person.FullName, null, 0, ContactFake.Build(), AddressFake.Build(), null, null);
            var validation = entity.Validate();

            validation.Should().BeFalse();
            entity.Errors.Should().NotBeNullOrEmpty();
            entity.Errors.Should().Contain("Skills is required");
        }

    }
}
