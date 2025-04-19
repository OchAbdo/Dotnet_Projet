using Projet.Models;
using Projet.Repositories.Repositories;
using Projet.Repositories.RepositoriesContracts;
using Projet.Services.ServicesContracts;

namespace Projet.Services.Services
{
    public class TacheService : TacheServiceC
    {
        private UnitOfWorkC unitOfWorkC;
        public TacheService(UnitOfWorkC unitOfWorkC)
        {
            this.unitOfWorkC = unitOfWorkC;
        }

        public async Task AddTache(Tache tache)
        {
            await unitOfWorkC.taches.AddAsync(tache);
            unitOfWorkC.SaveBase();
        }

        public async Task DeleteTache(long id)
        {
            var tac = await unitOfWorkC.taches.GetByIdAsync(id);
            if (tac != null)
            {
                unitOfWorkC.taches.Delete(tac);
                unitOfWorkC.SaveBase();
            }
        }

        public async Task<IEnumerable<Tache>> GetAllTache()
        {
            return await unitOfWorkC.taches.GetAllAsync();
        }

        public async Task<Tache> GetTacheByid(int id)
        {
            return await unitOfWorkC.taches.GetByIdAsync(id);
        }

        public void UpdateTache(Tache tache)
        {
            unitOfWorkC.taches.Update(tache);
            unitOfWorkC.SaveBase();
        }

        public async Task<IEnumerable<Tache>> GetByProjetIdAsync(int projetId)
        {
            var allTaches = await unitOfWorkC.taches.GetAllAsync();
            return allTaches.Where(t => t.projetId == projetId);
        }
    }
}
