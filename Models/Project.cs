using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Projet.Models
{
    public class Project
    {
        public long id { set; get; }
        [Required(ErrorMessage = "Le titre est requis.")]
        public string titre { set; get; }
        [Required(ErrorMessage = "La description est requis.")]
        public string description { set; get; }
        [Required(ErrorMessage = "La date debut est requis.")]
        public DateTime datedebut { set; get; }
        [Required(ErrorMessage = "La date fin requis.")]
        public DateTime datefin { set; get; }
        [Required(ErrorMessage = "Le status est requis.")]
        public string status { set; get; }
        [ValidateNever]
        public ICollection<Tache> taches { set; get; }
        [ValidateNever]
        public ICollection<Rapport> rapports { set; get; }

    }
}
