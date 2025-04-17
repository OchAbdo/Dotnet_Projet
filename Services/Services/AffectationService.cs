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

        public void DeleteAffectation(Affectation affectation)
        {
            unitOfWorkC.affectations.Delete(affectation);
            unitOfWorkC.SaveBase();
        }

        public async Task<Affectation> GetAffectationByid(int id)
        {
            return await unitOfWorkC.affectations.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Affectation>> GetAllAffectation()
        {
            return await unitOfWorkC.affectations.GetAllAsync();
        }

        public void UpdateAffectation(Affectation affectation)
        {
            unitOfWorkC.affectations.Update(affectation);
            unitOfWorkC.SaveBase();
        }
    }
}
