using EasyCrud.Shared.DomainObjects;

namespace EasyCrud.Domain.Entities
{
    public class DeveloperSkills : Entity<DeveloperSkills>
    {
        protected DeveloperSkills() { }

        public DeveloperSkills(long id, long developerId, string aditionalInformation, string linkCrud, Knowledge knowledge) : base(id)
        {
            AditionalInformation = aditionalInformation;
            DeveloperId = developerId;
            Knowledge = knowledge;
            LinkCrud = linkCrud;

            Validate();
        }

        public long DeveloperId { get; private set; }
        public string AditionalInformation { get; private set; }
        public string LinkCrud { get; private set; }
        public Knowledge Knowledge { get; private set; }
        public Developer Developer { get; set; }

        public void ApplyKnowledge(Knowledge knowledge)
        {
            Knowledge = knowledge;
        }

        public void ApplyAditionalInformation(string aditionalInformation)
        {
            AditionalInformation = aditionalInformation;
        }

        public void ApplyLinkCrud(string linkCrud)
        {
            LinkCrud = linkCrud;
        }

        public override bool Validate() 
        {
            return true;
        }
    }
}
