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
    public class TipoEnderecoMap : EntityTypeConfiguration<TipoEndereco>
    {
        public TipoEnderecoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdTipoEndereco);
            this.Property(t => t.IdTipoEndereco)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("TipoEndereco");
            this.Property(t => t.IdTipoEndereco).HasColumnName("IdTipoEndereco");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Sigla).HasColumnName("Sigla");

        }
    }
}
