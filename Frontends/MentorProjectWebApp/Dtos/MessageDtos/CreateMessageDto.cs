

namespace MentorProjectWebApp.Dtos.MessageDtos
{
    public class CreateMessageDto
    {
        public int Name {  get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}