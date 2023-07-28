using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp.net_core___crud.Data;
using asp.net_core___crud.Model;

namespace asp.net_core___crud.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly asp.net_core___crud.Data.aspnet_core___crudContext _context;

        public IndexModel(asp.net_core___crud.Data.aspnet_core___crudContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
