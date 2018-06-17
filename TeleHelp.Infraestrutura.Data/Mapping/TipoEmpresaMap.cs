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
    public class TipoEmpresaMap : EntityTypeConfiguration<TipoEmpresa>
    {
        public TipoEmpresaMap()
        {
            this.HasKey(t => t.idTipoEmpresa);
            this.Property(t => t.idTipoEmpresa)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.sNome)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(120);

            this.Property(t => t.sDescricao)
                .IsOptional();


            // Table & Column Mappings
            this.ToTable("TipoEmpresa");
            this.Property(t => t.idTipoEmpresa).HasColumnName("idTipoEmpresa");
            this.Property(t => t.sNome).HasColumnName("sNome");
        }
    }
}
