namespace TobyVet.Data
{
    public class ApplicationDbContext : BaseDbContext
    {
        public ApplicationDbContext(AppSettings appSettings) : base(appSettings, "Application")
        {
        }
        public DbSet<Animal> Animais { get; set; }
    }
}