using System.Threading.Tasks;
using Projet.Models;
using Projet.Repositories.RepositoriesContracts;
using Projet.Services.ServicesContracts;

namespace Projet.Services.Services
{
    public class AffectationService : AffectationServiceC
    {
        private readonly UnitOfWorkC unitOfWorkC;

        public AffectationService(UnitOfWorkC unitOfWorkC)
        {
            this.unitOfWorkC = unitOfWorkC;
        }

        public async Task AddAffectation(Affectation affectation)
        {
            await unitOfWorkC.affectations.AddAsync(affectation);
            unitOfWorkC.SaveBase();
        }

        public async Task DeleteAffectation(long id)
        {
            var tac = await unitOfWorkC.affectations.GetByIdAsync(id);
            if (tac != null)
            {
                unitOfWorkC.affectations.Delete(tac);
                unitOfWorkC.SaveBase();
            }
        }

        public async Task<Affectation> GetAffectationByid(int id)
        {
            return await unitOfWorkC.affectations.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Affectation>> GetAllAffectation()
        {
            return await unitOfWorkC.affectations.GetAllAsync();
        }

        public async Task<IEnumerable<Affectation>> GetByTacheIdAsync(long tacheId)
        {
            var allTaches = await unitOfWorkC.affectations.GetAllAsync();
            return allTaches.Where(a => a.tacheId == tacheId);
        }

        public void UpdateAffectation(Affectation affectation)
        {
            unitOfWorkC.affectations.Update(affectation);
            unitOfWorkC.SaveBase();
        }

    }
}
