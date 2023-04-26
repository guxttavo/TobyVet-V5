namespace TobyVet.Web.ViewModels
{
    public class EspecieViewModel
    {
        public Animal Animal { get; set; }
        public IEnumerable<Especie> Especies { get; set; }
    }
}