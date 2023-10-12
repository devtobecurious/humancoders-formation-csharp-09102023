using Microsoft.EntityFrameworkCore;

namespace DiscoverEFCore
{
    internal class DefaultContext : DbContext
    {
        protected DefaultContext()
        {
        }

        public DefaultContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // C'est ici qu'on changera les regles par defaut
        }

        public DbSet<Elfe> Elfes { get; set; } // Le nom de la propriété, par defaut, est le nom de la table, ici il attend "Elfes" en base de données
    }
}
