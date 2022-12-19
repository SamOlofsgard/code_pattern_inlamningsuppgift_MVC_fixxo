using Microsoft.EntityFrameworkCore;
using MVC_fixxo.Models.Entities;

namespace MVC_fixxo.Context

/// Liskov substitution principle (LSP) Objekt av en klass ska kunna ersättas med objekt av subklasser utan att programmets funktion ändras.
/// exemplet är DbContext är arvet och att man vet att det är korrekt och inte påverkar funktionen negativt.
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
