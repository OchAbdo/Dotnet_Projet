using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Projet.Models
{
    public class Rapport
    {
        public long id { set; get; }
        public string continu { set; get; }
        public DateTime datecreation { set; get; }
        public long utilisateurId { get; set; }
        [ValidateNever]
        public Utilisateur utilisateur { set; get; }
        public long projetId { get; set; }
        [ValidateNever]
        public Project projet { get; set; }

    }
}
