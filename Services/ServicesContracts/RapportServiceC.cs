using Projet.Models;
using Projet.Repositories.RepositoriesContracts;

namespace Projet.Services.ServicesContracts
{
    public interface RapportServiceC
    {
        public Task AddRapport(Rapport rapport);
        public Task<IEnumerable<Rapport>> GetAllRapport();
        public Task<Rapport> GetRapportByid(int id);
        public void UpdateRapport(Rapport rapport);
        public Task DeleteRapportAsync(long id);
        public Task<IEnumerable<Rapport>> GetByProjetIdAsync(long projetId);
    }
}
