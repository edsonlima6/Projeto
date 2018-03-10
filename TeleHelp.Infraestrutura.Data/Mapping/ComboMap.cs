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
    public class ComboMap : EntityTypeConfiguration<Combo>
    {
        public ComboMap()
        {
            // Primary Key
            this.HasKey(t => t.IdCombo);
            this.Property(t => t.IdCombo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Descricao)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Combo");
            this.Property(t => t.IdCombo).HasColumnName("IdCombo");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
        }
    }
}
