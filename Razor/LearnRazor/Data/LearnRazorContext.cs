using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razor;

namespace LearnRazor.Data
{
    public class LearnRazorContext : DbContext
    {
        public LearnRazorContext (DbContextOptions<LearnRazorContext> options)
            : base(options)
        {
        }

        public DbSet<Razor.Movie> Movie { get; set; } = default!;
    }
}
