using TobyVet.Core.Settings;

namespace TobyVet.Data
{
    public class ApplicationDbContext : BaseDbContext
    {
        public ApplicationDbContext(AppSettings appSettings) : base(appSettings, "Application")
        {
        }
    }
}