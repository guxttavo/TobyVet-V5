using TobyVet.Core.Models;

namespace TobyVet.Core.Interfaces.Repositories
{
    public interface IAnimalRepository
    {
        Task<IEnumerable<Animal>> BuscarAnimais();

    }
}