using TobyVet.Web.ViewModels;

namespace TobyVet.Web.Controllers
{
    [Route("animal")]
    public class AnimalController : Controller
    {
        private readonly IAnimalRepository _animalRepository;
        public AnimalController(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }
        public ActionResult Index() => View();

        [HttpGet("listar")]
        public async Task<IActionResult> Listar() => View("_listar", await _animalRepository.BuscarAnimais());

        [HttpGet("editar")]
        public async Task<IActionResult> Editar(int id)
        {
            Console.WriteLine(id);
            var animalSelecionado = await _animalRepository.BuscarAnimal(id);
            Console.WriteLine(animalSelecionado.Nome);

            return View("_editar", animalSelecionado);
        }

        [HttpGet("cadastrar")]
        public async Task<IActionResult> Cadastrar()
        {
            var especies = await _animalRepository.BuscarEspecies();
            var viewModel = new EspecieViewModel { Especies = especies };
            Console.WriteLine(viewModel);
            return View("_cadastrar", viewModel);
        }

        [HttpPost("cadastrar")]
        public async Task<IActionResult> Cadastrar(Animal animal)
        {
            await _animalRepository.CadastrarAnimal(animal);
            return RedirectToAction(nameof(Index));
        }

    }
}