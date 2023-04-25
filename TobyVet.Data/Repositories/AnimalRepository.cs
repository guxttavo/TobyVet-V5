namespace TobyVet.Data.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public AnimalRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Animal>> BuscarAnimais() => await _dbContext.Animais.ToListAsync();
    }
}