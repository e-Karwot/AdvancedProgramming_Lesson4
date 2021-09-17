using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chat
{
    public class UsersModel : PageModel
    {
        private readonly Chat.Data.ApplicationDbContext _context;

        public UsersModel(Chat.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<IdentityUser> ChatHubs { get; set; }

        public async Task OnGetAsync()
        {
            ChatHubs = await _context.Users.ToListAsync();
        }



    }
}
