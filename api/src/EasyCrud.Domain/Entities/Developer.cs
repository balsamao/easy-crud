using EasyCrud.Shared.DomainObjects;
using FluentValidation;

namespace EasyCrud.Domain.Entities
{
    public class Developer : Entity<Developer>, IAggregateRoot
    {
        protected Developer() { }
        public Developer(long id, string email, string name, string portfolio, decimal hourlySalary, 
            Contact contact, Address address, DeveloperPreference preference, DeveloperSkills skills) : base(id)
        {
            Email = email;
            Name = name;
            Portfolio = portfolio;
            HourlySalary = hourlySalary;
            Contact = contact;
            Address = address;
            Preference = preference;
            Skills = skills;

            Validate();
        }

        public string Email { get; private set; }
        public string Name { get; private set; }
        public string Portfolio { get; private set; }
        public decimal HourlySalary { get; set; }
        public Contact Contact { get; private set; }
        public Address Address { get; private set; }
        public DeveloperPreference Preference { get; set; }
        public DeveloperSkills Skills { get; set; }

        public void ApplyEmail(string email)
        {
            Email = email;
        }

        public void ApplyName(string name)
        {
            Name = name;
        }

        public void ApplyPortfolio(string portfolio)
        {
            Portfolio = portfolio;
        }

        public void ApplyHourlySalary(decimal hourlySalary)
        {
            HourlySalary = hourlySalary;
        }

        public void ApplyContact(Contact contact)
        {
            Contact = contact;
        }

        public void ApplyAddress(Address address)
        {
            Address = address;
        }

        public void ApplyAddress(DeveloperPreference developerPreference)
        {
            Preference = developerPreference;
        }

        public void ApplyAddress(DeveloperSkills developerSkills)
        {
            Skills = developerSkills;
        }

        public override bool Validate()
        {
            RuleFor(x => x.Email)
                .Must(email => !string.IsNullOrEmpty(email))
                .WithMessage("Email is required");

            RuleFor(x => x.Name)
                .Must(name => !string.IsNullOrEmpty(name))
                .WithMessage("Name is required");

            RuleFor(x => x.Contact)
                .NotNull()
                .WithMessage("Contact is required");

            RuleFor(x => x.Address)
                .NotNull()
                .WithMessage("Addres is required");

            RuleFor(x => x.Skills)
                .NotNull()
                .WithMessage("Skills is required");

            _validationResult = Validate(this);
            return _validationResult.IsValid;
        }
    }
}
