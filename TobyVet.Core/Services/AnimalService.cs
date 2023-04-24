using TobyVet.Core.Interfaces.Repositories;
using TobyVet.Core.Interfaces.Services;
using TobyVet.Core.Models;

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


    }
}