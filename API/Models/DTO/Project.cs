namespace EndProject.API.Models.DTO
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ProjectGallry> GalleryImages { get; set; }
        public string URL { get; set; }
        public string GitURL { get; set; }

        public List<ProgramingSkills> Skills { get; set; }

    }
  
}
