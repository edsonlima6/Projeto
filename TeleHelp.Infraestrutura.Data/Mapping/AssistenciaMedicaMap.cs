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
    class AssistenciaMedicaMap : EntityTypeConfiguration<AssistenciaMedica>
    {
        public AssistenciaMedicaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAssistenciaMedica);
            this.Property(t => t.IdAssistenciaMedica)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("AssistenciaMedica");
            this.Property(t => t.IdAssistenciaMedica).HasColumnName("IdAssistenciaMedica");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
        }
    }
}
