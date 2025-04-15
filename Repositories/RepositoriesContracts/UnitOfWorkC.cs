using Projet.Models;

namespace Projet.Repositories.RepositoriesContracts
{
    public interface UnitOfWorkC : IDisposable
    {
        GenericRepositoryC<Utilisateur> users { get; }
        GenericRepositoryC<Project> projets { get; }
        int SaveBase();
        void Dispose();
    }
}
