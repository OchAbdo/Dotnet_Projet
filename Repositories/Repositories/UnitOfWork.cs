using Projet.Models;
using Projet.Repositories.RepositoriesContracts;

namespace Projet.Repositories.Repositories
{
    public class UnitOfWork : UnitOfWorkC
    {
        private readonly ApplicationdbContext _context;

        public GenericRepositoryC<Utilisateur> users { get; private set; }

        public UnitOfWork(ApplicationdbContext context)
        {
            _context = context;
            users = new GenericRepository<Utilisateur>(_context);
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
