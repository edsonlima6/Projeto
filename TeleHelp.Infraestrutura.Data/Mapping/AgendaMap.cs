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
    public class AgendaMap : EntityTypeConfiguration<Agenda>
    {
        public AgendaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAgenda);
            this.Property(t => t.IdAgenda)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Descricao)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Agenda");
            this.Property(t => t.IdAgenda).HasColumnName("IdAgenda");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.TipoAgenda).HasColumnName("TipoAgenda");
            this.Property(t => t.Periodo).HasColumnName("Periodo");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
        }
    }
}
