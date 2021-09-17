using Chat.Data;
using Chat.Models;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Chat.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _context;

        public ChatHub(ApplicationDbContext context)
        {
            ChatMessage message = new ChatMessage();
            _context = context;
        }

        public async Task SendMessage(string user, string message, string registered)
        {
            var chatMessage = new ChatMessage(user, message, registered);
            _context.Add(chatMessage);
            await _context.SaveChangesAsync();
            await Clients.All.SendAsync("ReceiveMessage", user, message, registered);
        }
    }
}
