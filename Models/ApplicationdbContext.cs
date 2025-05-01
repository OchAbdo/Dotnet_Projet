using Microsoft.EntityFrameworkCore;

namespace Projet.Models
{
    public class ApplicationdbContext : DbContext
    {
        public ApplicationdbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Utilisateur> utilisateurs { get; set; }
        public DbSet<Project>projet { get; set;}
        public DbSet<Affectation> affectations { get; set; }
        public DbSet<Rapport> rapports { get; set; }
        public DbSet<Tache> taches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasMany(p => p.taches)
                .WithOne(t => t.projet)
                .HasForeignKey(t => t.projetId);

            modelBuilder.Entity<Tache>()
                .HasMany(t => t.affectations)
                .WithOne(a => a.tache)
                .HasForeignKey(a => a.tacheId);
        }
    }


}
