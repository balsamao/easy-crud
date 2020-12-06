using EasyCrud.Shared.DomainObjects.ObjectsValues;

namespace EasyCrud.Shared.DomainObjects
{
    public class Address : ObjectValue
    {
        public string City { get; private set; }
        public string State { get; private set; }

        protected Address() { }

        public Address(string city, string state)
        {
            City = city;
            State = state;

            Validate();
        }

        public void ApplyCity(string city)
        {
            City = city;
        }

        public void ApplyState(string state)
        {
            State = state;
        }

        public override void Validate()
        {
            Validation.IsEmpty(City, $"City is required.");
            Validation.IsEmpty(State, $"State is required.");
        }
    }
}
