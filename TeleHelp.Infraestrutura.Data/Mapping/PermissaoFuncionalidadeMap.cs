using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.Entities;

namespace TeleHelp.Infraestrutura.Data.Mapping
{
    public class PermissaoFuncionalidadeMap : EntityTypeConfiguration<PermissaoFuncionalidade>
    {
        public PermissaoFuncionalidadeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IdPermissaoTela, t.IdFuncionalidade });

            // Table & Column Mappings
            this.ToTable("GrupoFuncionalidade");
            this.Property(t => t.IdPermissaoTela).HasColumnName("IdGrupoTela");
            this.Property(t => t.IdFuncionalidade).HasColumnName("IdFuncionalidade");
            this.Property(t => t.Permite).HasColumnName("Permite");

            HasRequired(t => t.FuncionalidadeTela)
                .WithMany(f => f.PermissaoFuncionalidade)
                .HasForeignKey(t => t.IdFuncionalidade);


            HasRequired(t => t.PermissaoTela)
                .WithMany(f => f.PermissaoFuncionalidade)
                .HasForeignKey(t => t.IdPermissaoTela);
        }
    }
}
