using EndProject.API.Models.DTO.Collections.enums;

namespace EndProject.API.Models.DTO.Collections
{
    public class Communication
    {
        public int ID { get; set; }
        public string From { get; set; }
        public string Title { get; set; }

        public string Message { get; set; }

        public string Email { get; set; }
        public string PhonNumber { get; set; }

        public DateTime Created { get; set; }

        public CommunicationType Type { get; set; }
        
        public CommunicationStatus stsus { get; set; }

    }
}
