using TobyVet.Core.Interfaces.Services;

namespace TobyVet.Web.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IAnimalService _animalService;

        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        public async Task<IActionResult> Index() => View(await _animalService.BuscarAnimaisService());


    }
}