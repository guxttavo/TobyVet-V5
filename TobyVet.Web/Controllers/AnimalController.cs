namespace TobyVet.Web.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IAnimalRepository _animalRepository;
        public AnimalController(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        [HttpGet("listar")]
        public async Task<IActionResult> Listar() => View(await _animalRepository.BuscarAnimais());

        [HttpGet("cadastrar")]
        public IActionResult Cadastrar() => View(

        );

        [HttpPost("cadastrar")]
        public async Task Cadastrar(Animal animal) => await _animalRepository.CadastrarAnimal(animal);

    }
}