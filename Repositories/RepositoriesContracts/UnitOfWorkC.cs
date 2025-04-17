using Projet.Models;

namespace Projet.Repositories.RepositoriesContracts
{
    public interface UnitOfWorkC : IDisposable
    {
        GenericRepositoryC<Utilisateur> users { get; }
        GenericRepositoryC<Project> projets { get; }
        GenericRepositoryC<Affectation> affectations { get; }
        GenericRepositoryC<Rapport> rapports { get; }
        GenericRepositoryC<Tache> taches { get; }
        int SaveBase();
        void Dispose();
    }
}
