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
    public class CidadeMap : EntityTypeConfiguration<Cidade>
    {
        public CidadeMap()
        {
            // Primary Key
            this.HasKey(t => t.IdCidade);
            this.Property(t => t.IdCidade)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Sigla)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.DDD)
                .IsRequired()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("Cidade");
            this.Property(t => t.IdCidade).HasColumnName("IdCidade");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Sigla).HasColumnName("Sigla");
            this.Property(t => t.DDD).HasColumnName("DDD");
            this.Property(t => t.RT).HasColumnName("RT");
            this.Property(t => t.IdEstado).HasColumnName("IdEstado");

            // Relationships
            //this.HasRequired(t => t.Estado)
            //    .WithMany(t => t.Cidade)
            //    .HasForeignKey(d => d.IdEstado);

        }
    }
}
