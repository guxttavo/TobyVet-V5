using TobyVet.Web.ViewModels;

namespace TobyVet.Web.Controllers
{
    [Route("animal")]
    public class AnimalController : Controller
    {
        private readonly IAnimalRepository _animalRepository;
        public AnimalController(IAnimalRepository animalRepository, ApplicationDbContext dbContext)
        {
            _animalRepository = animalRepository;
        }
        public ActionResult Index() => View();

        [HttpGet("listar")]
        public async Task<IActionResult> Lista() => View("_listar", await _animalRepository.BuscarAnimais());

        [HttpGet("cadastrar")]
        public async Task<IActionResult> Azul()
        {
            var especies = await _animalRepository.BuscarEspecies();
            var viewModel = new EspecieViewModel { Especies = especies };
            Console.WriteLine(viewModel);
            return View("_cadastrar", viewModel);
        }

        // [HttpGet("cadastrar")]
        // public IActionResult Cadastrar() => View(, await _animalRepository.BuscarEspecies());

        [HttpPost("cadastrar")]
        public async Task<IActionResult> Beto(Animal animal)
        {
            await _animalRepository.CadastrarAnimal(animal);
            return RedirectToAction(nameof(Index));
        }

    }
}