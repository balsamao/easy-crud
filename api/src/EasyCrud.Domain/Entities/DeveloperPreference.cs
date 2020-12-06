using EasyCrud.Shared.DomainObjects;

namespace EasyCrud.Domain.Entities
{
    public class DeveloperPreference : Entity<DeveloperPreference>
    {
        protected DeveloperPreference() { }
        public DeveloperPreference(long id, long developerId, Willingness willingness, WorkTime workTime) : base(id)
        {
            DeveloperId = developerId;
            Willingness = willingness;
            WorkTime = workTime;

            Validate();
        }

        public long DeveloperId { get; private set; }

        public Willingness Willingness { get; private set; }

        public WorkTime WorkTime { get; private set; }

        public Developer Developer { get; set; }

        public void ApplyWillingness(Willingness willingness)
        {
            Willingness = willingness;
        }

        public void ApplyWorkTime(WorkTime workTime)
        {
            WorkTime = workTime;
        }

        public override bool Validate() 
        {
            return true;
        }
    }
}
