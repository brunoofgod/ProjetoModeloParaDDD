using BrunoofgodArch.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrunoofgodArch.Infra.Data.EntityConfig
{
    public class ContatoConfiguration : EntityTypeConfiguration<Contato>
    {
        public ContatoConfiguration()
        {
            HasKey(c => c.ContatoId);

            Property(c => c.NomeDoVendedor)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.NomeDoContato)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Telefone)
                .IsRequired();

            Property(c => c.NomeDaEmpresa)
                .IsOptional()
                .HasMaxLength(150);

            Property(c => c.SobreNomeDoContato)
                .HasMaxLength(150);

            Property(c => c.DataCadastro)
                .IsOptional();
            Property(c => c.DataDeContato)
                .IsOptional();

            Property(c => c.DataDeValidade)
                .IsOptional();
        }
    }
}