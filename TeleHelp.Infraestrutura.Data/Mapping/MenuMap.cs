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
    public class MenuMap : EntityTypeConfiguration<Menu>
    {
        public MenuMap()
        {
            // Primary Key
            this.HasKey(t => t.IdMenu);
            this.Property(t => t.IdMenu)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Descricao)
                .HasMaxLength(200);

            this.Property(t => t.Imagem)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Caminho)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Menu");
            this.Property(t => t.IdMenu).HasColumnName("IdMenu");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Imagem).HasColumnName("Imagem");
            this.Property(t => t.Caminho).HasColumnName("Caminho");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
            this.Property(t => t.IdSistema).HasColumnName("IdSistema");
            this.Property(t => t.IdMenuPai).HasColumnName("IdMenuPai");

            //foreign keys 
            HasOptional(t => t.Menu1)
                .WithMany()
                .HasForeignKey(t => t.IdMenuPai);

            HasRequired(t => t.Sistema)
                .WithMany(t => t.Menu)
                .HasForeignKey(t => t.IdSistema);


        }
    }
}
