namespace TobyVet.Data.Configurations.Application
{
    public class EspecieConfiguration : IEntityTypeConfiguration<Especie>
    {
        public void Configure(EntityTypeBuilder<Especie> builder)
        {
            builder.ToTable("especie", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_especie");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");

            builder.HasMany(x => x.Animais).WithOne(x => x.Especie);
        }
    }
}