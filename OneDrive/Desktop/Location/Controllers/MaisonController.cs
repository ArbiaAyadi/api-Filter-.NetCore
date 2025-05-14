using Location.Models;
using Location.Services;
using Microsoft.AspNetCore.Mvc;

namespace Location.Controllers
{
    [Route("api/[controller]")]

    public class MaisonController : ControllerBase
    {
        private readonly IMaisonService _maisonService;
        public MaisonController(IMaisonService maisonService) => _maisonService = maisonService;

        /* public IActionResult Index(decimal? prixMax, int? surfaceMin)
         {
             var maisons = (prixMax.HasValue || surfaceMin.HasValue)
                 ? _maisonService.FilterMaisons(prixMax, surfaceMin)
                 : _maisonService.GetAllMaisons();

             ViewBag.FilterMessage = $"Résultats trouvés : {maisons.Count()}";
             return View(maisons);
         }*/


        [HttpGet("filtrer")]
        public async Task<IActionResult> FiltrerMaisons([FromQuery] Maison filter)
        {
            var result = await _maisonService.GetFilteredMaisonsAsync(filter);
            return Ok(result);
        }
    }
}
