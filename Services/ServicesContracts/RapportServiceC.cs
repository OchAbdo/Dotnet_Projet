using Projet.Models;

namespace Projet.Services.ServicesContracts
{
    public interface RapportServiceC
    {
        public Task AddRapport(Rapport rapport);
        public Task<IEnumerable<Rapport>> GetAllRapport();
        public Task<Rapport> GetRapportByid(int id);
        public void UpdateRapport(Rapport rapport);
        public void DeleteRapport(Rapport rapport);
    }
}
