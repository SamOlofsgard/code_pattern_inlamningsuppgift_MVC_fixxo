using Microsoft.EntityFrameworkCore;
using MVC_fixxo.Models.Entities;

namespace MVC_fixxo.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
