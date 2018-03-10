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
    public class AcaoMap : EntityTypeConfiguration<Acao>
    {
        public AcaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAcao);
            this.Property(t => t.IdAcao)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.NomeAcao)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("Acao");
            this.Property(t => t.IdAcao).HasColumnName("IdAcao");
            this.Property(t => t.NomeAcao).HasColumnName("NomeAcao");
            this.Property(t => t.TipoAcao).HasColumnName("TipoAcao");
            this.Property(t => t.Produtiva).HasColumnName("Produtiva");
            this.Property(t => t.IdAgenda).HasColumnName("IdAgenda");
            ;

            // Relationships
            //this.HasOptional(t => t.Agenda)
            //    .WithMany(t => t.Acao)
            //    .HasForeignKey(d => d.IdAgenda);
        }


    }
}
