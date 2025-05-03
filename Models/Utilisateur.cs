using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Projet.Models
{
    public class Utilisateur
    {
        public long id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string departement { get; set; }
        public string role { get; set; }
        [ValidateNever]
        public ICollection<Affectation> affectations { get; set; }
        [ValidateNever]
        public ICollection<Rapport> rapports { get; set; }

    }
}
