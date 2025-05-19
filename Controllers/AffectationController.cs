using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projet.Models;
using Projet.Services.Services;
using Projet.Services.ServicesContracts;

namespace Projet.Controllers
{
    [Authorize]
    public class AffectationController : Controller
    {
        private readonly AffectationServiceC _affectationServiceC;
        private readonly TacheServiceC _tacheServiceC;
        private readonly UtilisateurServiceC _utilisateurServiceC;

        public AffectationController(AffectationServiceC affectationServiceC, TacheServiceC tacheServiceC, UtilisateurServiceC utilisateurServiceC)
        {
            this._affectationServiceC = affectationServiceC;
            _tacheServiceC = tacheServiceC;
            _utilisateurServiceC = utilisateurServiceC;
        }

        public async Task<IActionResult> Index(long tacheId)
        {
            var list = await _affectationServiceC.GetByTacheIdAsyncUt(tacheId);
            Tache t = await _tacheServiceC.GetTacheByid(tacheId);
            ViewBag.TacheId = tacheId;
            ViewBag.ProjetId = t.projetId;
            return View(list);
        }

        public async Task<IActionResult> Create(int tacheId)
        {
            var affectation = new Affectation { tacheId = tacheId };
            var utilisateurs = await _utilisateurServiceC.allUtilisateurs();
            ViewBag.listutilisateur = utilisateurs;
            return View(affectation);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Affectation affectation)
        {
            if (!ModelState.IsValid)
            {
                foreach (var state in ModelState)
                {
                    foreach (var error in state.Value.Errors)
                    {
                        Console.WriteLine($"Champ: {state.Key}, Erreur: {error.ErrorMessage}");
                    }
                }
                return View(affectation);
            }
            await _affectationServiceC.AddAffectation(affectation);
            return RedirectToAction("Index", new { tacheId = affectation.tacheId });
        }

        public async Task<IActionResult> Delete(int id, int tacheId)
        {
            await _affectationServiceC.DeleteAffectation(id);
            return RedirectToAction("Index", new { tacheId });
        }


    }
}
