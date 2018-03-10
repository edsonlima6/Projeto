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
    public class CepMap : EntityTypeConfiguration<Cep>
    {
        public CepMap()
        {
            // Primary Key
            this.HasKey(t => t.IdCep);
            this.Property(t => t.IdCep)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Bairro)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Inicial)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Final)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Cep");
            this.Property(t => t.IdCep).HasColumnName("IdCepAtendido");
            this.Property(t => t.Bairro).HasColumnName("Bairro");
            this.Property(t => t.Inicial).HasColumnName("Inicial");
            this.Property(t => t.Final).HasColumnName("Final");
            this.Property(t => t.IdCidade).HasColumnName("IdCidade");

            // Relationships
            //this.HasRequired(t => t.Cidade)
            //    .WithMany(t => t.Cep)
            //    .HasForeignKey(d => d.IdCidade);

        }
    }
}
