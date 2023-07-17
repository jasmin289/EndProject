using EndProject.API.Models.DTO.Collections.enums;

namespace EndProject.API.Models.DTO.Collections
{
    public class Language
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public LanguageLevel Level { get; set; }
    }
}
