namespace EndProject.API.Models.DTO
{
    public class ProgramingSkills
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public DateTime KnownFrom { get; set; }
        public List<Project> Projects { get; set; }

        public List<Education> Education { get; set; }
    
    
    }
}
