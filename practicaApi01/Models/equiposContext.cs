using Microsoft.EntityFrameworkCore;

namespace practicaApi01.Models
{
    public class equiposContext : DbContext
    {

        public equiposContext(DbContextOptions<equiposContext> options) : base(options)
        {

        }

        public DbSet<equipos> equipos { get; set; }

    }
}
