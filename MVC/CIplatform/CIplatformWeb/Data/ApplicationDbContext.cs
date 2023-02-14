using CIplatformWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CIplatformWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        //hereeee
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<user> user { get; set; }
    }
}

