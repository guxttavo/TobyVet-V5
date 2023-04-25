namespace TobyVet.Data.Configurations.Application
{
    public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("animal", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_Genero");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");
        }
    }
}