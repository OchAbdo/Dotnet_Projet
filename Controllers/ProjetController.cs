using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet.Models;
using Projet.Services.Services;
using Projet.Services.ServicesContracts;

namespace Projet.Controllers
{
    public class ProjetController : Controller
    {
        private readonly ProjetServiceC _projetService;

        public ProjetController(ProjetServiceC projetService)
        {
            _projetService = projetService;
        }

        public async Task<IActionResult> Index()
        {
            var projets = await _projetService.GetAllProjet();
            return View(projets);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Project projet)
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
                return View(projet);
            }

            await _projetService.AddProject(projet);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(long id)
        {
            await _projetService.DeleteProjetAsync(id);
            return RedirectToAction("Index");
        }
    }
}
