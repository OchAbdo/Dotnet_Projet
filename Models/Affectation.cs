using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Projet.Models
{
    public class Affectation
    {
        public long id { set; get; }
        [Required(ErrorMessage = "La date d'affectation est requis.")]
        public DateTime dateaffectation { set; get; }
        public long tacheId { set; get; }
        [ValidateNever]
        public Tache tache { set; get; }
    }
}
