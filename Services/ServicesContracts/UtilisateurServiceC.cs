using Projet.Models;

namespace Projet.Services.ServicesContracts
{
    public interface UtilisateurServiceC
    {
        public Task<IEnumerable<Utilisateur>> allUtilisateurs();
        public Task AddUtilisateur(Utilisateur utilisateur);
    }
}
