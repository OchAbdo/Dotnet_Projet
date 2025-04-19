using Projet.Models;

namespace Projet.Services.ServicesContracts
{
    public interface TacheServiceC
    {
        public Task AddTache(Tache tache);
        public Task<IEnumerable<Tache>> GetAllTache();
        public Task<Tache> GetTacheByid(int id);
        public void UpdateTache(Tache tache);
        public Task DeleteTache(long id);
        public Task<IEnumerable<Tache>> GetByProjetIdAsync(int projetId);
    }
}
