using Microsoft.EntityFrameworkCore;
using ITSY.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ITSY.Data
{
    public class ITSYContext : IdentityDbContext
    {
        public ITSYContext (DbContextOptions<ITSYContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Ticket { get; set; }
    }
}