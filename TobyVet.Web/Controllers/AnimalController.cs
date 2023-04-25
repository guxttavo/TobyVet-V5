namespace TobyVet.Web.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IAnimalService _animalService;
        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }
        public async Task<IActionResult> Listar() => View(await _animalService.BuscarAnimaisService());

        public IActionResult Cadastrar() => View();


    }
}