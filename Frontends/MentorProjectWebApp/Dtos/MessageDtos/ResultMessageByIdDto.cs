

namespace MentorProjectWebApp.Dtos.MessageDtos
{
    public class ResultMessageByIdDto
    {
        public int MessageId { get; set; }
        public string Name {  get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}