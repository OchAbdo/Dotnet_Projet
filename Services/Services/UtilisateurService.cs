using Projet.Models;
using Projet.Repositories.RepositoriesContracts;
using Projet.Services.ServicesContracts;

namespace Projet.Services.Services
{
    public class UtilisateurService : UtilisateurServiceC
    {
        private readonly UnitOfWorkC unitOfWorkC;

        public UtilisateurService (UnitOfWorkC unitOfWorkC)
        {
            this.unitOfWorkC = unitOfWorkC;
        }

        public async Task AddUtilisateur(Utilisateur utilisateur)
        {
            await unitOfWorkC.users.AddAsync(utilisateur);
            unitOfWorkC.SaveBase();
        }

        public async Task<IEnumerable<Utilisateur>> allUtilisateurs()
        {
            return await unitOfWorkC.users.GetAllAsync();
        }
    }
}
