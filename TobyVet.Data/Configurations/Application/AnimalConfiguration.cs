namespace TobyVet.Data.Configurations.Application
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("animal", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_Animal");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.Responsavel).HasColumnName("responsavel");
            builder.Property(x => x.Especie).HasColumnName("especie");
            builder.Property(x => x.Genero).HasColumnName("genero");
            builder.Property(x => x.Peso).HasColumnName("peso");
            builder.Property(x => x.Altura).HasColumnName("altura");
            builder.Property(x => x.Cor).HasColumnName("cor");
        }
    }
}