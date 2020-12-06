using EasyCrud.Shared.DomainObjects.ObjectsValues;

namespace EasyCrud.Shared.DomainObjects
{
    public class Contact : ObjectValue
    {
        public string Phone { get; private set; }
        public string Linkedin { get; private set; }

        protected Contact() { }
        public Contact(string phone, string linkedin)
        {
            Phone = phone;
            Linkedin = linkedin;

            Validate();
        }

        public void ApplyPhone(string linkedin)
        {
            Linkedin = linkedin;
        }

        public void ApplyLinkedin(string linkedin)
        {
            Linkedin = linkedin;
        }

        public override void Validate()
        {
            Validation.IsEmpty(Phone, "Phone is required.");
        }
    }
}
