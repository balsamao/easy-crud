using EasyCrud.Shared.DomainObjects.ObjectsValues;

namespace EasyCrud.Shared.DomainObjects
{
    public class Willingness : ObjectValue
    {
        protected Willingness() { }
        public Willingness(bool upToFourHoursPerDay, bool fourToSixHoursPerDay, bool sixToEightHoursPerDay, bool upToEightHoursADay, bool onlyWeekends)
        {
            UpToFourHoursPerDay = upToFourHoursPerDay;
            FourToSixHoursPerDay = fourToSixHoursPerDay;
            SixtoEightHoursPerDay = sixToEightHoursPerDay;
            UpToEightHoursADay = upToEightHoursADay;
            OnlyWeekends = onlyWeekends;

            Validate();
        }

        public bool UpToFourHoursPerDay { get; private set; }
        public bool FourToSixHoursPerDay { get; private set; }
        public bool SixtoEightHoursPerDay { get; private set; }
        public bool UpToEightHoursADay { get; private set; }
        public bool OnlyWeekends { get; private set; }

        public override void Validate() { }
    }
}
