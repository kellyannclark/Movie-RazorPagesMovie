using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models; // Adjust the namespace if your 'Movie' model is in a different namespace

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}

