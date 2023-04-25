namespace TobyVet.Core.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;
        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }
        public async Task<IEnumerable<Animal>> BuscarAnimaisService() => await _animalRepository.BuscarAnimais();
        public async Task CadastrarAnimalService(Animal animal) => await _animalRepository.CadastrarAnimal(animal);

    }
}