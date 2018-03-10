using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.Entities;

namespace TeleHelp.Infraestrutura.Data.Mapping
{
    public class BloqueioServicoMap : EntityTypeConfiguration<BloqueioServico>
    {
        public BloqueioServicoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdBloqueioServico);
            this.Property(t => t.IdBloqueioServico)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Hora)
                .IsRequired()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("BloqueioServico");
            this.Property(t => t.IdBloqueioServico).HasColumnName("IdBloqueioServico");
            this.Property(t => t.Hora).HasColumnName("Hora");
            this.Property(t => t.Domingo).HasColumnName("Domingo");
            this.Property(t => t.Segunda).HasColumnName("Segunda");
            this.Property(t => t.Terca).HasColumnName("Terca");
            this.Property(t => t.Quarta).HasColumnName("Quarta");
            this.Property(t => t.Quinta).HasColumnName("Quinta");
            this.Property(t => t.Sexta).HasColumnName("Sexta");
            this.Property(t => t.Sabado).HasColumnName("Sabado");
            this.Property(t => t.IdServico).HasColumnName("IdServico");

            // Relationships
            this.HasRequired(t => t.Servico)
                .WithMany(t => t.BloqueioServico)
                .HasForeignKey(d => d.IdServico);

        }
    }
}
