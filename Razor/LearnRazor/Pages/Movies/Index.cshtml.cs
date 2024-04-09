using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LearnRazor.Data;
using Razor;

namespace LearnRazor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly LearnRazor.Data.LearnRazorContext _context;

        public IndexModel(LearnRazor.Data.LearnRazorContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
