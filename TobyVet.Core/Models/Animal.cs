namespace TobyVet.Core.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public int IdEspecie { get; set; }
        public string Nome { get; set; }
        public string Responsavel { get; set; }
        public string Sexo { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Cor { get; set; }
        public Especie Especie { get; set; }
    }
}