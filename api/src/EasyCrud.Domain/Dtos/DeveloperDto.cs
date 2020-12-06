namespace EasyCrud.Domain.Dtos
{
    public class DeveloperDto
    {
        public DeveloperDto() 
        {
            Preference = new DeveloperPreferenceDto();
            Skills = new DeveloperSkillsDto();
        }

        public long Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Portfolio { get; set; }
        public decimal HourlySalary { get; set; }
        public string Phone { get; set; }
        public string Linkedin { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DeveloperPreferenceDto Preference { get; set; }
        public DeveloperSkillsDto Skills { get; set; }
    }
}
