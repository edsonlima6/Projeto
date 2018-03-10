using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TeleHelp.Domain.Entities;

namespace TeleHelp.Infraestrutura.Data.Mapping
{
    public class AuditoriaMap : EntityTypeConfiguration<Auditoria>
    {
        public AuditoriaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAuditoria);
            this.Property(t => t.IdAuditoria)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.DescriacaoAnterior)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.DescriacaoAtual)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Auditoria");
            this.Property(t => t.IdAuditoria).HasColumnName("IdAuditoria");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            this.Property(t => t.DescriacaoAnterior).HasColumnName("DescriacaoAnterior");
            this.Property(t => t.DescriacaoAtual).HasColumnName("DescriacaoAtual");
            this.Property(t => t.IdUsuarioCriacao).HasColumnName("IdUsuarioCriacao");
            this.Property(t => t.IdUsuarioAlteracao).HasColumnName("IdUsuarioAlteracao");
            this.Property(t => t.IdModuloMenuItem).HasColumnName("IdModuloMenuItem");

            // Relationships
            //this.HasRequired(t => t.UsuarioCriacao)
            //    .WithMany(t => t.Auditoria)
            //    .HasForeignKey(d => d.IdUsuarioCriacao);

            //this.HasRequired(t => t.UsuarioAlteracao)
            //    .WithMany(t => t.Auditoria1)
            //    .HasForeignKey(d => d.IdUsuarioAlteracao);

        }
    }
}
