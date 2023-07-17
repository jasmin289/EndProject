namespace EndProject.API.Models.DTO
{
    public class Education
    {
        public int ID { get; set; }
        public DateTime Started { get; set; }

        public DateTime? Ended { get; set; }
        public string Description { get; set; }
        public List<ProgramingSkills> Skills { get; set; }
    }
}
