namespace razorapp1.Data
{
    public class RazorPagesMovieContext : DbContext
    {
         public RazorPagesMovieContext (
            DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<razorapp1.Models.Movie> Movie { get; set; }
    }
}