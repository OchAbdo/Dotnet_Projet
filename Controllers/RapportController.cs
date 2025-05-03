using Microsoft.AspNetCore.Mvc;
using Projet.Services.Services;
using Projet.Services.ServicesContracts;

namespace Projet.Controllers
{
    public class RapportController : Controller
    {

        private readonly RapportServiceC _rapportServiceC;
        public RapportController(RapportServiceC rapportServiceC)
        {
            _rapportServiceC = rapportServiceC;
        }

        public async Task<IActionResult> Index(long projetId)
        {
            var rapports = await _rapportServiceC.GetByProjetIdAsync(projetId);
            return View(rapports);
        }

        public async Task<IActionResult> Delete(long id, long projetId)
        {
            await _rapportServiceC.DeleteRapportAsync(id);
            return RedirectToAction("Index", new { projetId });
        }



    }
}
