using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace ExamenFinalDWES.Models
{
    public class AmazonMontecasteloContext : DbContext
    {
            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Producto> Productos { get; set; }
            public DbSet<Login> Logins { get; set; }
            public DbSet<Compra> Compras { get; set; }

        public AmazonMontecasteloContext(DbContextOptions<AmazonMontecasteloContext> options) : base(options) { }
    }
}
