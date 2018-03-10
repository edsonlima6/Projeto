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
    public class AlergiaMap : EntityTypeConfiguration<Alergia>
    {
        public AlergiaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAlergia);
            this.Property(t => t.IdAlergia)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Descricao)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Alergia");
            this.Property(t => t.IdAlergia).HasColumnName("IdAlergia");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.TipoAlergia).HasColumnName("TipoAlergia");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
        }
    }
}
