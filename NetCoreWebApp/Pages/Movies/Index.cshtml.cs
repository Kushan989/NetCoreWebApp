using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetCoreWebApp.Models;

namespace NetCoreWebApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly NetCoreWebApp.Models.NetCoreWebAppContext _context;

        public IndexModel(NetCoreWebApp.Models.NetCoreWebAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
