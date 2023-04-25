namespace TobyVet.Core.Models
{
    public class Especie
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Animal> Animais { get; set; }
    }
}