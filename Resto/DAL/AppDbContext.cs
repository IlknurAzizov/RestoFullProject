using Microsoft.EntityFrameworkCore;
using Resto.Models;

namespace Resto.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {

        }
        public DbSet<SpecialtiesMenu> SpecialtiesMenu { get; set; }
    }
}
