using Projet.Models;
using Projet.Repositories.RepositoriesContracts;
using Projet.Services.ServicesContracts;

namespace Projet.Services.Services
{
    public class RapportService : RapportServiceC
    {
        private readonly UnitOfWorkC unitOfWorkC;
        public RapportService(UnitOfWorkC unitOfWorkC)
        {
            this.unitOfWorkC = unitOfWorkC;
        }

        public async Task AddRapport(Rapport rapport)
        {
            await unitOfWorkC.rapports.AddAsync(rapport);
            unitOfWorkC.SaveBase();
        }

        public void DeleteRapport(Rapport rapport)
        {
            unitOfWorkC.rapports.Delete(rapport);
            unitOfWorkC.SaveBase();
        }

        public async Task<IEnumerable<Rapport>> GetAllRapport()
        {
            return await unitOfWorkC.rapports.GetAllAsync();
        }

        public async Task<Rapport> GetRapportByid(int id)
        {
            return await unitOfWorkC.rapports.GetByIdAsync(id);
        }

        public void UpdateRapport(Rapport rapport)
        {
            unitOfWorkC.rapports.Update(rapport);
            unitOfWorkC.SaveBase();
        }
    }
}
