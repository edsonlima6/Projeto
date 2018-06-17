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
    public class EmpresaMap : EntityTypeConfiguration<Empresa>
    {
        public EmpresaMap()
        {
            // Primary Key
            this.HasKey(t => t.idRazaoSocial);
            this.Property(t => t.idRazaoSocial)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.sRazaoSocial)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("Empresa");
            this.Property(t => t.idRazaoSocial).HasColumnName("idRazaoSocial");
            this.Property(t => t.sRazaoSocial).HasColumnName("sRazaoSocial");
            
            // Relationships
            this.HasRequired(t => t.tpEmpresa)
                .WithMany(t => t.Empresas)
                .HasForeignKey(d => d.idTipoEmpresa);
        }


    }
}
