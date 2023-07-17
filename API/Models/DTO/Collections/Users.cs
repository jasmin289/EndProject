using EndProject.API.Models.DTO.Collections.enums;

namespace EndProject.API.Models.DTO.Collections
{
    public class Users
    {
        public int ID  { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }    
        public UserType Type { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
