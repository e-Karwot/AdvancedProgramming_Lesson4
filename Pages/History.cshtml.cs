using Chat.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chat
{
    public class HistoryModel : PageModel
    {
        private readonly Chat.Data.ApplicationDbContext _context;

        public HistoryModel(Chat.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ChatMessage> ChatHubs { get; set; }
        public async Task OnGetAsync()
        {
            ChatHubs = await _context.ChatMessages.ToListAsync();
        }
    }
}
