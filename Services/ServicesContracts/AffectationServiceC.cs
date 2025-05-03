using Projet.Models;
using Projet.Repositories.RepositoriesContracts;

namespace Projet.Services.ServicesContracts
{
    public interface AffectationServiceC
    {
        public Task AddAffectation(Affectation affectation);
        public Task<IEnumerable<Affectation>> GetAllAffectation();
        public Task<Affectation> GetAffectationByid(int id);
        public void UpdateAffectation(Affectation affectation);
        public Task DeleteAffectation(long id);
        public Task<IEnumerable<Affectation>> GetByTacheIdAsync(long tacheId);

        public Task<IEnumerable<Affectation>> GetByTacheIdAsyncUt(long tacheId);
    }
}
