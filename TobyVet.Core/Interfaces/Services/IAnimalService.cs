using TobyVet.Core.Models;

namespace TobyVet.Core.Interfaces.Services
{
    public interface IAnimalService
    {
        Task<IEnumerable<Animal>> BuscarAnimaisService();
    }
}