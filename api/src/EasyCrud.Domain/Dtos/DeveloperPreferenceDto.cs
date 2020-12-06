namespace EasyCrud.Domain.Dtos
{
    public class DeveloperPreferenceDto
    {
        public long Id { get; set; }
        public long DeveloperId { get; set; }
        public bool UpToFourHoursPerDay { get; set; }
        public bool FourToSixHoursPerDay { get; set; }
        public bool SixtoEightHoursPerDay { get; set; }
        public bool UpToEightHoursADay { get; set; }
        public bool OnlyWeekends { get; set; }
        public bool Morning { get; set; }
        public bool Afternoon { get; set; }
        public bool Night { get; set; }
        public bool Dawn { get; set; }
        public bool Business { get; set; }
    }
}
