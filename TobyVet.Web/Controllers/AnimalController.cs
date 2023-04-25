namespace TobyVet.Web.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IAnimalService _animalService;
        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [HttpGet("listar")]
        public async Task<IActionResult> Listar() => View(await _animalService.BuscarAnimaisService());

        [HttpGet("cadastrar")]
        public IActionResult Cadastrar() => View(

        );

        [HttpPost("cadastrar")]
        public async Task Cadastrar(Animal animal) => await _animalService.CadastrarAnimalService(animal);

    }
}