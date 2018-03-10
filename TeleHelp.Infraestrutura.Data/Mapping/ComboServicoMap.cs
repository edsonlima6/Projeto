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
    public class ComboServicoMap : EntityTypeConfiguration<ComboServico>
    {
        public ComboServicoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdComboServico);
            this.Property(t => t.IdComboServico)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            

            // Table & Column Mappings
            this.ToTable("ComboServico");
            this.Property(t => t.IdComboServico).HasColumnName("IdComboServico");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.ValorDesconto).HasColumnName("ValorDesconto");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
            this.Property(t => t.IdCombo).HasColumnName("IdCombo");
            this.Property(t => t.IdServico).HasColumnName("IdServico");

            //Relationships
            this.HasRequired(t => t.Combo)
                .WithMany(t => t.ComboServico)
                .HasForeignKey(d => d.IdCombo);

            this.HasRequired(t => t.Servico)
                .WithMany(t => t.ComboServico)
                .HasForeignKey(d => d.IdServico);

        }
    }
}
