using App_Practica.Models;
using Microsoft.EntityFrameworkCore;

namespace App_Practica.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
    }
}
