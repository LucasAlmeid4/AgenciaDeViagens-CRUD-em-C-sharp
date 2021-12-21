using Microsoft.EntityFrameworkCore;

namespace RecodeAirline.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Cliente> cliente { get; set; }



        public DbSet<Contato> contato { get; set; }

    }
}
