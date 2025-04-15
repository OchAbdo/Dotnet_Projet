using Projet.Models;
using Projet.Repositories.RepositoriesContracts;
using Projet.Services.ServicesContracts;

namespace Projet.Services.Services
{
    public class ProjetService : ProjetServiceC
    {
        private readonly UnitOfWorkC unitOfWorkC;
        
        public ProjetService (UnitOfWorkC unitOfWorkC) 
        {
            this.unitOfWorkC = unitOfWorkC;
        }

        public async Task AddProject(Project projet)
        {
            await unitOfWorkC.projets.AddAsync(projet);
            unitOfWorkC.SaveBase();
        }

        public void DeleteProjet(Project projet)
        {
            unitOfWorkC.projets.Delete(projet);
            unitOfWorkC.SaveBase();
        }

        public async Task<IEnumerable<Project>> GetAllProjet()
        {
            var p = await unitOfWorkC.projets.GetAllAsync();
            return p;

        }

        public async Task<Project> GetProjetByid(int id)
        {
            var p = await unitOfWorkC.projets.GetByIdAsync(id);
            return p;
        }

        public void UpdateProjet(Project projet)
        {
            unitOfWorkC.projets.Update(projet);
            unitOfWorkC.SaveBase();
        }
    }
}
