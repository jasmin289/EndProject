namespace EndProject.API.Models.DTO.Collections
{
    public class Project
    {
        public int ID  { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ProjectGallry> GalleryImages { get; set; }
        public string URL { get; set; }
        public string GitURL { get; set; }
       
        public List<ProgramingSkills> SkillsUsed { get; set; }

    }
    public class ProjectGallry
    {
        public int ID { get; set; }
        public string URL { get; set; }
        public string Alt { get; set; }

        public string Titel { get; set; }
        public string Description { get; set; }

    }
}
 