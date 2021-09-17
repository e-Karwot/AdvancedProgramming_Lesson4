namespace Chat.Models
{
    public class ChatMessage
    {
        public ChatMessage()
        {
        }

        public ChatMessage(string user, string message, string registered)
        {
            User = user;
            Message = message;
            Registered = registered;
        }

        public int Id { get; set; }

        public string Registered { get; set; }
        public string User { get; set; }

        public string Message { get; set; }
    }
}
