namespace TobyVet.Data.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public AnimalRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Animal>> BuscarAnimais()
        {
            return await _dbContext.Animais
                .Include(x => x.Especie)
                .ToListAsync();
        }
        public async Task<Animal> BuscarAnimal(int id)
        {
            return await _dbContext.Animais
                .Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        public async Task CadastrarAnimal(Animal animal)
        {
            await _dbContext.Animais.AddAsync(animal);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<Especie>> BuscarEspecies()
        {
            return await _dbContext.Especies
                .OrderBy(x => x.Nome)
                .ToListAsync();
        }
    }
}