using Projet.Models;

namespace Projet.Services.ServicesContracts
{
    public interface AffectationServiceC
    {
        public Task AddAffectation(Affectation affectation);
        public Task<IEnumerable<Affectation>> GetAllAffectation();
        public Task<Affectation> GetAffectationByid(int id);
        public void UpdateAffectation(Affectation affectation);
        public void DeleteAffectation(Affectation affectation);
    }
}
