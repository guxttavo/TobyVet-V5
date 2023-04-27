using TobyVet.Web.ViewModels;

namespace TobyVet.Web.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IAnimalRepository _animalRepository;
        private readonly ApplicationDbContext _dbContext;
        public AnimalController(IAnimalRepository animalRepository, ApplicationDbContext dbContext)
        {
            _animalRepository = animalRepository;
            _dbContext = dbContext;
        }
        public async Task<ActionResult> Index() => View();

        [HttpGet("listar")]
        public async Task<IActionResult> Listar() => View("_listar", await _animalRepository.BuscarAnimais());

        [HttpGet("cadastrar")]
        public async Task<IActionResult> Cadastrar()
        {
        var especies = await _animalRepository.BuscarEspecies();
        var viewModel = new EspecieViewModel { Especies = especies };
        Console.WriteLine(viewModel);
        return View("_cadastrar", viewModel);
        }

        // [HttpGet("cadastrar")]
        // public IActionResult Cadastrar() => View(, await _animalRepository.BuscarEspecies());

        [HttpPost("cadastrar")]
        public async Task<IActionResult> CadastrarView(Animal animal)
        {

            await _animalRepository.CadastrarAnimal(animal);
            return RedirectToAction(nameof(Index));
        }

    }
}