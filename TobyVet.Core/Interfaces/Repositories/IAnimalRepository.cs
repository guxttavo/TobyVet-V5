namespace TobyVet.Core.Interfaces.Repositories
{
    public interface IAnimalRepository
    {
        Task<IEnumerable<Animal>> BuscarAnimais();
        Task CadastrarAnimal(Animal animal);
        Task EditarAnimal(Animal animal);
        Task<IEnumerable<Especie>> BuscarEspecies();
        Task<Animal> BuscarAnimal(int id);
        Task ExcluirAnimal(int id);

    }
}