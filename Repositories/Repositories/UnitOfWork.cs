using Projet.Models;
using Projet.Repositories.RepositoriesContracts;

namespace Projet.Repositories.Repositories
{
    public class UnitOfWork : UnitOfWorkC
    {
        private readonly ApplicationdbContext _context;

        public GenericRepositoryC<Utilisateur> users { get; private set; }
        public GenericRepositoryC<Project> projets { get; private set; }

        public GenericRepositoryC<Affectation> affectations { get; private set; }

        public GenericRepositoryC<Rapport> rapports { get; private set; }

        public GenericRepositoryC<Tache> taches { get; private set; }

        public UnitOfWork(ApplicationdbContext context)
        {
            _context = context;
            users = new GenericRepository<Utilisateur>(_context);
            projets = new GenericRepository<Project>(_context);
            affectations = new GenericRepository<Affectation>(_context);
            rapports = new GenericRepository<Rapport>(_context);
            taches = new GenericRepository<Tache>(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveBase()
        {
            return _context.SaveChanges();
        }
    }
}
