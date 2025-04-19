using Microsoft.AspNetCore.Mvc;
using Projet.Models;
using Projet.Services.ServicesContracts;

namespace Projet.Controllers
{
    public class TacheController : Controller
    {
        private readonly TacheServiceC _tacheService;

        public TacheController(TacheServiceC tacheService)
        {
            _tacheService = tacheService;
        }

        public async Task<IActionResult> Index(int projetId)
        {
            var taches = await _tacheService.GetByProjetIdAsync(projetId);
            ViewBag.ProjetId = projetId;
            return View(taches);
        }

        public IActionResult Create(int projetId)
        {
            var tache = new Tache { projetId = projetId };
            return View(tache);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tache tache)
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
                return View(tache);
            }
            await _tacheService.AddTache(tache);
            return RedirectToAction("Index", new { projetId = tache.projetId });
        }

        public async Task<IActionResult> Delete(int id, int projetId)
        {
            await _tacheService.DeleteTache(id);
            return RedirectToAction("Index", new { projetId });
        }
    }
}
