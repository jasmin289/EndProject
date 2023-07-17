using EndProject.API.Models.DTO.enums;

namespace EndProject.API.Models.DTO
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LanguageLevel Level { get; set; }
    }
}
