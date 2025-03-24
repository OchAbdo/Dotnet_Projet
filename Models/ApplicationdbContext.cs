using Microsoft.EntityFrameworkCore;

namespace Projet.Models
{
    public class ApplicationdbContext : DbContext
    {
        public ApplicationdbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Utilisateur> utilisateurs { get; set; }
    }
}
