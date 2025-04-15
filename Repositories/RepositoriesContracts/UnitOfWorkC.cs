using Projet.Models;

namespace Projet.Repositories.RepositoriesContracts
{
    public interface UnitOfWorkC : IDisposable
    {
        GenericRepositoryC<Utilisateur> users { get; }
        int SaveBase();
        void Dispose();
    }
}
