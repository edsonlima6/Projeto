using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.Entities;

namespace TeleHelp.Infraestrutura.Data.Mapping
{
    class MenuTelaMap : EntityTypeConfiguration<MenuTela>
    {
        public MenuTelaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IdMenu, t.IdTela});

            // Table & Column Mappings
            this.ToTable("MenuTela");
            this.Property(t => t.IdMenu).HasColumnName("IdMenu");
            this.Property(t => t.IdTela).HasColumnName("IdTela");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");
            
            //foreign keys
            HasRequired(m => m.Menu)
                .WithMany(m => m.MenuTela)
                .HasForeignKey(mt => mt.IdMenu);

            HasRequired(mt => mt.Tela)
               .WithMany(m => m.MenuTela)
               .HasForeignKey(mt => mt.IdTela);

        }
    }

}
