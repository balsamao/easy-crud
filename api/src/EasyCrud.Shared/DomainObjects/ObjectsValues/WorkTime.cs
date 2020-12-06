using EasyCrud.Shared.DomainObjects.ObjectsValues;

namespace EasyCrud.Shared.DomainObjects
{
    public class WorkTime : ObjectValue
    {
        protected WorkTime() { }
        public WorkTime(bool morning, bool afternoon, bool night, bool dawn, bool business)
        {
            Morning = morning;
            Afternoon = afternoon;
            Night = night;
            Dawn = dawn;
            Business = business;

            Validate();
        }

        public bool Morning { get; private set; }
        public bool Afternoon { get; private set; }
        public bool Night { get; private set; }
        public bool Dawn { get; private set; }
        public bool Business { get; private set; }

        public override void Validate() { }
    }
}
